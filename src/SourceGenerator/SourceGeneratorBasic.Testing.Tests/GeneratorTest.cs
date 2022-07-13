using Microsoft.CodeAnalysis.Text;
using System.Text;
using VerifyCS = SourceGeneratorBasic.Testing.Tests.CSharpSourceGeneratorVerifier<SourceGeneratorBasic.CustomGenerator>;

namespace SourceGeneratorBasic.Testing.Tests;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#unit-testing-of-generators
public class GeneratorTest
{
    [Fact]
    public async Task CustomGeneratorTest()
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
