using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace SourceGeneratorBasic;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#augment-user-code
/// <summary>
/// Same as <see cref="AugmentingGenerator"/> but using ISyntaxContextReceiver.
/// </summary>
[Generator]
public class AugmentingContextGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        // Register a factory that can create our custom syntax receiver
        context.RegisterForSyntaxNotifications(() => new MySyntaxContextReceiver());
    }

    public void Execute(GeneratorExecutionContext context)
    {
        if (context.SyntaxContextReceiver is not MySyntaxContextReceiver syntaxReciever)
            return;

        // get the recorded user class
        var userClass = syntaxReciever.ClassToAugment.Syntax;

        if (userClass is null)
        {
            // if input class is not target, nothing will do.
            return;
        }

        var @namespace = syntaxReciever.ClassToAugment.Namespace;

        // add the generated implementation to the compilation
        var source = $@"// auto-generated
using System;

{(!string.IsNullOrEmpty(@namespace) ? $"namespace {@namespace};" : "")}
public partial class {userClass.Identifier}
{{
    public void GeneratedMethod()
    {{
        Console.WriteLine(""AugmentingContextGenerator {userClass.Identifier} generated code."");
    }}
}}
";
        context.AddSource($"AugmentingContextGenerator.{userClass.Identifier}.g.cs", SourceText.From(GeneratorHelper.ToLF(source), Encoding.UTF8));
    }

    class MySyntaxContextReceiver : ISyntaxContextReceiver
    {
        public (ClassDeclarationSyntax? Syntax, string? Namespace) ClassToAugment { get; private set; }
        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax cds && cds.Identifier.ValueText == "UserClassAugmentContext")
            {
                var ns = context.SemanticModel.GetDeclaredSymbol(cds)?.ContainingNamespace.ToDisplayString();
                ClassToAugment = (cds, ns);
            }
        }
    }
}
