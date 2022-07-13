using FluentAssertions;
using Microsoft.CodeAnalysis;

namespace SourceGeneratorBasic.Driver.Tests;

public class GeneratorTest
{
    [Fact]
    public void CustomGeneratorTest()
    {
        var code = @"namespace Foo;
public partial class UserClass
{
    public void UserMethod()
    {
        GeneratedNamespace.GeneratedClass.GeneratedMethod();
    }
}";
        var compilation = TestHelper.CreateCompilation(code);

        // Run Generator
        var driver = TestHelper.CreateDriver(compilation, new CustomGenerator());
        driver.RunGeneratorsAndUpdateCompilation(compilation, out var outputCompilation, out var diagnostics);

        // Generator must run without error
        diagnostics.Should().BeEmpty();

        // No Compilation error after generator
        outputCompilation.GetDiagnostics().Where(x => x.Severity >= DiagnosticSeverity.Error).Should().BeEmpty();
    }
}
