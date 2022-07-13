using FluentAssertions;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.CustomGenerator>;

namespace SourceGeneratorBasic.UnitTests;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#unit-testing-of-generators
public class CustomGeneratorUnitTest
{
    [Fact]
    public void CustomGeneratorCompileTest()
    {
        var code = @"namespace Foo;
public partial class UserClass
{
    public void UserMethod()
    {
        GeneratedNamespace.GeneratedClass.GeneratedMethod();
    }
}";

        var compilation = TestHelper.CreateCompilation(code);

        // Run Generator
        var driver = TestHelper.CreateDriver(compilation, new CustomGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        diagnostics.Should().BeEmpty();

        // No Compilation error after generator
        outputCompilation.GetDiagnostics().Where(x => x.Severity >= DiagnosticSeverity.Error).Should().BeEmpty();
    }

    [Fact]
    public async Task CustomGeneratorGenerateResultTest()
    {
        var code = @"namespace Foo;
public partial class UserClass
{
    public void UserMethod()
    {
        GeneratedNamespace.GeneratedClass.GeneratedMethod();
    }
}";
        var generated = @"// Auto-generated
using System;

namespace GeneratedNamespace;
public class GeneratedClass
{
    public static void GeneratedMethod()
    {
        Console.WriteLine(""CustomGenerator generated code"");
    }
}";
        await new VerifyCS.Test
        {
            TestState =
            {
                Sources = { code },
                GeneratedSources =
                {
                    (typeof(SourceGeneratorBasic.CustomGenerator), "CustomGenerator.g.cs", SourceText.From(generated, Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}
