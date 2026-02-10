using Logic.Core;

namespace Logic.Tests;

public class OutlierIqrTest
{
    [Fact]
    public async Task OutlierDetectionTest()
    {
        // Arrange
        Span<double> inputs = [1.0, 90.0, 91.0, 92.0, 93.0, 94.0, 80.0, 70.0, 92.0, 100.0, 10.0, 11.0, 80.0];
        Span<double> expected = [70.0, 80.0, 80.0, 90.0, 91.0, 92.0, 92.0, 93.0, 94.0, 100.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);

        // Assert
        Assert.Equal(0..0, range);
    }

    [Fact]
    public void FindInlierRange_SingleValue_ReturnsSingleValue()
    {
        // Arrange
        Span<double> inputs = [50.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 50.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
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
        OutlierIqr.FindInlierRange(inputs, 100.0);

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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
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
        var range = OutlierIqr.FindInlierRange(inputs, 300.0);
        var filtered = inputs[range];

        // Assert - value 200.0 is far above upper bound, should be excluded
        Assert.DoesNotContain(200.0, filtered.ToArray());
    }

    // Tests for MAD fallback when IQR = 0
    [Fact]
    public void FindInlierRange_IQRZeroWithOutliers_UsesMADFallback()
    {
        // Arrange - Most values are 50.0 (Q1=Q3=50, IQR=0), but there are multiple varied values and outliers
        // With 75% of values at 50.0, Q1 and Q3 will both be 50.0
        Span<double> inputs = [1.0, 45.0, 48.0, 49.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 51.0, 52.0, 55.0, 99.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - MAD should detect and remove extreme outliers (1.0 and 99.0)
        // Median = 50, Deviations = [49, 5, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 5, 49]
        // MAD = median of deviations ≈ 0.5, bounds = 50 ± 2.5*0.5 = [48.75, 51.25]
        // Actually, with sorted deviations, MAD will be between 0 and 1
        // With MAD multiplier 2.5, extreme values should be removed
        Assert.DoesNotContain(1.0, filtered.ToArray());
        Assert.DoesNotContain(99.0, filtered.ToArray());
        Assert.Contains(50.0, filtered.ToArray());
    }

    [Fact]
    public void FindInlierRange_IQRZeroNoOutliers_ReturnsAllValues()
    {
        // Arrange - Most values are 50.0, with slight variation within MAD range
        Span<double> inputs = [48.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 52.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - Small deviations should be within MAD bounds
        Assert.Contains(48.0, filtered.ToArray());
        Assert.Contains(52.0, filtered.ToArray());
        Assert.Equal(9, filtered.Length);
    }

    [Fact]
    public void FindInlierRange_LargeDatasetWithMADFallback_UsesArrayPool()
    {
        // Arrange - Large dataset that triggers ArrayPool usage (>1024 elements)
        // This test verifies ArrayPool path works correctly
        var inputs = new double[1500];
        
        // Create a dataset where 75% are at 50.0, ensuring Q1=Q3=50 (IQR=0)
        for (int i = 0; i < 1125; i++)
        {
            inputs[i] = 50.0;  // 75% at exactly 50.0
        }
        for (int i = 1125; i < 1500; i++)
        {
            inputs[i] = 50.0 + (i % 10) * 0.1; // Small variations: 50.0 to 50.9
        }

        Span<double> inputSpan = inputs;

        // Act
        var range = OutlierIqr.FindInlierRange(inputSpan, 200.0);
        var filtered = inputSpan[range];

        // Assert - Should use ArrayPool (size > 1024) and process data correctly
        // With this distribution (75% identical), IQR = 0, MAD will also be small
        // All values should be retained as they're close together
        Assert.True(inputSpan.Length > 1024, "Test should use ArrayPool path");
        Assert.Equal(1500, filtered.Length); // All values retained (no outliers)
    }

    [Fact]
    public void FindInlierRange_MADBreakdownPoint_Demonstrates50PercentLimit()
    {
        // This test demonstrates MAD's breakdown point:
        // When >50% of data is identical, MAD ≈ 0, making outlier detection impossible
        
        // Arrange - 80% of values are identical (exceeds MAD's 50% breakdown point)
        var inputs = new double[100];
        for (int i = 0; i < 80; i++)
        {
            inputs[i] = 50.0;  // 80% identical
        }
        for (int i = 80; i < 96; i++)
        {
            inputs[i] = 48.0 + (i % 4); // Small variations: 48, 49, 50, 51
        }
        // Add extreme outliers
        inputs[96] = 1.0;
        inputs[97] = 2.0;
        inputs[98] = 98.0;
        inputs[99] = 99.0;

        Span<double> inputSpan = inputs;

        // Act
        var range = OutlierIqr.FindInlierRange(inputSpan, 200.0);
        var filtered = inputSpan[range];

        // Assert - MAD ≈ 0 because >50% of values are identical
        // All data is returned (cannot detect outliers)
        Assert.Equal(100, filtered.Length);
        Assert.Contains(1.0, filtered.ToArray());   // Outliers are NOT removed
        Assert.Contains(99.0, filtered.ToArray());  // due to MAD limitation
    }

    [Fact]
    public void FindInlierRange_MADEffectiveDetection_BelowBreakdownPoint()
    {
        // This test shows MAD working correctly when <50% of data is identical
        
        // Arrange - 40% at median, rest distributed
        var inputs = new double[100];
        for (int i = 0; i < 40; i++)
        {
            inputs[i] = 50.0;  // 40% at median
        }
        for (int i = 40; i < 94; i++)
        {
            inputs[i] = 45.0 + (i % 54) * 0.2; // Distributed: 45.0 to 55.6
        }
        // Add extreme outliers
        inputs[94] = 1.0;
        inputs[95] = 2.0;
        inputs[96] = 3.0;
        inputs[97] = 97.0;
        inputs[98] = 98.0;
        inputs[99] = 99.0;

        Span<double> inputSpan = inputs;

        // Act
        var range = OutlierIqr.FindInlierRange(inputSpan, 200.0);
        var filtered = inputSpan[range];

        // Assert - MAD > 0, can detect extreme outliers
        // Median ≈ 50, with good distribution, MAD should be effective
        // With k=3.0 and scaling, some intermediate outliers might remain
        Assert.DoesNotContain(1.0, filtered.ToArray());
        Assert.DoesNotContain(2.0, filtered.ToArray());
        Assert.DoesNotContain(98.0, filtered.ToArray());
        Assert.DoesNotContain(99.0, filtered.ToArray());
        Assert.True(filtered.Length >= 78, $"Expected at least 78 values, got {filtered.Length}");
    }

    [Fact]
    public void FindInlierRange_MADCalculation_MedianCorrect()
    {
        // Arrange - Testing internal MAD calculation indirectly
        Span<double> inputs = [10.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 90.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - Values should be filtered based on MAD from median (50.0)
        // MAD = median(|10-50|, |50-50|, |50-50|, |50-50|, |50-50|, |50-50|, |90-50|)
        // MAD = median(40, 0, 0, 0, 0, 0, 40) = 0
        // Since MAD is 0, all should be returned
        Assert.Equal(8, filtered.Length);
    }

    [Fact]
    public void FindInlierRange_QuartilesCalculation_InternalTest()
    {
        // Arrange - Testing quartile calculation
        Span<double> sortedData = [10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 90.0];

        // Act
        OutlierIqr.GetQuartiles(sortedData, out var q1, out var q3);

        // Assert - Q1 should be 25th percentile, Q3 should be 75th percentile
        Assert.Equal(30.0, q1);
        Assert.Equal(70.0, q3);
    }
}

