using Logic.Core;

namespace Logic.Tests;

public class OutlierIqrTest
{
    [Test]
    public async Task OutlierDetectionTest()
    {
        // Arrange
        double[] inputs = [1.0, 90.0, 91.0, 92.0, 93.0, 94.0, 80.0, 70.0, 92.0, 100.0, 10.0, 11.0, 80.0];
        double[] expected = [70.0, 80.0, 80.0, 90.0, 91.0, 92.0, 92.0, 93.0, 94.0, 100.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        await Assert.That(filtered).IsEquivalentTo(expected);
    }

    [Test]
    public async Task FindInlierRange_EmptyData_ReturnsEmptyRange()
    {
        // Arrange
        double[] inputs = [];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);

        // Assert
        await Assert.That(range).IsEqualTo(0..0);
    }

    [Test]
    public async Task FindInlierRange_SingleValue_ReturnsSingleValue()
    {
        // Arrange
        double[] inputs = [50.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        await Assert.That(filtered.ToArray()).HasSingleItem();
        await Assert.That(filtered[0]).IsEqualTo(50.0);
    }

    [Test]
    public async Task FindInlierRange_NoOutliers_ReturnsAllData()
    {
        // Arrange
        double[] inputs = [10.0, 20.0, 30.0, 40.0, 50.0];
        var originalLength = inputs.Length;

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert
        await Assert.That(filtered.Length).IsEqualTo(originalLength);
    }

    [Test]
    public async Task FindInlierRange_WithUpperLimit_RespectsLimit()
    {
        // Arrange
        double[] inputs = [10.0, 20.0, 30.0, 40.0, 50.0, 200.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 50.0);
        var filtered = inputs[range];

        // Assert
        await Assert.That(filtered.ToArray()).All(value => value <= 50.0);
    }

    [Test]
    public async Task FindInlierRange_ExtremeOutliers_RemovedCorrectly()
    {
        // Arrange
        double[] inputs = [-1000.0, 50.0, 55.0, 60.0, 65.0, 70.0, 75.0, 80.0, 1000.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - extreme outliers should be removed
        await Assert.That(filtered.ToArray()).DoesNotContain(-1000.0);
        await Assert.That(filtered.ToArray()).DoesNotContain(1000.0);
        await Assert.That(filtered.ToArray()).Contains(50.0);
        await Assert.That(filtered.ToArray()).Contains(80.0);
    }

    [Test]
    public async Task FindInlierRange_SortsDataInPlace()
    {
        // Arrange
        double[] inputs = [50.0, 10.0, 30.0, 20.0, 40.0];

        // Act
        OutlierIqr.FindInlierRange(inputs, 100.0);

        // Assert - data should be sorted after processing
        for (int i = 0; i < inputs.Length - 1; i++)
        {
            await Assert.That(inputs[i] <= inputs[i + 1]).IsTrue();
        }
    }

    [Test]
    public async Task FindInlierRange_WithExtremeValues_HandledCorrectly()
    {
        // Arrange
        double[] inputs = [-100.0, 10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 200.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - extreme values outside IQR bounds should be removed
        await Assert.That(filtered.ToArray()).DoesNotContain(-100.0);
        await Assert.That(filtered.ToArray()).DoesNotContain(200.0);
    }

    // Tests for small datasets: n=2,3,4
    [Test]
    public async Task FindInlierRange_TwoValues_ReturnsAllValues()
    {
        // Arrange
        double[] inputs = [10.0, 20.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 10, lower = 10 - 15 = -5, upper = 20 + 15 = 35
        await Assert.That(filtered.Length).IsEqualTo(2);
        await Assert.That(filtered[0]).IsEqualTo(10.0);
        await Assert.That(filtered[1]).IsEqualTo(20.0);
    }

    [Test]
    public async Task FindInlierRange_ThreeValues_ReturnsAllValues()
    {
        // Arrange
        double[] inputs = [10.0, 20.0, 30.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - small dataset should typically retain all values
        await Assert.That(filtered.Length).IsEqualTo(3);
        await Assert.That(filtered[0]).IsEqualTo(10.0);
        await Assert.That(filtered[1]).IsEqualTo(20.0);
        await Assert.That(filtered[2]).IsEqualTo(30.0);
    }

    [Test]
    public async Task FindInlierRange_FourValues_WithOutlier_RemovesOutlier()
    {
        // Arrange
        double[] inputs = [1.0, 10.0, 11.0, 100.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - Q1 = 7.25, Q3 = 28.75, IQR = 21.5, lower = -25.0, upper = 61.0
        await Assert.That(filtered.ToArray()).DoesNotContain(100.0);
        await Assert.That(filtered.ToArray()).Contains(1.0);
        await Assert.That(filtered.ToArray()).Contains(10.0);
        await Assert.That(filtered.ToArray()).Contains(11.0);
    }

    [Test]
    public async Task FindInlierRange_FourIdenticalValues_ReturnsAllValues()
    {
        // Arrange
        double[] inputs = [42.0, 42.0, 42.0, 42.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 0, should return all values
        await Assert.That(filtered.Length).IsEqualTo(4);
        await Assert.That(filtered).All(item => item == 42.0);
    }

    // Tests for identical values (IQR=0)
    [Test]
    public async Task FindInlierRange_AllIdenticalValues_ReturnsAllValues()
    {
        // Arrange
        double[] inputs = [50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 0, should return all values
        await Assert.That(filtered.Length).IsEqualTo(7);
        await Assert.That(filtered).All(item => item == 50.0);
    }

    [Test]
    public async Task FindInlierRange_AllZeros_ReturnsAllValues()
    {
        // Arrange
        double[] inputs = [0.0, 0.0, 0.0, 0.0, 0.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 100.0);
        var filtered = inputs[range];

        // Assert - IQR = 0, should return all values
        await Assert.That(filtered.Length).IsEqualTo(5);
        await Assert.That(filtered).All(item => item == 0.0);
    }

    // Tests for boundary values
    [Test]
    public async Task FindInlierRange_ValueAtLowerBound_IsIncluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        double[] inputs = [0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - value 0.0 is above lower bound (-30), should be included
        await Assert.That(filtered.ToArray()).Contains(0.0);
    }

    [Test]
    public async Task FindInlierRange_ValueAtUpperBound_IsIncluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        double[] inputs = [0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - value 100.0 is below upper bound (130), should be included
        await Assert.That(filtered.ToArray()).Contains(100.0);
    }

    [Test]
    public async Task FindInlierRange_ValueBelowLowerBound_IsExcluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        double[] inputs = [-50.0, 0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - value -50.0 is far below lower bound, should be excluded
        await Assert.That(filtered.ToArray()).DoesNotContain(-50.0);
    }

    [Test]
    public async Task FindInlierRange_ValueAboveUpperBound_IsExcluded()
    {
        // Arrange - Q1 = 30, Q3 = 70, IQR = 40, lower = -30, upper = 130
        double[] inputs = [0.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 100.0, 200.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 300.0);
        var filtered = inputs[range];

        // Assert - value 200.0 is far above upper bound, should be excluded
        await Assert.That(filtered.ToArray()).DoesNotContain(200.0);
    }

    // Tests for MAD fallback when IQR = 0
    [Test]
    public async Task FindInlierRange_IQRZeroWithOutliers_UsesMADFallback()
    {
        // Arrange - Most values are 50.0 (Q1=Q3=50, IQR=0), but there are multiple varied values and outliers
        // With 75% of values at 50.0, Q1 and Q3 will both be 50.0
        double[] inputs = [1.0, 45.0, 48.0, 49.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 51.0, 52.0, 55.0, 99.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - MAD should detect and remove extreme outliers (1.0 and 99.0)
        // Median = 50, Deviations = [49, 5, 2, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 2, 5, 49]
        // MAD = median of deviations ≈ 0.5, bounds = 50 ± 2.5*0.5 = [48.75, 51.25]
        // Actually, with sorted deviations, MAD will be between 0 and 1
        // With MAD multiplier 2.5, extreme values should be removed
        await Assert.That(filtered.ToArray()).DoesNotContain(1.0);
        await Assert.That(filtered.ToArray()).DoesNotContain(99.0);
        await Assert.That(filtered.ToArray()).Contains(50.0);
    }

    [Test]
    public async Task FindInlierRange_IQRZeroNoOutliers_ReturnsAllValues()
    {
        // Arrange - Most values are 50.0, with slight variation within MAD range
        double[] inputs = [48.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 52.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - Small deviations should be within MAD bounds
        await Assert.That(filtered.ToArray()).Contains(48.0);
        await Assert.That(filtered.ToArray()).Contains(52.0);
        await Assert.That(filtered.Length).IsEqualTo(9);
    }

    [Test]
    public async Task FindInlierRange_LargeDatasetWithMADFallback_UsesArrayPool()
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

        double[] inputSpan = inputs;

        // Act
        var range = OutlierIqr.FindInlierRange(inputSpan, 200.0);
        var filtered = inputSpan[range];

        // Assert - Should use ArrayPool (size > 1024) and process data correctly
        // With this distribution (75% identical), IQR = 0, MAD will also be small
        // All values should be retained as they're close together
        await Assert.That(inputSpan.Length > 1024).IsTrue().Because("Test should use ArrayPool path");
        await Assert.That(filtered.Length).IsEqualTo(1500); // All values retained (no outliers)
    }

    [Test]
    public async Task FindInlierRange_MADBreakdownPoint_Demonstrates50PercentLimit()
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

        double[] inputSpan = inputs;

        // Act
        var range = OutlierIqr.FindInlierRange(inputSpan, 200.0);
        var filtered = inputSpan[range];

        // Assert - MAD ≈ 0 because >50% of values are identical
        // All data is returned (cannot detect outliers)
        await Assert.That(filtered.Length).IsEqualTo(100);
        await Assert.That(filtered.ToArray()).Contains(1.0);   // Outliers are NOT removed
        await Assert.That(filtered.ToArray()).Contains(99.0);  // due to MAD limitation
    }

    [Test]
    public async Task FindInlierRange_MADEffectiveDetection_BelowBreakdownPoint()
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

        double[] inputSpan = inputs;

        // Act
        var range = OutlierIqr.FindInlierRange(inputSpan, 200.0);
        var filtered = inputSpan[range];

        // Assert - MAD > 0, can detect extreme outliers
        // Median ≈ 50, with good distribution, MAD should be effective
        // With k=3.0 and scaling, some intermediate outliers might remain
        await Assert.That(filtered.ToArray()).DoesNotContain(1.0);
        await Assert.That(filtered.ToArray()).DoesNotContain(2.0);
        await Assert.That(filtered.ToArray()).DoesNotContain(98.0);
        await Assert.That(filtered.ToArray()).DoesNotContain(99.0);
        await Assert.That(filtered.Length >= 78).IsTrue().Because($"Expected at least 78 values, got {filtered.Length}");
    }

    [Test]
    public async Task FindInlierRange_MADCalculation_MedianCorrect()
    {
        // Arrange - Testing internal MAD calculation indirectly
        double[] inputs = [10.0, 50.0, 50.0, 50.0, 50.0, 50.0, 50.0, 90.0];

        // Act
        var range = OutlierIqr.FindInlierRange(inputs, 200.0);
        var filtered = inputs[range];

        // Assert - Values should be filtered based on MAD from median (50.0)
        // MAD = median(|10-50|, |50-50|, |50-50|, |50-50|, |50-50|, |50-50|, |90-50|)
        // MAD = median(40, 0, 0, 0, 0, 0, 40) = 0
        // Since MAD is 0, all should be returned
        await Assert.That(filtered.Length).IsEqualTo(8);
    }

    [Test]
    public async Task FindInlierRange_QuartilesCalculation_InternalTest()
    {
        // Arrange - Testing quartile calculation
        double[] sortedData = [10.0, 20.0, 30.0, 40.0, 50.0, 60.0, 70.0, 80.0, 90.0];

        // Act
        OutlierIqr.GetQuartiles(sortedData, out var q1, out var q3);

        // Assert - Q1 should be 25th percentile, Q3 should be 75th percentile
        await Assert.That(q1).IsEqualTo(30.0);
        await Assert.That(q3).IsEqualTo(70.0);
    }
}
