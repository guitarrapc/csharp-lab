using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace SourceGeneratorBasic.UnitTests;
public class CustomAdditionalText : AdditionalText
{
    public override string Path { get; }

    private readonly string _text;

    public CustomAdditionalText(string path)
    {
        Path = path;
        _text = File.ReadAllText(path);
    }

    public override SourceText? GetText(CancellationToken cancellationToken = default)
    {
        return SourceText.From(_text);
    }
}
