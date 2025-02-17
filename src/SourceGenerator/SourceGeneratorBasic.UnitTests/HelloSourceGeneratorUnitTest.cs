﻿using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.HelloSourceGenerator>;

namespace SourceGeneratorBasic.UnitTests;

public class HelloSourceGeneratorUnitTest
{
    [Fact]
    public void WorkspaceCompileTest()
    {
        using var workspace = new TemporaryWorkspace(TemporaryWorkspaceOptions.Default with
        {
            OutputType = "Exe"
        });
        workspace.AddFileToProject("Program.cs", @"
namespace Foo;
partial class Program
{
    static void Main(string[] args)
    {
        HelloFrom(""Generated Code"");
    }

    static partial void HelloFrom(string name);
}
");

        var compilation = workspace.CreateCompilation();

        // There are reference error before generator run
        Assert.Empty(compilation.GetCompilationErrors());

        // Run Generator
        var driver = TestHelper.CreateDriver(new HelloSourceGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        Assert.Empty(diagnostics);

        // No Compilation error after generator
        Assert.Empty(outputCompilation.GetCompilationErrors());
    }

    [Fact]
    public async Task VerifyTest()
    {
        var code = @"
namespace Foo;
partial class Program
{
    static void Main(string[] args)
    {
        HelloFrom(""Generated Code"");
    }

    static partial void HelloFrom(string name);
}
";
        var generated = @"// Auto-generated code
using System;

namespace Foo
{
    public static partial class Program
    {
        static partial void HelloFrom(string name) => Console.WriteLine($""HelloSourceGenerator says: Hi from '{name}'"");
    }
}
";
        await new VerifyCS.Test
        {
            TestState =
            {
                OutputKind = Microsoft.CodeAnalysis.OutputKind.ConsoleApplication,
                Sources = { TestHelper.ToLF(code) },
                GeneratedSources =
                {
                    (typeof(SourceGeneratorBasic.HelloSourceGenerator), "Program.g.cs", SourceText.From(TestHelper.ToLF(generated), Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}
