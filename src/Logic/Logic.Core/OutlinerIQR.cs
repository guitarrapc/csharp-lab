namespace Logic.Core;

/// <summary>
/// Outliner removal by IQR (Interquartile Range) method.
/// </summary>
public static class OutlinerIQR
{
    /// <summary>
    /// Remove outliners from data using IQR method.
    /// </summary>
    /// <param name="data">The input data. This span will be sorted in-place.</param>
    /// <param name="upperLimit">The upper limit for outlier removal.</param>
    /// <returns>A range representing the valid data slice after outlier removal.</returns>
    public static Range RemoveOutliner(Span<double> data, double upperLimit)
    {
        if (data.Length == 0)
            return 0..0;

        data.Sort();

        var lowerBound = GetLowerBound(data);
        var upperBound = GetUpperBound(data);
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

    internal static double GetLowerBound(ReadOnlySpan<double> sortedData)
    {
        var q1 = GetPercentile(sortedData, 25);
        var q3 = GetPercentile(sortedData, 75);
        var iqr = q3 - q1;
        return q1 - 1.5 * iqr;
    }

    internal static double GetUpperBound(ReadOnlySpan<double> sortedData)
    {
        var q1 = GetPercentile(sortedData, 25);
        var q3 = GetPercentile(sortedData, 75);
        var iqr = q3 - q1;
        return q3 + 1.5 * iqr;
    }

    private static double GetPercentile(ReadOnlySpan<double> sortedData, double percentile)
    {
        var n = sortedData.Length;
        var position = (n - 1) * percentile / 100.0 + 1;
        if (position == 1) return sortedData[0];
        if (position == n) return sortedData[n - 1];
        var k = (int)Math.Floor(position) - 1;
        var d = position - Math.Floor(position);
        return sortedData[k] + d * (sortedData[k + 1] - sortedData[k]);
    }
}
