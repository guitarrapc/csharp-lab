using Logic.Core;

namespace Logic.Tests;

public class SemanticVersionTest
{
    [Fact]
    public void SemanticVersionToStringTest()
    {
        {
            var versionString = "1.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = "1.0.0";
            actual.ToString().Should().Be(expected);
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = versionString;
            actual.ToString().Should().Be(expected);
        }
        {
            var versionString = "1.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = "1.0.0-prerelease.10";
            actual.ToString().Should().Be(expected);
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = versionString;
            actual.ToString().Should().Be(expected);
        }
        {
            var versionString = "1.0.0-foobar";
            var actual = SemanticVersion.Parse(versionString);
            var expected = versionString;
            actual.ToString().Should().Be(expected);
        }
        {
            var versionString = "1.0.0-prerelease.10+foobar";
            var actual = SemanticVersion.Parse(versionString);
            var expected = versionString;
            actual.ToString().Should().Be(expected);
        }
    }

    [Fact]
    public void SemanticVersionGetHashCodeTest()
    {
        // success
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 0, 0);
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeTrue();
        }
        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 1, 0);
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeTrue();
        }

        // failed
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 1, 0);
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeFalse();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 1, 0);
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = 1;
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = "1.0.0";
            actual.GetHashCode().Equals(expected.GetHashCode()).Should().BeFalse();
        }
    }
    [Fact]
    public void SemanticVersionParseTest()
    {
        // success
        {
            var versionString = "1.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(versionString);
            actual.Should().Be(expected);
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(versionString);
            actual.Should().Be(expected);
        }
        {
            var versionString = "1.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0);
            actual.Should().Be(expected);
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0);
            actual.Should().Be(expected);
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.Should().Be(expected);
        }
        {
            var versionString = "1.0.0-foobar";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "foobar");
            actual.Should().Be(expected);
        }
        {
            var versionString = "1.0.0-prerelease.10+foobar";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10+foobar");
            actual.Should().Be(expected);
        }

        // failed
        {
            var versionString = "1";
            Assert.Throws<ArgumentException>(() => SemanticVersion.Parse(versionString)); // to short
        }
        {
            var versionString = "1.0.0.0";
            Assert.Throws<ArgumentException>(() => SemanticVersion.Parse(versionString)); // to long
        }
        {
            var versionString = "1.0.0+foo";
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(versionString)); // 0+foo is string
        }
        {
            var versionString = "1,0";
            Assert.Throws<ArgumentException>(() => SemanticVersion.Parse(versionString)); // too short
        }
        {
            var versionString = "1.0,0";
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(versionString)); // 0,0 is string
        }
        {
            var versionString = "1.1.1,0";
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(versionString)); // 1,0 is string
        }
        {
            var versionString = "1.1.1.1,0";
            Assert.Throws<ArgumentException>(() => SemanticVersion.Parse(versionString)); // too long
        }
        {
            var versionString = "foo";
            Assert.Throws<ArgumentException>(() => SemanticVersion.Parse(versionString)); // too short
        }
        {
            var versionString = "1.foo";
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(versionString)); // foo is string
        }
        {
            var versionString = "1.0.foo";
            Assert.Throws<FormatException>(() => SemanticVersion.Parse(versionString)); // foo is string
        }
        {
            var versionString = "1.0.0.foo";
            Assert.Throws<ArgumentException>(() => SemanticVersion.Parse(versionString)); // too long
        }
    }

    [Fact]
    public void SemanticVersionTryParseTest()
    {
        // success
        {
            var versionString = "1.0";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            var expected = new SemanticVersion(1, 0, 0);
            actual.Should().Be(expected);
            result.Should().BeTrue();
        }
        {
            var versionString = "1.0.0";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            var expected = new SemanticVersion(1, 0, 0);
            actual.Should().Be(expected);
            result.Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.Should().Be(expected);
            result.Should().BeTrue();
        }
        {
            var versionString = "1.0.0-foobar";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            var expected = new SemanticVersion(1, 0, 0, "foobar");
            actual.Should().Be(expected);
            result.Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10+foobar";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10+foobar");
            actual.Should().Be(expected);
            result.Should().BeTrue();
        }

        // failed
        {
            var versionString = "1";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            actual.Should().BeNull();
            result.Should().BeFalse();
        }
        {
            var versionString = "1.0.0.0";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            actual.Should().BeNull();
            result.Should().BeFalse();
        }
        {
            var versionString = "1.0.0+foo";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            actual.Should().BeNull();
            result.Should().BeFalse();
        }
        {
            var versionString = "1,0";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            actual.Should().BeNull();
            result.Should().BeFalse();
        }
        {
            var versionString = "foo";
            var result = SemanticVersion.TryParse(versionString, out var actual);
            actual.Should().BeNull();
            result.Should().BeFalse();
        }
    }

    [Fact]
    public void SemanticVersionEqualsGenericsTest()
    {
        // success
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0);
            actual.Equals(expected).Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.Equals(expected).Should().BeTrue();
        }
        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            actual.Equals(expected).Should().BeTrue();
        }

        // failed
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.Equals(expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            actual.Equals(expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            actual.Equals(expected).Should().BeFalse();
        }
    }

    [Fact]
    public void SemanticVersionEqualsTest()
    {
        // success
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 0, 0);
            actual.Equals(expected).Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.Equals(expected).Should().BeTrue();
        }
        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 1, 0);
            actual.Equals(expected).Should().BeTrue();
        }

        // failed
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.Equals(expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 1, 0);
            actual.Equals(expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            object expected = new SemanticVersion(1, 1, 0);
            actual.Equals(expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = 1;
            actual.Equals(expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            object expected = "1.0.0";
            actual.Equals(expected).Should().BeFalse();
        }
    }

    [Fact]
    public void SemanticVersionCompareToTest()
    {
        // 1.0.0-prerelease.10 < 1.0.0 < 1.1.0
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.CompareTo(compare).Should().Be(1);
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0);
            actual.CompareTo(compare).Should().Be(0);
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            actual.CompareTo(compare).Should().Be(-1);
        }

        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            actual.CompareTo(compare).Should().Be(0);
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            actual.CompareTo(compare).Should().Be(-1);
        }

        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            actual.CompareTo(compare).Should().Be(0);
        }
    }

    [Fact]
    public void SemanticVersionOperatorGreaterThanTest()
    {
        // 1.0.0-prerelease.10 < 1.0.0 < 1.1.0
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual > compare).Should().BeTrue();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0);
            (actual > compare).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual > compare).Should().BeFalse();
        }

        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual > compare).Should().BeFalse();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual > compare).Should().BeFalse();
        }

        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual > compare).Should().BeFalse();
        }
    }

    [Fact]
    public void SemanticVersionOperatorGreaterThanEqualsTest()
    {
        // 1.0.0-prerelease.10 < 1.0.0 < 1.1.0
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual >= compare).Should().BeTrue();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0);
            (actual >= compare).Should().BeTrue();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual >= compare).Should().BeFalse();
        }

        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual >= compare).Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual >= compare).Should().BeFalse();
        }

        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual >= compare).Should().BeTrue();
        }
    }

    [Fact]
    public void SemanticVersionOperatorLessThanTest()
    {
        // 1.0.0-prerelease.10 < 1.0.0 < 1.1.0
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual < compare).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0);
            (actual < compare).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual < compare).Should().BeTrue();
        }

        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual < compare).Should().BeFalse();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual < compare).Should().BeTrue();
        }

        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual < compare).Should().BeFalse();
        }
    }

    [Fact]
    public void SemanticVersionOperatorLessThanEqualsTest()
    {
        // 1.0.0-prerelease.10 < 1.0.0 < 1.1.0
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual <= compare).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0);
            (actual <= compare).Should().BeTrue();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual <= compare).Should().BeTrue();
        }

        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual <= compare).Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual <= compare).Should().BeTrue();
        }

        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var compare = new SemanticVersion(1, 1, 0);
            (actual <= compare).Should().BeTrue();
        }
    }

    // operators
    [Fact]
    public void SemanticVersionOperatorEqualsTest()
    {
        // success
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0);
            (actual == expected).Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual == expected).Should().BeTrue();
        }
        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            (actual == expected).Should().BeTrue();
        }

        // failed
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual == expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            (actual == expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            (actual == expected).Should().BeFalse();
        }
    }

    [Fact]
    public void SemanticVersionOperatorNotEqualsTest()
    {
        // success
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0);
            (actual != expected).Should().BeFalse();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual != expected).Should().BeFalse();
        }
        {
            var versionString = "1.1.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            (actual != expected).Should().BeFalse();
        }

        // failed
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 0, 0, "prerelease.10");
            (actual != expected).Should().BeTrue();
        }
        {
            var versionString = "1.0.0";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            (actual != expected).Should().BeTrue();
        }
        {
            var versionString = "1.0.0-prerelease.10";
            var actual = SemanticVersion.Parse(versionString);
            var expected = new SemanticVersion(1, 1, 0);
            (actual != expected).Should().BeTrue();
        }
    }
}
