using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;
using System.Text;

namespace SourceGeneratorBasic.UnitTests;

public class TemporaryWorkspace : IDisposable
{
    private readonly string _basePath;
    private readonly string _csprojName = "Temp.csproj";
    private readonly TemporaryWorkspaceOptions _options;

    public string ProjectDirectory { get; }
    public string CsProjFilePath { get; }
    public Guid WorkspaceId { get; }

    public TemporaryWorkspace(TemporaryWorkspaceOptions options)
    {
        WorkspaceId = Guid.NewGuid();

        _options = options;
        _basePath = Path.Combine(Path.GetTempPath(), $"{GetType().FullName}-{WorkspaceId}");

        ProjectDirectory = Path.Combine(_basePath, "Project");
        CsProjFilePath = Path.Combine(_basePath, _csprojName);

        Directory.CreateDirectory(ProjectDirectory);

        var csprojContents = $@"<Project Sdk=""Microsoft.NET.Sdk"">
  <PropertyGroup>
    <TargetFramework>{options.TargetFramework}</TargetFramework>
    {(options.OutputType != "" ? $"<OutputType>{options.OutputType}</OutputType>" : "")}
    {(options.LangVersion != "" ? $"<LangVersion>{options.LangVersion}</LangVersion>" : "")}
    {(options.Nullable ? $"<Nullable>enable</Nullable>" : "")}
  </PropertyGroup>

  <ItemGroup>
    {string.Join("\n", (options.ProjectReferences ?? Array.Empty<string>()).Select(x => $@"<ProjectReference Include=""{x}"" />"))}
    {string.Join("\n", (options.AdditionalFilesReferences ?? Array.Empty<string>()).Select(x => $@"<AdditionalFiles Include=""{x}"" />"))}
  </ItemGroup>

</Project>
";
        AddFileToProject(_csprojName, csprojContents);
    }

    public void AddFileToProject(string fileName, string contents)
    {
        var c = contents.Trim();
        File.WriteAllText(Path.Combine(ProjectDirectory, fileName), TestHelper.ToLF(c));
    }

    // https://gist.github.com/chsienki/2955ed9336d7eb22bcb246840bfeb05c
    public Compilation CreateCompilation()
    {
        var refAsmDir = Path.GetDirectoryName(typeof(object).Assembly.Location)!;
        var compilationOption = _options.OutputType == ""
            ? new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary) // .dll
            : new CSharpCompilationOptions(OutputKind.ConsoleApplication);  // .exe

        var compilation = CSharpCompilation.Create(assemblyName: Guid.NewGuid().ToString()) // make always random
            .AddSyntaxTrees(
                Directory.EnumerateFiles(ProjectDirectory, "*.cs", SearchOption.AllDirectories)
                .Select(x => CSharpSyntaxTree.ParseText(File.ReadAllText(x), CSharpParseOptions.Default, x, Encoding.UTF8)))
            .AddReferences(new[] {
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Private.CoreLib.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Runtime.Extensions.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Collections.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Linq.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Linq.Expressions.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Console.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Runtime.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "System.Memory.dll")),
                MetadataReference.CreateFromFile(Path.Combine(refAsmDir, "netstandard.dll")),
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location)
            })
            .AddReferences(_options.References ?? Array.Empty<MetadataReference>())
            .WithOptions(compilationOption.WithSpecificDiagnosticOptions(compilationOption.SpecificDiagnosticOptions.SetItems(GetNullableWarningsFromCompiler())));

        return compilation;
    }

    /// <summary>
    /// AdditionalTexts to notify Roslyn there are additional files.
    /// </summary>
    /// <returns></returns>
    public IReadOnlyList<AdditionalText> GetAdditionalTexts()
    {
        if (_options.AdditionalFilesReferences is null)
            return Array.Empty<CustomAdditionalText>();

        return _options.AdditionalFilesReferences.Select(x => new CustomAdditionalText(Path.Combine(ProjectDirectory, x))).ToArray();
    }

    /// <summary>
    /// Treat nullable warning as error
    /// </summary>
    /// <returns></returns>
    private static ImmutableDictionary<string, ReportDiagnostic> GetNullableWarningsFromCompiler()
    {
        var args = new[] { "/warnaserror:nullable" };
        var commandLineArguments = CSharpCommandLineParser.Default.Parse(args, baseDirectory: Environment.CurrentDirectory, sdkDirectory: Environment.CurrentDirectory);
        var nullableWarnings = commandLineArguments.CompilationOptions.SpecificDiagnosticOptions;

        return nullableWarnings;
    }

    public void Dispose()
    {
        if (_options.CleanupOnDispose)
        {
            if (Directory.Exists(_basePath))
            {
                Directory.Delete(_basePath, recursive: true);
            }
        }
    }
}

public record TemporaryWorkspaceOptions(string TargetFramework = "netstandard2.0", string OutputType = "", bool CleanupOnDispose = true)
{
    public static TemporaryWorkspaceOptions Default { get; } = new TemporaryWorkspaceOptions();

    public string LangVersion { get; init; } = "";
    public bool Nullable { get; init; } = false;
    public IEnumerable<MetadataReference>? References { get; init; }
    public IEnumerable<string>? ProjectReferences { get; init; }
    public IEnumerable<string>? AdditionalFilesReferences { get; init; }
}

