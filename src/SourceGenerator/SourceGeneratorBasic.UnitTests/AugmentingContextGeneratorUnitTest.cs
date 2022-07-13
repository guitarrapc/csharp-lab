using FluentAssertions;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.AugmentingContextGenerator>;

namespace SourceGeneratorBasic.UnitTests;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#unit-testing-of-generators
public class AugmentingContextGeneratorUnitTest
{
    [Fact]
    public void SourceCompileTest()
    {
        var code = @"
namespace Foo;
public partial class UserClassAugmentContext
{
    public void UserMethod()
    {
        GeneratedMethod();
    }
}
";

        var compilation = TestHelper.CreateCompilation(code);

        // Run Generator
        var driver = TestHelper.CreateDriver(new AugmentingContextGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        diagnostics.Should().BeEmpty();

        // No Compilation error after generator
        outputCompilation.GetCompilationErrors().Should().BeEmpty();
    }

    [Fact]
    public void WorkspaceCompileTest()
    {
        using var workspace = new TemporaryWorkspace(TemporaryWorkspaceOptions.Default);
        workspace.AddFileToProject("UserClass.cs", @"
namespace Foo;
public partial class UserClassAugmentContext
{
    public void UserMethod()
    {
        GeneratedMethod();
    }
}
"
);

        var compilation = workspace.CreateCompilation();

        // There are reference error before generator run
        compilation.GetCompilationErrors().Should().NotBeEmpty();

        // Run Generator
        var driver = TestHelper.CreateDriver(new AugmentingContextGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        diagnostics.Should().BeEmpty();

        // No Compilation error after generator
        outputCompilation.GetCompilationErrors().Should().BeEmpty();
    }

    [Fact]
    public async Task GenerateDiffTest()
    {
        var code = @"
namespace Foo;
public partial class UserClassAugmentContext
{
    public void UserMethod()
    {
        GeneratedMethod();
    }
}
";
        var generated = @"// auto-generated
using System;

namespace Foo;
public partial class UserClassAugmentContext
{
    public void GeneratedMethod()
    {
        Console.WriteLine(""AugmentingContextGenerator UserClassAugmentContext generated code."");
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
                    (typeof(SourceGeneratorBasic.AugmentingContextGenerator), "AugmentingContextGenerator.UserClassAugmentContext.g.cs", SourceText.From(TestHelper.ToLF(generated), Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}
