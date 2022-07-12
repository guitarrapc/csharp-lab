using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace SourceGeneratorBasic;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#generated-class
[Generator]
public class CustomGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        var source = $@"// Auto-generated
namespace GeneratedNamespace;
public class GeneratedClass
{{
    public static void GeneratedMethod()
    {{
        Console.WriteLine(""CustomGenerator generated code"");
    }}
}}";
        context.AddSource("CustomGenerator.g.cs", SourceText.From(source, Encoding.UTF8));
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // No initialization required for this one
    }
}