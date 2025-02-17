using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.AugmentingGenerator>;

namespace SourceGeneratorBasic.UnitTests;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#unit-testing-of-generators
public class AugmentingGeneratorUnitTest
{
    [Fact]
    public void SourceCompileTest()
    {
        var code = @"
namespace Foo;
public partial class UserClassAugment
{
    public void UserMethod()
    {
        GeneratedMethod();
    }
}
";

        var compilation = TestHelper.CreateCompilation(code);

        // Run Generator
        var driver = TestHelper.CreateDriver(new AugmentingGenerator());
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
public partial class UserClassAugment
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
        Assert.NotEmpty(compilation.GetCompilationErrors());

        // Run Generator
        var driver = TestHelper.CreateDriver(new AugmentingGenerator());
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
public partial class UserClassAugment
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
public partial class UserClassAugment
{
    public void GeneratedMethod()
    {
        Console.WriteLine(""AugmentingGenerator UserClassAugment generated code."");
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
                    (typeof(SourceGeneratorBasic.AugmentingGenerator), "AugmentingGenerator.UserClassAugment.g.cs", SourceText.From(TestHelper.ToLF(generated), Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}
