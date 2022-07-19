using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;

namespace SourceGeneratorBasic;
public static class ClassDeclarationSyntaxExtensions
{
    public static string GetNamespaceName(this ClassDeclarationSyntax source)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source));

        var items = new List<string>();
        var parent = source.Parent;
        while (parent.IsKind(SyntaxKind.ClassDeclaration))
        {
            if (parent is ClassDeclarationSyntax parentClass)
            {
                items.Add(parentClass.Identifier.Text);
                parent = parent.Parent;
            }
        }

        if (parent is FileScopedNamespaceDeclarationSyntax @namespace2)
        {
            return @namespace2.Name.ToString();
        }
        else if (parent is NamespaceDeclarationSyntax @namespace3)
        {
            return @namespace3.Name.ToString();
        }
        else
        {
            return "";
        }
    }
}
