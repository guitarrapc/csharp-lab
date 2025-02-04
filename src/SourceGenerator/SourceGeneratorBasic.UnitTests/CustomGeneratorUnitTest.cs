using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.CustomGenerator>;

namespace SourceGeneratorBasic.UnitTests;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#unit-testing-of-generators
public class CustomGeneratorUnitTest
{
    [Fact]
    public void SourceCompileTest()
    {
        var code = @"
namespace Foo;
public partial class UserClass
{
    public void UserMethod()
    {
        GeneratedNamespace.GeneratedClass.GeneratedMethod();
    }
}";

        var compilation = TestHelper.CreateCompilation(code);

        // Run Generator
        var driver = TestHelper.CreateDriver(new CustomGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        Assert.Empty(diagnostics);

        // No Compilation error after generator
        Assert.Empty(outputCompilation.GetCompilationErrors());
    }

    [Fact]
    public void WorkspaceCompileTest()
    {
        using var workspace = new TemporaryWorkspace(TemporaryWorkspaceOptions.Default);
        workspace.AddFileToProject("UserClass.cs", @"
namespace Foo;
public partial class UserClass
{
    public void UserMethod()
    {
        GeneratedNamespace.GeneratedClass.GeneratedMethod();
    }
}"
);

        var compilation = workspace.CreateCompilation();

        // There are reference error before generator run
        Assert.NotEmpty(compilation.GetCompilationErrors());

        // Run Generator
        var driver = TestHelper.CreateDriver(new CustomGenerator());
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
public partial class UserClass
{
    public void UserMethod()
    {
        GeneratedNamespace.GeneratedClass.GeneratedMethod();
    }
}";
        var generated = @"// Auto-generated
using System;

namespace GeneratedNamespace
{
    public class GeneratedClass
    {
        public static void GeneratedMethod()
        {
            Console.WriteLine(""CustomGenerator generated code"");
        }
    }
}
";
        await new VerifyCS.Test
        {
            TestState =
            {
                Sources = { TestHelper.ToLF(code) },
                GeneratedSources =
                {
                    (typeof(SourceGeneratorBasic.CustomGenerator), "CustomGenerator.g.cs", SourceText.From(TestHelper.ToLF(generated), Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}
