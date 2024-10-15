using System.Diagnostics.CodeAnalysis;

namespace Logic.Core;

// spec: https://semver.org/
public class SemanticVersion : IEquatable<SemanticVersion>, IComparable<SemanticVersion>
{
    public int Major { get; }
    public int Minor { get; }
    public int Patch { get; }
    public string PrereleaseLabel { get; }

    public SemanticVersion(string versionString)
    {
        var version = Parse(versionString);
        Major = version.Major;
        Minor = version.Minor;
        Patch = version.Patch;
        PrereleaseLabel = version.PrereleaseLabel;
    }
    public SemanticVersion(int major, int minor, int patch)
    {
        Major = major;
        Minor = minor;
        Patch = patch;
        PrereleaseLabel = "";
    }
    public SemanticVersion(int major, int minor, int patch, string prereleaseLabel)
    {
        Major = major;
        Minor = minor;
        Patch = patch;
        PrereleaseLabel = prereleaseLabel;
    }

    public override string ToString() => string.IsNullOrEmpty(PrereleaseLabel) ? $"{Major}.{Minor}.{Patch}" : $"{Major}.{Minor}.{Patch}-{PrereleaseLabel}";

    public override int GetHashCode() => HashCode.Combine(Major, Minor, Patch, PrereleaseLabel);

    public override bool Equals(object? obj)
    {
        return obj switch
        {
            SemanticVersion other => Equals(other),
            Version version => string.IsNullOrEmpty(PrereleaseLabel) && Major == version.Major && Minor == version.Minor && Patch == version.Build,
            _ => false,
        };
    }
    public bool Equals([AllowNull] SemanticVersion other)
    {
        if (other is null)
            return false;
        if (ReferenceEquals(this, other))
            return true;

        return Major == other.Major
            && Minor == other.Minor
            && Patch == other.Patch
            && PrereleaseLabel == other.PrereleaseLabel;
    }

