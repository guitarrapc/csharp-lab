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
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.57 μs** |   **208.96 μs** | **11.454 μs** |  **10.104 μs** |   **9.803 μs** |  **29.79 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  82.24 μs |   178.41 μs |  9.779 μs |  79.392 μs |  74.203 μs |  93.13 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  46.38 μs |   290.03 μs | 15.897 μs |  39.894 μs |  34.745 μs |  64.49 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.23 μs |   141.37 μs |  7.749 μs |  13.745 μs |  10.028 μs |  24.92 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  60.55 μs |   286.61 μs | 15.710 μs |  52.707 μs |  50.303 μs |  78.64 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.58 μs |   149.75 μs |  8.208 μs |   9.588 μs |   6.282 μs |  21.86 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  45.65 μs |   136.46 μs |  7.480 μs |  49.401 μs |  37.038 μs |  50.51 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  69.35 μs |   117.74 μs |  6.454 μs |  71.243 μs |  62.157 μs |  74.64 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.06 μs |   136.59 μs |  7.487 μs |  10.850 μs |   6.923 μs |  21.40 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  48.83 μs |   179.01 μs |  9.812 μs |  53.781 μs |  37.530 μs |  55.18 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.15 μs |   258.97 μs | 14.195 μs |  24.110 μs |  19.983 μs |  46.37 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  17.43 μs |   188.58 μs | 10.337 μs |  13.344 μs |   9.758 μs |  29.18 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  49.87 μs |   235.69 μs | 12.919 μs |  42.449 μs |  42.378 μs |  64.79 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  12.43 μs |   160.54 μs |  8.800 μs |   8.525 μs |   6.251 μs |  22.50 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  37.83 μs |   210.59 μs | 11.543 μs |  33.753 μs |  28.873 μs |  50.85 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  64.69 μs |   194.72 μs | 10.673 μs |  61.674 μs |  55.843 μs |  76.54 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.38 μs** |   **268.35 μs** | **14.709 μs** |   **8.156 μs** |   **7.625 μs** |  **33.36 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 302.61 μs |   246.58 μs | 13.516 μs | 301.321 μs | 289.780 μs | 316.72 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 152.87 μs |    11.04 μs |  0.605 μs | 152.533 μs | 152.503 μs | 153.57 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  72.51 μs |   198.33 μs | 10.871 μs |  78.415 μs |  59.962 μs |  79.15 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 237.44 μs |   506.06 μs | 27.739 μs | 235.379 μs | 210.793 μs | 266.15 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.31 μs |   199.88 μs | 10.956 μs |   7.074 μs |   6.893 μs |  25.96 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  85.71 μs |   530.90 μs | 29.100 μs |  69.294 μs |  68.522 μs | 119.31 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 311.38 μs |   250.39 μs | 13.725 μs | 316.569 μs | 295.821 μs | 321.76 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  20.17 μs |   392.29 μs | 21.503 μs |   7.825 μs |   7.695 μs |  45.00 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 135.65 μs |   244.93 μs | 13.426 μs | 143.327 μs | 120.143 μs | 143.47 μs |  37.94 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 156.68 μs |    33.71 μs |  1.848 μs | 157.302 μs | 154.607 μs | 158.14 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  60.56 μs |   205.70 μs | 11.275 μs |  59.075 μs |  50.097 μs |  72.50 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 232.20 μs |   569.90 μs | 31.238 μs | 226.962 μs | 203.909 μs | 265.72 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.32 μs |   198.62 μs | 10.887 μs |   7.343 μs |   6.732 μs |  25.89 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  75.21 μs |   270.15 μs | 14.808 μs |  66.774 μs |  66.554 μs |  92.31 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 356.74 μs | 1,510.96 μs | 82.821 μs | 316.885 μs | 301.385 μs | 451.96 μs |  20.25 KB |
