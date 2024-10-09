using System.Diagnostics.CodeAnalysis;

namespace Logic.Core;

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
        return string.Compare(PrereleaseLabel, other.PrereleaseLabel, StringComparison.Ordinal);
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
        var span = input.AsSpan();
        var prereleaseIndex = span.IndexOf('-');
        if (prereleaseIndex == -1)
        {
            var (major, minor, patch) = GetVersionsFromSpan(span);
            return new SemanticVersion(major, minor, patch);
        }
        else
        {
            var versionSection = span[..prereleaseIndex];
            var prereleaseSection = span[(prereleaseIndex+1)..]; // remove first char `-`
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
