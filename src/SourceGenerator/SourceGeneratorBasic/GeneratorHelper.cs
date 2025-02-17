namespace SourceGeneratorBasic;
public static class GeneratorHelper
{
    public static string ToLF(string content) => content.Replace("\r\n", "\n");
}
