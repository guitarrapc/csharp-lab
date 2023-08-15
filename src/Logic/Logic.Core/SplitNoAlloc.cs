namespace Logic;

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
    public ref struct SplitEnumerator
    {
        private readonly char _separator;
        private ReadOnlySpan<char> _str;

        public SplitEnumerator(ReadOnlySpan<char> str, char separator)
        {
            _separator = separator;
            _str = str;
            Current = default;
        }

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
                _str = ReadOnlySpan<char>.Empty; // The remaining string is an empty string
                Current = new SplitEntry(span, ReadOnlySpan<char>.Empty);
                return true;
            }

            Current = new SplitEntry(span.Slice(0, index), span.Slice(index, 1));
            _str = span.Slice(index + 1);
            return true;
        }

        public SplitEntry Current { get; private set; }
    }

    public readonly ref struct SplitEntry
    {
        public SplitEntry(ReadOnlySpan<char> word, ReadOnlySpan<char> separator)
        {
            Word = word;
            Separator = separator;
        }

        public ReadOnlySpan<char> Word { get; }
        public ReadOnlySpan<char> Separator { get; }

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
