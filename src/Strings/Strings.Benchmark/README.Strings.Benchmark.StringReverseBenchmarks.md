```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.11 μs** | **169.04 μs** |  **9.266 μs** |  **15.990 μs** |  **10.089 μs** |  **28.25 μs** |   **9.81 KB** |
| EnumerableReverse      | 10     | 100    |  47.08 μs | 208.05 μs | 11.404 μs |  43.081 μs |  38.212 μs |  59.94 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  32.64 μs | 310.00 μs | 16.992 μs |  25.178 μs |  20.659 μs |  52.09 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.30 μs | 178.55 μs |  9.787 μs |  14.868 μs |  14.437 μs |  31.60 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.37 μs | 255.70 μs | 14.016 μs |  42.669 μs |  41.888 μs |  66.55 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.45 μs | 210.12 μs | 11.517 μs |   6.873 μs |   6.733 μs |  26.75 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.33 μs | 163.71 μs |  8.974 μs |  33.889 μs |  28.829 μs |  46.27 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.49 μs** | **282.72 μs** | **15.497 μs** |   **8.676 μs** |   **8.416 μs** |  **35.39 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 124.40 μs | 201.35 μs | 11.037 μs | 119.309 μs | 116.825 μs | 137.06 μs |  37.94 KB |
| RecursiveReverse       | 64     | 100    | 152.22 μs | 285.67 μs | 15.659 μs | 143.600 μs | 142.758 μs | 170.29 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  68.07 μs | 227.30 μs | 12.459 μs |  67.958 μs |  55.674 μs |  80.59 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 252.70 μs | 779.94 μs | 42.751 μs | 249.218 μs | 211.798 μs | 297.09 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.33 μs | 185.18 μs | 10.150 μs |   9.599 μs |   7.404 μs |  25.98 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  75.44 μs | 276.26 μs | 15.143 μs |  67.081 μs |  66.320 μs |  92.92 μs |  38.22 KB |
