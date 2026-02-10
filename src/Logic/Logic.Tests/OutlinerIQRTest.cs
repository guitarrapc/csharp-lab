using Logic.Core;

namespace Logic.Tests;

public class OutlinerIQRTest
{
    [Fact]
    public async Task OutlinerDetectionTest()
    {
        // Arrange
        Span<double> inputs = [1.0, 90.0, 91.0, 92.0, 93.0, 94.0, 80.0, 70.0, 92.0, 100.0, 10.0, 11.0, 80.0];
        Span<double> expected = [70.0, 80.0, 80.0, 90.0, 91.0, 92.0, 92.0, 93.0, 94.0, 100.0];

        // Act
        var range = OutlinerIQR.RemoveOutliner(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        Assert.Equal(expected, filtered);
    }

    [Fact]
    public void RemoveOutliner_EmptyData_ReturnsEmptyRange()
    {
        // Arrange
        Span<double> inputs = [];

        // Act
        var range = OutlinerIQR.RemoveOutliner(inputs, 100.0);

        // Assert
        Assert.Equal(0..0, range);
    }

    [Fact]
    public void RemoveOutliner_SingleValue_ReturnsSingleValue()
    {
        // Arrange
        Span<double> inputs = [50.0];

        // Act
        var range = OutlinerIQR.RemoveOutliner(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        Assert.Single(filtered.ToArray());
        Assert.Equal(50.0, filtered[0]);
    }

    [Fact]
    public void RemoveOutliner_NoOutliers_ReturnsAllData()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0, 30.0, 40.0, 50.0];
        var originalLength = inputs.Length;

        // Act
        var range = OutlinerIQR.RemoveOutliner(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        Assert.Equal(originalLength, filtered.Length);
    }

    [Fact]
    public void RemoveOutliner_WithUpperLimit_RespectsLimit()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0, 30.0, 40.0, 50.0, 200.0];

        // Act
        var range = OutlinerIQR.RemoveOutliner(inputs, 50.0);
        var filtered = inputs[range];

        // Assert
        Assert.All(filtered.ToArray(), value => Assert.True(value <= 50.0));
    }

    [Fact]
    public void RemoveOutliner_ExtremeOutliers_RemovedCorrectly()
    {
        // Arrange
        Span<double> inputs = [-1000.0, 50.0, 55.0, 60.0, 65.0, 70.0, 75.0, 80.0, 1000.0];

        // Act
        var range = OutlinerIQR.RemoveOutliner(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - extreme outliers should be removed
        Assert.DoesNotContain(-1000.0, filtered.ToArray());
        Assert.DoesNotContain(1000.0, filtered.ToArray());
        Assert.Contains(50.0, filtered.ToArray());
        Assert.Contains(80.0, filtered.ToArray());
    }

    [Fact]
    public void GetLowerBound_CalculatesCorrectly()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 90.0, 100.0];
        inputs.Sort();

        // Act
        var lowerBound = OutlinerIQR.GetLowerBound(inputs);

        // Assert
        // Q1 = 32.5, Q3 = 77.5, IQR = 45, LowerBound = 32.5 - 1.5 * 45 = -35
        Assert.Equal(-35.0, lowerBound);
    }

    [Fact]
    public void GetUpperBound_CalculatesCorrectly()
    {
        // Arrange
        Span<double> inputs = [10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 90.0, 100.0];
        inputs.Sort();

        // Act
        var upperBound = OutlinerIQR.GetUpperBound(inputs);

        // Assert
        // Q1 = 32.5, Q3 = 77.5, IQR = 45, UpperBound = 77.5 + 1.5 * 45 = 145
        Assert.Equal(145.0, upperBound);
    }

    [Fact]
    public void RemoveOutliner_SortsDataInPlace()
    {
        // Arrange
        Span<double> inputs = [50.0, 10.0, 30.0, 20.0, 40.0];

        // Act
        OutlinerIQR.RemoveOutliner(inputs, 100.0);

        // Assert - data should be sorted after processing
        for (int i = 0; i < inputs.Length - 1; i++)
        {
            Assert.True(inputs[i] <= inputs[i + 1]);
        }
    }

    [Fact]
    public void RemoveOutliner_WithExtremeValues_HandledCorrectly()
    {
        // Arrange
        Span<double> inputs = [-100.0, 10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 200.0];

        // Act
        var range = OutlinerIQR.RemoveOutliner(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - extreme values outside IQR bounds should be removed
        Assert.DoesNotContain(-100.0, filtered.ToArray());
        Assert.DoesNotContain(200.0, filtered.ToArray());
    }
}
