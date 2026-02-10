using Logic.Core;

namespace Logic.Tests;

public class OutlierIQRTest
{
    [Fact]
    public async Task OutlierDetectionTest()
    {
        // Arrange
        Span<double> inputs = [1.0, 90.0, 91.0, 92.0, 93.0, 94.0, 80.0, 70.0, 92.0, 100.0, 10.0, 11.0, 80.0];
        Span<double> expected = [70.0, 80.0, 80.0, 90.0, 91.0, 92.0, 92.0, 93.0, 94.0, 100.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        Assert.Equal(expected, filtered);
    }

    [Fact]
    public void FindInlierRange_EmptyData_ReturnsEmptyRange()
    {
        // Arrange
        Span<double> inputs = [];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);

        // Assert
        Assert.Equal(0..0, range);
    }

    [Fact]
    public void FindInlierRange_SingleValue_ReturnsSingleValue()
    {
        // Arrange
        Span<double> inputs = [50.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        Assert.Single(filtered.ToArray());
        Assert.Equal(50.0, filtered[0]);
    }

    [Fact]
    public void FindInlierRange_NoOutliers_ReturnsAllData()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0, 30.0, 40.0, 50.0];
        var originalLength = inputs.Length;

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        Assert.Equal(originalLength, filtered.Length);
    }

    [Fact]
    public void FindInlierRange_WithUpperLimit_RespectsLimit()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0, 30.0, 40.0, 50.0, 200.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 50.0);
        var filtered = inputs[range];

        // Assert
        Assert.All(filtered.ToArray(), value => Assert.True(value <= 50.0));
    }

    [Fact]
    public void FindInlierRange_ExtremeOutliers_RemovedCorrectly()
    {
        // Arrange
        Span<double> inputs = [-1000.0, 50.0, 55.0, 60.0, 65.0, 70.0, 75.0, 80.0, 1000.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - extreme outliers should be removed
        Assert.DoesNotContain(-1000.0, filtered.ToArray());
        Assert.DoesNotContain(1000.0, filtered.ToArray());
        Assert.Contains(50.0, filtered.ToArray());
        Assert.Contains(80.0, filtered.ToArray());
    }

    [Fact]
    public void FindInlierRange_SortsDataInPlace()
    {
        // Arrange
        Span<double> inputs = [50.0, 10.0, 30.0, 20.0, 40.0];

        // Act
        OutlierIQR.FindInlierRange(inputs, 100.0);

        // Assert - data should be sorted after processing
        for (int i = 0; i < inputs.Length - 1; i++)
        {
            Assert.True(inputs[i] <= inputs[i + 1]);
        }
    }

    [Fact]
    public void FindInlierRange_WithExtremeValues_HandledCorrectly()
    {
        // Arrange
        Span<double> inputs = [-100.0, 10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 200.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - extreme values outside IQR bounds should be removed
        Assert.DoesNotContain(-100.0, filtered.ToArray());
        Assert.DoesNotContain(200.0, filtered.ToArray());
    }

    // Tests for small datasets: n=2,3,4
    [Fact]
    public void FindInlierRange_TwoValues_ReturnsAllValues()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 10, lower = 10 - 15 = -5, upper = 20 + 15 = 35
        Assert.Equal(2, filtered.Length);
        Assert.Equal(10.0, filtered[0]);
        Assert.Equal(20.0, filtered[1]);
    }

    [Fact]
    public void FindInlierRange_ThreeValues_ReturnsAllValues()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0, 30.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - small dataset should typically retain all values
        Assert.Equal(3, filtered.Length);
        Assert.Equal(10.0, filtered[0]);
        Assert.Equal(20.0, filtered[1]);
        Assert.Equal(30.0, filtered[2]);
    }

    [Fact]
    public void FindInlierRange_FourValues_WithOutlier_RemovesOutlier()
    {
        // Arrange
        Span<double> inputs = [1.0, 10.0, 11.0, 100.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - Q1 = 7.25, Q3 = 28.75, IQR = 21.5, lower = -25.0, upper = 61.0
        Assert.DoesNotContain(100.0, filtered.ToArray());
        Assert.Contains(1.0, filtered.ToArray());
        Assert.Contains(10.0, filtered.ToArray());
        Assert.Contains(11.0, filtered.ToArray());
    }

    [Fact]
    public void FindInlierRange_FourIdenticalValues_ReturnsAllValues()
    {
        // Arrange
        Span<double> inputs = [42.0, 42.0, 42.0, 42.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 0, should return all values
        Assert.Equal(4, filtered.Length);
        Assert.All(filtered.ToArray(), value => Assert.Equal(42.0, value));
    }

    // Tests for identical values (IQR=0)
    [Fact]
    public void FindInlierRange_AllIdenticalValues_ReturnsAllValues()
    {
        // Arrange
        Span<double> inputs = [50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 0, should return all values
        Assert.Equal(7, filtered.Length);
        Assert.All(filtered.ToArray(), value => Assert.Equal(50.0, value));
    }

    [Fact]
    public void FindInlierRange_AllZeros_ReturnsAllValues()
    {
        // Arrange
        Span<double> inputs = [0.0, 0.0, 0.0, 0.0, 0.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 0, should return all values
        Assert.Equal(5, filtered.Length);
        Assert.All(filtered.ToArray(), value => Assert.Equal(0.0, value));
    }

    // Tests for boundary values
    [Fact]
    public void FindInlierRange_ValueAtLowerBound_IsIncluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        Span<double> inputs = [0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - value 0.0 is above lower bound (-30), should be included
        Assert.Contains(0.0, filtered.ToArray());
    }

    [Fact]
    public void FindInlierRange_ValueAtUpperBound_IsIncluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        Span<double> inputs = [0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - value 100.0 is below upper bound (130), should be included
        Assert.Contains(100.0, filtered.ToArray());
    }

    [Fact]
    public void FindInlierRange_ValueBelowLowerBound_IsExcluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        Span<double> inputs = [-50.0, 0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - value -50.0 is far below lower bound, should be excluded
        Assert.DoesNotContain(-50.0, filtered.ToArray());
    }

    [Fact]
    public void FindInlierRange_ValueAboveUpperBound_IsExcluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        Span<double> inputs = [0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0, 200.0];

        // Act
        var range = OutlierIQR.FindInlierRange(inputs, 300.0);
        var filtered = inputs[range];

        // Assert - value 200.0 is far above upper bound, should be excluded
        Assert.DoesNotContain(200.0, filtered.ToArray());
    }
}
