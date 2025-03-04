```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.24 μs** | **189.30 μs** | **10.376 μs** |  **10.440 μs** |  **10.069 μs** |  **28.22 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  71.82 μs | 144.23 μs |  7.906 μs |  68.963 μs |  65.737 μs |  80.76 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  43.95 μs | 320.29 μs | 17.556 μs |  37.139 μs |  30.816 μs |  63.89 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.33 μs | 150.40 μs |  8.244 μs |  13.706 μs |   9.719 μs |  25.57 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  62.03 μs | 300.36 μs | 16.464 μs |  54.060 μs |  51.065 μs |  80.96 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.68 μs | 152.89 μs |  8.381 μs |   7.313 μs |   6.381 μs |  21.34 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  49.27 μs | 255.22 μs | 13.990 μs |  45.786 μs |  37.350 μs |  64.67 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  68.19 μs | 127.11 μs |  6.967 μs |  68.788 μs |  60.943 μs |  74.84 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  15.86 μs | 257.05 μs | 14.090 μs |   9.488 μs |   6.082 μs |  32.01 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  44.80 μs |  96.64 μs |  5.297 μs |  42.499 μs |  41.037 μs |  50.85 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  29.90 μs | 249.01 μs | 13.649 μs |  24.320 μs |  19.933 μs |  45.46 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.08 μs | 139.48 μs |  7.646 μs |  14.328 μs |   9.458 μs |  24.45 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.89 μs | 241.18 μs | 13.220 μs |  43.530 μs |  42.990 μs |  66.15 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.51 μs | 165.17 μs |  9.054 μs |   6.401 μs |   6.161 μs |  21.96 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  38.97 μs |  89.19 μs |  4.889 μs |  40.586 μs |  33.473 μs |  42.84 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  66.03 μs | 105.22 μs |  5.767 μs |  66.443 μs |  60.061 μs |  71.57 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.37 μs** | **270.25 μs** | **14.814 μs** |   **8.104 μs** |   **7.534 μs** |  **33.47 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 303.21 μs | 263.88 μs | 14.464 μs | 302.404 μs | 289.168 μs | 318.06 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 150.79 μs |  15.15 μs |  0.830 μs | 151.056 μs | 149.854 μs | 151.45 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  63.05 μs | 252.92 μs | 13.863 μs |  60.323 μs |  50.755 μs |  78.08 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 240.75 μs | 627.23 μs | 34.380 μs | 233.797 μs | 210.382 μs | 278.08 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  23.95 μs | 481.48 μs | 26.392 μs |   9.989 μs |   7.475 μs |  54.39 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 106.33 μs | 408.12 μs | 22.371 μs |  98.473 μs |  88.955 μs | 131.57 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 331.33 μs | 250.51 μs | 13.731 μs | 325.758 μs | 321.269 μs | 346.98 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.24 μs | 248.81 μs | 13.638 μs |  11.041 μs |   7.795 μs |  32.87 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 132.25 μs | 351.72 μs | 19.279 μs | 134.381 μs | 112.000 μs | 150.38 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 157.76 μs | 150.45 μs |  8.247 μs | 159.216 μs | 148.887 μs | 165.19 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  68.84 μs | 447.56 μs | 24.532 μs |  58.689 μs |  51.015 μs |  96.82 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 234.82 μs | 542.44 μs | 29.733 μs | 243.493 μs | 201.715 μs | 259.25 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.92 μs | 186.25 μs | 10.209 μs |   9.328 μs |   6.813 μs |  25.62 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  84.01 μs | 535.04 μs | 29.327 μs |  67.577 μs |  66.585 μs | 117.87 μs |  37.94 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 328.17 μs | 763.65 μs | 41.858 μs | 343.351 μs | 280.834 μs | 360.31 μs |  20.25 KB |
