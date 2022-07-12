using Microsoft.CodeAnalysis;
using System.Linq;
using System.Xml;

namespace SourceGeneratorBasic;

// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#issue-diagnostics
[Generator]
public class IssueDiagticGenerator : ISourceGenerator
{
    private static readonly DiagnosticDescriptor invalidXmlWarning = new DiagnosticDescriptor(id: Constants.ErrorId.InvalidXmlParsefailed, title: "Couldn't parse XML file", messageFormat: "Couldn't parse XML file '{0}'", category: "IssueDiagticGenerator", DiagnosticSeverity.Warning, isEnabledByDefault: true);

    public void Execute(GeneratorExecutionContext context)
    {
        // Code generation goes here
        var xmlFiles = context.AdditionalFiles.Where(x => x.Path.EndsWith(".xml", System.StringComparison.OrdinalIgnoreCase));
        foreach (var xmlFile in xmlFiles)
        {
            var doc = new XmlDocument();
            var text = xmlFile.GetText(context.CancellationToken)?.ToString();
            try
            {
                doc?.LoadXml(text);
            }
            catch (System.Exception)
            {
                context.ReportDiagnostic(Diagnostic.Create(invalidXmlWarning, Location.None, xmlFile.Path));
                continue;
            }
        }

        // no need generation.
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        // No initialization required for this one
    }
}
