namespace Strings.Core;

public static class StringExtensions
{
    /// <summary>
    /// Allocation free split
    /// </summary>
    /// <param name="str"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static SplitEnumerator SplitNoAlloc(this string str, char separator)
    {
        // LineSplitEnumerator is a struct so there is no allocation here
        return new SplitEnumerator(str.AsSpan(), separator);
    }
    /// <summary>
    /// Allocation free split
    /// </summary>
    /// <param name="str"></param>
    /// <param name="separator"></param>
    /// <returns></returns>
    public static SplitEnumerator SplitNoAlloc(this ReadOnlySpan<char> str, char separator)
    {
        // LineSplitEnumerator is a struct so there is no allocation here
        return new SplitEnumerator(str, separator);
    }

    // Must be a ref struct as it contains a ReadOnlySpan<char>
    public ref struct SplitEnumerator(ReadOnlySpan<char> str, char separator)
    {
        private readonly char _separator = separator;
        private ReadOnlySpan<char> _str = str;

        // Needed to be compatible with the foreach operator
        public SplitEnumerator GetEnumerator() => this;

        public bool MoveNext()
        {
            var span = _str;
            if (span.Length == 0) // Reach the end of the string
                return false;

            var index = span.IndexOf(_separator);
            if (index == -1) // The string is composed of only one line
            {
                _str = []; // The remaining string is an empty string
                Current = new SplitEntry(span, []);
                return true;
            }

            Current = new SplitEntry(span[..index], span.Slice(index, 1));
            _str = span[(index + 1)..];
            return true;
        }

        public SplitEntry Current { get; private set; } = default;
    }

    public readonly ref struct SplitEntry(ReadOnlySpan<char> word, ReadOnlySpan<char> separator)
    {
        public ReadOnlySpan<char> Word { get; } = word;
        public ReadOnlySpan<char> Separator { get; } = separator;

        // This method allow to deconstruct the type, so you can write any of the following code
        // foreach (var entry in str.SplitNoAlloc()) { _ = entry.Line; }
        // foreach (var (line, endOfLine) in str.SplitNoAlloc()) { _ = line; }
        // https://docs.microsoft.com/en-us/dotnet/csharp/deconstruct?WT.mc_id=DT-MVP-5003978#deconstructing-user-defined-types
        public void Deconstruct(out ReadOnlySpan<char> word, out ReadOnlySpan<char> separator)
        {
            word = Word;
            separator = Separator;
        }

        // This method allow to implicitly cast the type into a ReadOnlySpan<char>, so you can write the following code
        // foreach (ReadOnlySpan<char> entry in str.SplitNoAlloc())
        public static implicit operator ReadOnlySpan<char>(SplitEntry entry) => entry.Word;
    }
}
