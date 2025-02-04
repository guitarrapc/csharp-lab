using Microsoft.CodeAnalysis;

namespace SourceGeneratorBasic;

// see: https://docs.microsoft.com/ja-jp/dotnet/csharp/roslyn-sdk/source-generators-overview
[Generator]
public class HelloSourceGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // No initialization required for this one
    }

    public void Execute(GeneratorExecutionContext context)
    {
        // Code generation goes here
        var mainMethod = context.Compilation.GetEntryPoint(context.CancellationToken);
        if (mainMethod != null)
        {
            var source = $@"// Auto-generated code
using System;

namespace {mainMethod.ContainingNamespace.ToDisplayString()}
{{
    public static partial class {mainMethod.ContainingType.Name}
    {{
        static partial void HelloFrom(string name) => Console.WriteLine($""HelloSourceGenerator says: Hi from '{{name}}'"");
    }}
}}
";
            var typeName = mainMethod.ContainingType.Name;

            // Add source code to the compilation
            context.AddSource($"{typeName}.g.cs", GeneratorHelper.ToLF(source));
        }
    }
}
