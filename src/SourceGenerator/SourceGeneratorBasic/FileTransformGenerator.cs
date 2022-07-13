using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SourceGeneratorBasic;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#additional-file-transformation
[Generator]
public class FileTransformGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        // No initialization required for this one
    }

    public void Execute(GeneratorExecutionContext context)
    {
        var files = context.AdditionalFiles.Where(x => x.Path.EndsWith(".txt", System.StringComparison.OrdinalIgnoreCase));
        foreach (var file in files)
        {
            Debug.WriteLine($"{nameof(FileTransformGenerator)} detected file {file.Path}.");
            var content = file.GetText(context.CancellationToken);
            if (content is not null)
            {
                // do some transforms based on the file content.
                var output = TextToCsharpCompiler.Compile(content);

                var source = SourceText.From(output, Encoding.UTF8);
                context.AddSource($"{System.IO.Path.GetFileName(file.Path)}.g.cs", source);
            }
        }
    }
}

public class TextToCsharpCompiler
{
    // Output text as csharp.
    public static string Compile(SourceText content) => GeneratorHelper.ToLF(content.ToString());
}
