using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace SourceGeneratorBasic;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#augment-user-code
[Generator]
public class AugmentingContextGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
        if (!(context.SyntaxContextReceiver is MySyntaxContextReceiver syntaxReciever))
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
{(!string.IsNullOrEmpty(@namespace) ? $"namespace {@namespace};" : "")}
public partial class {userClass.Identifier}
{{
    public void GeneratedMethod()
    {{
        Console.WriteLine(""AugmentingContextGenerator {userClass.Identifier} generated code."");
    }}
}}";
        context.AddSource($"AugmentingGenerator.{userClass.Identifier}.g.cs", SourceText.From(source, Encoding.UTF8));
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // Register a factory that can create our custom syntax receiver
        //context.RegisterForSyntaxNotifications(() => new MySyntaxReciever());
        context.RegisterForSyntaxNotifications(() => new MySyntaxContextReceiver());
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
