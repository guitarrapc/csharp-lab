using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.FileTransformGenerator>;

namespace SourceGeneratorBasic.UnitTests;

// see: https://notanaverageman.github.io/2020/12/07/cs-source-generators-cheatsheet.html
public class FileTransformGeneratorUnitTest
{
    // FileTransform require AddFiles, so cannot appry SourceCompile test.

    [Fact]
    public void WorkspaceCompileTest()
    {
        using var workspace = new TemporaryWorkspace(TemporaryWorkspaceOptions.Default with
        {
            CleanupOnDispose = false,
            AdditionalFilesReferences =
            [
                "Csharp.txt"
            ]
        });
        workspace.AddFileToProject("UserClass.cs", @"
namespace Foo
{
    public partial class UserClass
    {
        public void UserMethod()
        {
            var fileTransform = new FileGeneratedNamespace.GeneratedClass();
            fileTransform.GeneratedMethod();
        }
    }
}
");
        workspace.AddFileToProject("Csharp.txt", @"
using System;

namespace FileGeneratedNamespace
{
    public class GeneratedClass
    {
        public void GeneratedMethod()
        {
            Console.WriteLine(""FileGenerator generated code"");
        }
    }
}
");
        var compilation = workspace.CreateCompilation();

        // There are reference error before generator run
        Assert.NotEmpty(compilation.GetCompilationErrors());

        // Run Generator
        var driver = TestHelper.CreateDriver(workspace.GetAdditionalTexts(), new FileTransformGenerator());
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
namespace Foo
{
    public partial class UserClass
    {
        public void UserMethod()
        {
            var fileTransform = new FileGeneratedNamespace.GeneratedClass();
            fileTransform.GeneratedMethod();
        }
    }
}
";
        var generated = @"
using System;

namespace FileGeneratedNamespace
{
    public class GeneratedClass
    {
        public void GeneratedMethod()
        {
            Console.WriteLine(""FileGenerator generated code"");
        }
    }
}
";
        await new VerifyCS.Test
        {
            TestState =
            {
                Sources = { TestHelper.ToLF(code) },
                AdditionalFiles = { ("Csharp.txt" , TestHelper.ToLF(generated)) },
                GeneratedSources =
                {
                    (typeof(SourceGeneratorBasic.FileTransformGenerator), "Csharp.txt.g.cs", SourceText.From(TestHelper.ToLF(generated), Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}
