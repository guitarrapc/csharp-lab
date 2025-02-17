using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;

namespace SourceGeneratorBasic.UnitTests;

public static class CompilationExtensions
{
    public static IReadOnlyList<Diagnostic> GetCompilationErrors(this Compilation compilation)
    {
        var diagnostics = compilation.GetDiagnostics();
        return diagnostics.Where(x => x.Severity >= DiagnosticSeverity.Error).ToArray();
    }
}

public static class TestHelper
{
    public static string ToLF(string content) => content.Replace("\r\n", "\n");

    // https://gist.github.com/chsienki/2955ed9336d7eb22bcb246840bfeb05c
    public static Compilation CreateCompilation(string source, IReadOnlyList<MetadataReference>? references = null)
    {
        var refAsmDir = Path.GetDirectoryName(typeof(object).Assembly.Location)!;
        var compilationOption = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary); // .dll

        var compilation = CSharpCompilation.Create(assemblyName: Guid.NewGuid().ToString()) // make always random
            .AddSyntaxTrees(new[] { CSharpSyntaxTree.ParseText(ToLF(source)) })
            .AddReferences(new[] {
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
            })
            .AddReferences(references ?? Array.Empty<MetadataReference>())
            .WithOptions(compilationOption.WithSpecificDiagnosticOptions(compilationOption.SpecificDiagnosticOptions.SetItems(GetNullableWarningsFromCompiler())));

        return compilation;
    }

    public static GeneratorDriver CreateDriver(params ISourceGenerator[] generators) => CSharpGeneratorDriver.Create(
        generators: ImmutableArray.Create(generators),
        additionalTexts: ImmutableArray<AdditionalText>.Empty,
        parseOptions: CSharpParseOptions.Default,
        optionsProvider: null
    );
    public static GeneratorDriver CreateDriver(IEnumerable<AdditionalText> additionalTexts, params ISourceGenerator[] generators)
    {
        // If AdditionalFiles is using, you must pass it to Roslyn compiler. Otherwise Roslyn could not understand csproj AdditionalFiles entry.
        // see: https://notanaverageman.github.io/2020/12/07/cs-source-generators-cheatsheet.html
        return CSharpGeneratorDriver.Create(
            generators: ImmutableArray.Create(generators),
            additionalTexts: additionalTexts,
            parseOptions: CSharpParseOptions.Default,
            optionsProvider: null
        );
    }

    private static ImmutableDictionary<string, ReportDiagnostic> GetNullableWarningsFromCompiler()
    {
        var args = new[] { "/warnaserror:nullable" };
        var commandLineArguments = CSharpCommandLineParser.Default.Parse(args, baseDirectory: Environment.CurrentDirectory, sdkDirectory: Environment.CurrentDirectory);
        var nullableWarnings = commandLineArguments.CompilationOptions.SpecificDiagnosticOptions;

        return nullableWarnings;
    }
}
