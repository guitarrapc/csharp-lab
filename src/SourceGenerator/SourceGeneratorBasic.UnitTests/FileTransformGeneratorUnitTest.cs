using FluentAssertions;
using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.UnitTests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.FileTransformGenerator>;

namespace SourceGeneratorBasic.UnitTests;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#unit-testing-of-generators
public class FileTransformGeneratorUnitTest
{
    // Test error on outputCompilation could not reference generated code. Missing FileGeneratedNamespace.
    //    [Fact]
    //    public void WorkspaceCompileTest()
    //    {
    //        using var workspace = new TemporaryWorkspace(TemporaryWorkspaceOptions.Default with
    //        {
    //            AdditionalFilesReferences = new[]
    //            {
    //                "Csharp.txt"
    //            }
    //        });
    //        workspace.AddFileToProject("UserClass.cs", @"
    //namespace Foo
    //{
    //    public partial class UserClass
    //    {
    //        public void UserMethod()
    //        {
    //            var fileTransform = new FileGeneratedNamespace.GeneratedClass();
    //            fileTransform.GeneratedMethod();
    //        }
    //    }
    //}
    //");
    //        workspace.AddFileToProject("Csharp.txt", @"
    //using System;

    //namespace FileGeneratedNamespace
    //{
    //    public class GeneratedClass
    //    {
    //        public void GeneratedMethod()
    //        {
    //            Console.WriteLine(""FileGenerator generated code"");
    //        }
    //    }
    //}
    //");
    //        var compilation = workspace.CreateCompilation();

    //        // There are reference error before generator run
    //        compilation.GetCompilationErrors().Should().NotBeEmpty();

    //        // Run Generator
    //        var driver = TestHelper.CreateDriver(compilation, new FileTransformGenerator());
    //        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

    //        // Generator must run without error
    //        diagnostics.Should().BeEmpty();

    //        // No Compilation error after generator
    //        outputCompilation.GetCompilationErrors().Should().BeEmpty();
    //    }

    [Fact]
    public async Task GenerateDiffTest()
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
                Sources = { code },
                AdditionalFiles = { ("Csharp.txt" , generated) },
                GeneratedSources =
                {
                    (typeof(SourceGeneratorBasic.FileTransformGenerator), "Csharp.txt.g.cs", SourceText.From(generated, Encoding.UTF8, SourceHashAlgorithm.Sha1)),
                },
            },
        }.RunAsync();
    }
}