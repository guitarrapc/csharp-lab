```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.37 μs** |   **139.33 μs** |  **7.637 μs** |  **11.611 μs** |   **6.762 μs** |  **21.73 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  83.08 μs |   261.59 μs | 14.339 μs |  88.801 μs |  66.761 μs |  93.67 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  38.47 μs |   463.83 μs | 25.424 μs |  26.300 μs |  21.410 μs |  67.69 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.92 μs |   156.40 μs |  8.573 μs |  14.187 μs |  10.039 μs |  26.52 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  58.60 μs |   354.11 μs | 19.410 μs |  48.360 μs |  46.446 μs |  80.98 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.88 μs |   163.61 μs |  8.968 μs |   9.276 μs |   6.281 μs |  23.09 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  34.87 μs |   261.18 μs | 14.316 μs |  26.631 μs |  26.570 μs |  51.40 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  58.21 μs |   103.68 μs |  5.683 μs |  56.966 μs |  53.249 μs |  64.41 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.22 μs |   140.82 μs |  7.719 μs |  11.260 μs |   6.672 μs |  21.73 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  46.89 μs |   159.42 μs |  8.738 μs |  43.181 μs |  40.626 μs |  56.88 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.53 μs |   253.96 μs | 13.920 μs |  25.016 μs |  20.217 μs |  46.37 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.97 μs |   174.12 μs |  9.544 μs |  13.386 μs |   9.729 μs |  27.78 μs |   9.81 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  69.79 μs |   682.24 μs | 37.396 μs |  54.471 μs |  42.480 μs | 112.41 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  14.48 μs |   190.06 μs | 10.418 μs |   8.576 μs |   8.356 μs |  26.51 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  42.09 μs |   197.97 μs | 10.851 μs |  46.646 μs |  29.705 μs |  49.92 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  55.65 μs |    70.78 μs |  3.879 μs |  55.373 μs |  51.917 μs |  59.66 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.39 μs** |   **255.10 μs** | **13.983 μs** |   **8.706 μs** |   **7.934 μs** |  **32.53 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 344.75 μs | 1,294.87 μs | 70.976 μs | 318.705 μs | 290.482 μs | 425.07 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 160.60 μs |    12.07 μs |  0.662 μs | 160.815 μs | 159.863 μs | 161.13 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  71.52 μs |   282.42 μs | 15.481 μs |  67.375 μs |  58.539 μs |  88.66 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 312.97 μs | 1,032.40 μs | 56.589 μs | 282.729 μs | 277.930 μs | 378.26 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.27 μs |   206.46 μs | 11.317 μs |  10.390 μs |   7.204 μs |  28.20 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  93.42 μs |   817.00 μs | 44.783 μs |  68.098 μs |  67.045 μs | 145.13 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 299.75 μs |   123.56 μs |  6.773 μs | 302.139 μs | 292.101 μs | 305.00 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.34 μs |   260.51 μs | 14.279 μs |   8.215 μs |   7.984 μs |  32.83 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 125.01 μs |   198.75 μs | 10.894 μs | 121.117 μs | 116.599 μs | 137.32 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 152.45 μs |   173.81 μs |  9.527 μs | 148.088 μs | 145.883 μs | 163.38 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.24 μs |   213.12 μs | 11.682 μs |  59.933 μs |  50.264 μs |  73.52 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 232.02 μs |   540.04 μs | 29.601 μs | 228.623 μs | 204.256 μs | 263.17 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.47 μs |   200.72 μs | 11.002 μs |   7.253 μs |   6.993 μs |  26.18 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  93.49 μs |   349.14 μs | 19.137 μs |  86.482 μs |  78.848 μs | 115.15 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 315.59 μs |   324.65 μs | 17.795 μs | 314.087 μs | 298.588 μs | 334.08 μs |  20.25 KB |
