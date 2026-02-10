namespace Logic.Core;

/// <summary>
/// Outlier removal by IQR (Interquartile Range) method.
/// </summary>
public static class OutlierIQR
{
    /// <summary>
    /// Remove outliers from data using IQR method.
    /// </summary>
    /// <param name="data">The input data. This span will be sorted in-place.</param>
    /// <param name="upperLimit">The upper limit for outlier removal.</param>
    /// <returns>A range representing the valid data slice after outlier removal.</returns>
    public static Range FindInlierRange(Span<double> data, double upperLimit)
    {
        if (data.Length == 0)
            return 0..0;

        data.Sort();

        GetQuartiles(data, out var q1, out var q3);
        var iqr = q3 - q1;

        // If IQR is zero, all data points are identical; return the full range.
        if (iqr == 0)
            return 0..data.Length;

        var lowerBound = q1 - 1.5 * iqr;
        var upperBound = q3 + 1.5 * iqr;
        var effectiveUpperBound = Math.Min(upperBound, upperLimit);

        int startIndex = BinarySearchLowerBound(data, lowerBound);
        int endIndex = BinarySearchUpperBound(data, effectiveUpperBound);

        return startIndex..endIndex;
    }

    private static int BinarySearchLowerBound(ReadOnlySpan<double> sortedData, double value)
    {
        int left = 0;
        int right = sortedData.Length;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (sortedData[mid] < value)
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }

    private static int BinarySearchUpperBound(ReadOnlySpan<double> sortedData, double value)
    {
        int left = 0;
        int right = sortedData.Length;
        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (sortedData[mid] <= value)
                left = mid + 1;
            else
                right = mid;
        }
        return left;
    }

    internal static void GetQuartiles(ReadOnlySpan<double> sortedData, out double q1, out double q3)
    {
        q1 = GetPercentile(sortedData, 25.0);
        q3 = GetPercentile(sortedData, 75.0);
    }

    private static double GetPercentile(ReadOnlySpan<double> sortedData, double p)
    {
        int n = sortedData.Length;
        if (n == 1) return sortedData[0];

        double pos = (n - 1) * (p / 100.0);
        int k = (int)pos;
        double frac = pos - k;

        if (k >= n - 1) return sortedData[n - 1];
        return sortedData[k] + (sortedData[k + 1] - sortedData[k]) * frac;
    }
}