    public int CompareTo(SemanticVersion? other)
    {
        if (other is null) return 1;
        int result = Major.CompareTo(other.Major);
        if (result != 0) return result;
        result = Minor.CompareTo(other.Minor);
        if (result != 0) return result;
        result = Patch.CompareTo(other.Patch);
        if (result != 0) return result;
        // Empty Prerelease label is greater than exists.
        if (string.IsNullOrEmpty(PrereleaseLabel) && !string.IsNullOrEmpty(other.PrereleaseLabel)) return 1;
        if (!string.IsNullOrEmpty(PrereleaseLabel) && string.IsNullOrEmpty(other.PrereleaseLabel)) return -1;
        return ComparePrerelease(PrereleaseLabel, other.PrereleaseLabel);

        static int ComparePrerelease(string left, string right)
        {
            // Precedence for two pre-release versions with the same major, minor, and patch version MUST be determined by comparing each dot separated identifier from left to right until a difference is found as follows:
            var leftSpan = left.AsSpan();
            var rightSpan = right.AsSpan();
            var leftDots = CountDots(leftSpan);
            var rightDots = CountDots(rightSpan);

            if (leftDots == 0 && rightDots == 0)
            {
                // no dots separated
                if (int.TryParse(leftSpan, out var leftInt))
                {
                    if (int.TryParse(rightSpan, out var rightInt))
                    {
                        // both is number, then larger is greater
                        // Identifiers consisting of only digits are compared numerically.
                        return leftInt.CompareTo(rightInt);
                    }
                    else
                    {
                        // right is string, then string is greater
                        // Numeric identifiers always have lower precedence than non-numeric identifiers.
                        return -1;
                    }
                }
                else
                {
                    // both is string, then compare string
                    // Identifiers with letters or hyphens are compared lexically in ASCII sort order.
                    return leftSpan.CompareTo(rightSpan, StringComparison.Ordinal);
                }
            }
            else if (leftDots != 0 && rightDots == 0)
            {
                // left has dot
                Span<Range> leftDotRanges = stackalloc Range[leftDots];
                leftSpan.Split(leftDotRanges, '.');
                for (var i = 0; i < leftDots; i++)
                {
                    var range = leftDotRanges[i];

                    // left and right section is same.
                    if (leftSpan[range].SequenceEqual(rightSpan))
                    {
                        // left has dot, means left is larger then right.
                        // A larger set of pre-release fields has a higher precedence than a smaller set, if all of the preceding identifiers are equal.
                        continue;
                    }

                    if (int.TryParse(leftSpan[range], out var leftInt))
                    {
                        if (int.TryParse(rightSpan, out var rightInt))
                        {
                            // both is number, then larger is greater
                            // Identifiers consisting of only digits are compared numerically.
                            return leftInt.CompareTo(rightInt);
                        }
                        else
                        {
                            // right is string, then string is greater
                            // Numeric identifiers always have lower precedence than non-numeric identifiers.
                            return -1;
                        }
                    }
                    else
                    {
                        // both is string, then compare string
                        // Identifiers with letters or hyphens are compared lexically in ASCII sort order.
                        return leftSpan[range].CompareTo(rightSpan, StringComparison.Ordinal);
                    }
                }
            }
            else if (leftDots == 0 && rightDots != 0)
            {
                // right has dot
                Span<Range> rightDotRanges = stackalloc Range[rightDots];
                rightSpan.Split(rightDotRanges, '.');
                for (var i = 0; i < rightDots; i++)
                {
                    var range = rightDotRanges[i];

                    // left and right section is same.
                    if (leftSpan.SequenceEqual(rightSpan[range]))
                    {
                        // left has dot, means left is larger then right.
                        // A larger set of pre-release fields has a higher precedence than a smaller set, if all of the preceding identifiers are equal.
                        continue;
                    }

                    if (int.TryParse(leftSpan, out var leftInt))
                    {
                        if (int.TryParse(rightSpan[range], out var rightInt))
                        {
                            // both is number, then larger is greater
                            // Identifiers consisting of only digits are compared numerically.
                            return leftInt.CompareTo(rightInt);
                        }
                        else
                        {
                            // right is string, then string is greater
                            // Numeric identifiers always have lower precedence than non-numeric identifiers.
                            return -1;
                        }
                    }
                    else
                    {
                        // both is string, then compare string
                        // Identifiers with letters or hyphens are compared lexically in ASCII sort order.
                        return leftSpan.CompareTo(rightSpan[range], StringComparison.Ordinal);
                    }
                }
            }
            else
            {
                // left and right has dot
                Span<Range> leftDotRanges = stackalloc Range[leftDots];
                Span<Range> rightDotRanges = stackalloc Range[rightDots];
                leftSpan.Split(leftDotRanges, '.');
                rightSpan.Split(rightDotRanges, '.');
                for (var i = 0; i < leftDots; i++)
                {
                    // last check
                    if (i + 1 == leftDots && leftDots > rightDots)
                    {
                        // left is longer
                        return 1;
                    }
                    else if (i + 1 == leftDots && leftDots < rightDots)
                    {
                        // right is longer
                        return -1;
                    }

                    var leftRange = leftDotRanges[i];
                    var rightRange = rightDotRanges[i];

                    // left and right section is same.
                    if (leftSpan[leftRange].SequenceEqual(rightSpan[rightRange]))
                    {
                        // next dot compare
                        continue;
                    }

                    if (int.TryParse(leftSpan[leftRange], out var leftInt))
                    {
                        if (int.TryParse(rightSpan[rightRange], out var rightInt))
                        {
                            // both is number, then larger is greater
                            // Identifiers consisting of only digits are compared numerically.
                            return leftInt.CompareTo(rightInt);
                        }
                        else
                        {
                            // right is string, then string is greater
                            // Numeric identifiers always have lower precedence than non-numeric identifiers.
                            return -1;
                        }
                    }
                    else
                    {
                        // both is string, then compare string
                        // Identifiers with letters or hyphens are compared lexically in ASCII sort order.
                        return leftSpan[leftRange].CompareTo(rightSpan[rightRange], StringComparison.Ordinal);
                    }
                }
            }

            return 0;

            static int CountDots(ReadOnlySpan<char> span)
            {
                int count = 0;
                foreach (char c in span)
                {
                    if (c == '.')
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }

    public static bool operator ==(SemanticVersion? left, SemanticVersion? right)
    {
        if (left is null)
            return right is null;
        return left.Equals(right);
    }
    public static bool operator !=(SemanticVersion? left, SemanticVersion? right)
    {
        return !(left == right);
    }
    public static bool operator <(SemanticVersion left, SemanticVersion right)
    {
        return left.CompareTo(right) < 0;
    }
    public static bool operator <=(SemanticVersion left, SemanticVersion right)
    {
        return left.CompareTo(right) <= 0;
    }
    public static bool operator >(SemanticVersion left, SemanticVersion right)
    {
        return left.CompareTo(right) > 0;
    }
    public static bool operator >=(SemanticVersion left, SemanticVersion right)
    {
        return left.CompareTo(right) >= 0;
    }

    public static SemanticVersion Parse(string input)
    {
        // TODO: support metadata
        var span = input.AsSpan();
        var prereleaseIndex = span.IndexOf('-');
        if (prereleaseIndex == -1)
        {
            // prerelease not found
            var (major, minor, patch) = GetVersionsFromSpan(span);
            return new SemanticVersion(major, minor, patch);
        }
        else
        {
            // prerelease found
            var versionSection = span[..prereleaseIndex];
            var prereleaseSection = span[(prereleaseIndex + 1)..]; // remove first char `-`
            ValidatePrerelease(prereleaseSection);

            var (major, minor, patch) = GetVersionsFromSpan(versionSection);
            return new SemanticVersion(major, minor, patch, prereleaseSection.ToString());
        }

        static (int major, int minor, int patch) GetVersionsFromSpan(ReadOnlySpan<char> span)
        {
            Span<Range> buffer = stackalloc Range[span.Length];
            var splitCount = span.Split(buffer, '.');
            if (splitCount > 3)
                throw new ArgumentException("Version string portion was too long.", nameof(input));
            // should be `int.int.int`
            if (splitCount == 3)
            {
                var major = int.Parse(span[buffer[0]]);
                var minor = int.Parse(span[buffer[1]]);
                var patch = int.Parse(span[buffer[2]]);
                return (major, minor, patch);
            }
            // should be `int.int`
            if (splitCount == 2)
            {
                var major = int.Parse(span[buffer[0]]);
                var minor = int.Parse(span[buffer[1]]);
                return (major, minor, 0);
            }
            throw new ArgumentException("Version string portion was too short.", nameof(input));
        }

        static void ValidatePrerelease(ReadOnlySpan<char> prereleaseChars)
        {
            // Identifiers MUST NOT be empty
            if (prereleaseChars.Length == 0)
                throw new ArgumentException($"Empty prerelease not allowed.");

            // Identifiers MUST comprise only ASCII alphanumerics and hyphens [0-9A-Za-z-].
            foreach (var c in prereleaseChars)
            {
                if (!IsValidChar(c))
                    throw new ArgumentException($"Invalid char found in prerelease. Invalid: {prereleaseChars}");
            }

            static bool IsValidChar(char c)
            {
                int ascii = (int)c;
                return (ascii >= 48 && ascii <= 57) ||  // '0' - '9'
                       (ascii >= 65 && ascii <= 90) ||  // 'A' - 'Z'
                       (ascii >= 97 && ascii <= 122) || // 'a' - 'z'
                       (ascii == 45) ||                 // '-'
                                                        // TODO: should not allow `.`, this is for splitting prerelease.
                       (ascii == 46) ||                 // .
                                                        // TODO: should not allow `+`, this is for metadata.
                       (ascii == 43);                   // +
            }
        }
    }

    public static bool TryParse(string versionString, [NotNullWhen(true)] out SemanticVersion? version)
    {
        try
        {
            version = Parse(versionString);
            return true;
        }
        catch (Exception)
        {
            version = default;
            return false;
        }
    }
}
