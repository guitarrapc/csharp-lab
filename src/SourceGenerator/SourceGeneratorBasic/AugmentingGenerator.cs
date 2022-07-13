using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Text;

namespace SourceGeneratorBasic;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#augment-user-code
/// <summary>
/// Same as <see cref="AugmentingContextGenerator"/> but using ISyntaxReceiver.
/// </summary>
[Generator]
public class AugmentingGenerator : ISourceGenerator
{
    public void Initialize(GeneratorInitializationContext context)
    {
        // Register a factory that can create our custom syntax receiver
        context.RegisterForSyntaxNotifications(() => new MySyntaxReciever());
    }

    public void Execute(GeneratorExecutionContext context)
    {
        if (!(context.SyntaxReceiver is MySyntaxReciever syntaxReciever))
            return;

        // get the recorded user class
        var userClass = syntaxReciever.ClassToAugment;

        if (userClass is null)
        {
            // if input class is not target, nothing will do.
            return;
        }

        var @namespace = userClass.GetNamespaceName();

        // add the generated implementation to the compilation
        var source = $@"// auto-generated
{(!string.IsNullOrEmpty(@namespace) ? $"namespace {@namespace};" : "")}
public partial class {userClass.Identifier}
{{
    public void GeneratedMethod()
    {{
        Console.WriteLine(""AugmentingGenerator {userClass.Identifier} generated code."");
    }}
}}";
        context.AddSource($"AugmentingGenerator.{userClass.Identifier}.g.cs", SourceText.From(GeneratorHelper.ToLF(source), Encoding.UTF8));
    }

    class MySyntaxContextReceiver : ISyntaxContextReceiver
    {
        public (ClassDeclarationSyntax? Syntax, string? Namespace) ClassToAugment { get; private set; }
        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            if (context.Node is ClassDeclarationSyntax cds && cds.Identifier.ValueText == "UserClassAugment")
            {
                var ns = context.SemanticModel.GetDeclaredSymbol(cds)?.ContainingNamespace.ToDisplayString();
                ClassToAugment = (cds, ns);
            }
        }
    }
    class MySyntaxReciever : ISyntaxReceiver
    {
        public ClassDeclarationSyntax? ClassToAugment { get; private set; }

        public void OnVisitSyntaxNode(SyntaxNode syntaxNode)
        {
            // Business logic to decide what we're interested in goes here
            if (syntaxNode is ClassDeclarationSyntax cds && cds.Identifier.ValueText == "UserClassAugment")
            {
                ClassToAugment = cds;
            }
        }
    }
}
