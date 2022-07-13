using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;
using System.Reflection;

namespace SourceGeneratorBasic.Driver.Tests;
public static class TestHelper
{
    // https://gist.github.com/chsienki/2955ed9336d7eb22bcb246840bfeb05c
    public static Compilation CreateCompilation(string source, params Type[] metadataLocations)
    {
        var refAsmDir = Path.GetDirectoryName(typeof(object).Assembly.Location)!;

        return CSharpCompilation.Create(
            assemblyName: Guid.NewGuid().ToString(),
            syntaxTrees: new[] { CSharpSyntaxTree.ParseText(source) },
            references: new[] {
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Private.CoreLib.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Runtime.Extensions.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Collections.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Linq.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Linq.Expressions.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Console.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Runtime.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Memory.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "netstandard.dll")),
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location)
            },
            options: new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary) // .dll
        );
    }

    public static GeneratorDriver CreateDriver(Compilation compilation, params ISourceGenerator[] generators) => CSharpGeneratorDriver.Create(
        generators: ImmutableArray.Create(generators),
        additionalTexts: ImmutableArray<AdditionalText>.Empty,
        parseOptions: CSharpParseOptions.Default,
        optionsProvider: null
    );
}
