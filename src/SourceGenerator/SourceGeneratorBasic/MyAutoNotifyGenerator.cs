using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SourceGeneratorBasic;

/*

Create MyAutoNotifyAttribute and INotifyPropertyChanged for filed added MyAutoNotifyAttribute.

from this source...
```cs
using MyAutoNotify;

public partial class UserClass
{
    [MyAutoNotifyAttribute]
    private bool _boolProp;

    [MyAutoNotifyAttribute(PropertyName = "Count")]
    private int _intProp;
}
```

to this source...
```cs
public partial class UserClass : INotifyPropertyChanged
{
    public bool BoolProp
    {
        get => _boolProp;
        set
        {
            this._boolProp = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("UserBool"));
        }
    }

    public int Count
    {
        get => _intProp;
        set
        {
            this._intProp = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
}
```
 */


// see: https://github.com/dotnet/roslyn/blob/main/docs/features/source-generators.cookbook.md#inotifypropertychanged
// see detail: https://github.com/dotnet/roslyn-sdk/blob/df51b014fcb8c9e667a0b09a000f2050615f7afb/samples/CSharp/SourceGenerators/SourceGeneratorSamples/AutoNotifyGenerator.cs
[Generator]
public class MyAutoNotifyGenerator : ISourceGenerator
{
    private const string namespaceString = "MyAutoNotify";
    private const string attributeName = namespaceString + "Attirbute";
    private const string attributeSource = $@"// auto-generated
using System;

namespace {namespaceString}
{{
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    sealed class {attributeName} : Attribute
    {{
        public {attributeName}() {{ }}
        public string PropertyName {{ get; set; }}
    }}
}}
";

    public void Initialize(GeneratorInitializationContext context)
    {
        // Register callback called right after Source Generator Initialization completed. Called Once only. Recomended to create Generator's attirbutes.
        context.RegisterForPostInitialization((i) => i.AddSource("MyAutoNotifyAttirbute.g.cs", attributeSource));

        // Register syntax receiver.
        context.RegisterForSyntaxNotifications(() => new SyntaxReceiver());
    }

    public void Execute(GeneratorExecutionContext context)
    {
        // do with our SyntaxReceiver only,
        if (!(context.SyntaxContextReceiver is SyntaxReceiver receiver))
            return;

        var attributeSymbol = context.Compilation.GetTypeByMetadataName($"{namespaceString}.{attributeName}");
        var notifySymbol = context.Compilation.GetTypeByMetadataName("System.ComponentModel.INotifyPropertyChanged");

        // generate source code
        // group by <IFieldSymbol, INamedTypeSymbol> is key point. default is <ISymbol, IFieldSymbol>
        foreach (var group in receiver.Fields.GroupBy<IFieldSymbol, INamedTypeSymbol>(x => x.ContainingType, SymbolEqualityComparer.Default))
        {
            var source = GenerateSource(group.Key, group.ToArray(), attributeSymbol, notifySymbol, context);
            if (source is not null)
            {
                context.AddSource($"{group.Key.Name}_{namespaceString}.g.cs", SourceText.From(source, Encoding.UTF8));
            }
        }
    }

    private string? GenerateSource(INamedTypeSymbol classSymbol, IReadOnlyList<IFieldSymbol> fields, ISymbol? attributeSymbol, ISymbol? notifySymbol, GeneratorExecutionContext context)
    {
        // Nothing do when attribute not found
        if (attributeSymbol is null)
            return null;

        // Nothing do when notify interface not found
        if (notifySymbol is null)
            return null;

        // Nothing do when missing namespace
        if (!classSymbol.ContainingSymbol.Equals(classSymbol.ContainingNamespace, SymbolEqualityComparer.Default))
            return null; //TODO: issue a diagnostic that it must be top level

        var namespaceName = classSymbol.ContainingNamespace.ToDisplayString();

        // Create Class
        var source = new StringBuilder($@"// auto-generated
namespace {namespaceName};

public partial class {classSymbol.Name}: {notifySymbol.ToDisplayString()}
{{
");
        // If Class doesn't implement notify synbol, add it on generated class.
        if (!classSymbol.Interfaces.Contains(notifySymbol, SymbolEqualityComparer.Default))
        {
            source.Append("    public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;");
            source.Append($@"
    public void AddPropertyChanged<TProp>(System.Linq.Expressions.Expression<Func<{classSymbol.Name}, TProp>> propertyName, System.Action<{classSymbol.Name}> handler)
    {{
        var name = ((System.Linq.Expressions.MemberExpression)propertyName.Body).Member.Name;
        PropertyChanged += (sender, e) =>
        {{
            if (e.PropertyName == name)
            {{
                handler(this);
            }}
        }};
    }}
");
        }

        // Create properties
        foreach (var filedSymbol in fields)
        {
            GenerateField(source, filedSymbol, attributeSymbol);
        }

        source.Append("}");
        return source.ToString();
    }

    private void GenerateField(StringBuilder source, IFieldSymbol fieldSymbol, ISymbol attributeSymbol)
    {
        // Get field Name and Type
        var fieldName = fieldSymbol.Name;
        var fieldType = fieldSymbol.Type;

        // Get attribute from field.
        var attributeData = fieldSymbol.GetAttributes().Single(x => x.AttributeClass!.Equals(attributeSymbol, SymbolEqualityComparer.Default));
        var overrideName = attributeData.NamedArguments.SingleOrDefault(x => x.Key == "PropertyName").Value; // Name override property.

        var propertyName = choosePropertyName(fieldName, overrideName);
        if (propertyName.Length == 0 || propertyName == fieldName)
        {
            // Can not process PropertyName generation. It's same as proerptyName.
            return; //TODO: issue a diagnostic that we can't process this field
        }

        source.Append($@"
    public {fieldType} {propertyName}
    {{
        get => this.{fieldName};
        set
        {{
            this.{fieldName} = value;
            this.PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof({propertyName})));
        }}
    }}
");

        string choosePropertyName(string fieldName, TypedConstant overridenName)
        {
            // Use override name.
            if (!overridenName.IsNull)
            {
                return overridenName.Value?.ToString() ?? string.Empty;
            }

            // Change _foo -> foo.
            var f = fieldName.TrimStart('_');
            if (f.Length == 0)
                return string.Empty;

            // Change _f -> F
            if (f.Length == 1)
                return f.ToUpper();

            // Change _foo -> Foo
            return f.Substring(0, 1).ToUpper() + f.Substring(1);
        }
    }

    class SyntaxReceiver : ISyntaxContextReceiver
    {
        public List<IFieldSymbol> Fields { get; } = new();

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            // any field at least one attribute is taget candidates.
            if (context.Node is FieldDeclarationSyntax fieldDeclarationSyntax && fieldDeclarationSyntax.AttributeLists.Count > 0)
            {
                foreach (var variable in fieldDeclarationSyntax.Declaration.Variables)
                {
                    // get attribute from field symbol. if attribute is ours, it's target field.
                    if (context.SemanticModel.GetDeclaredSymbol(variable) is IFieldSymbol fieldSymbol)
                    {
                        if (fieldSymbol.GetAttributes().Any(x => x.AttributeClass?.ToDisplayString() == $"{namespaceString}.{attributeName}"))
                        {
                            Fields.Add(fieldSymbol);
                        }
                    }
                }
            }
        }
    }
}
