```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.41 μs** | **154.58 μs** |  **8.473 μs** |  **10.560 μs** |   **6.733 μs** |  **22.94 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  84.01 μs | 205.43 μs | 11.260 μs |  80.371 μs |  75.020 μs |  96.64 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  30.90 μs | 237.68 μs | 13.028 μs |  25.757 μs |  21.229 μs |  45.72 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.37 μs | 143.45 μs |  7.863 μs |  14.101 μs |   9.883 μs |  25.11 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  65.14 μs | 312.67 μs | 17.139 μs |  55.955 μs |  54.562 μs |  84.92 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  14.03 μs | 227.88 μs | 12.491 μs |   7.083 μs |   6.562 μs |  28.45 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  48.14 μs | 311.39 μs | 17.068 μs |  39.504 μs |  37.109 μs |  67.80 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  63.66 μs | 262.16 μs | 14.370 μs |  59.480 μs |  51.846 μs |  79.66 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.75 μs | 132.41 μs |  7.258 μs |  10.769 μs |   6.682 μs |  20.79 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  45.49 μs | 108.29 μs |  5.936 μs |  45.224 μs |  39.694 μs |  51.56 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  29.52 μs | 240.14 μs | 13.163 μs |  24.191 μs |  19.852 μs |  44.51 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.23 μs | 154.55 μs |  8.471 μs |  13.380 μs |   9.543 μs |  25.75 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  48.33 μs | 230.11 μs | 12.613 μs |  41.447 μs |  40.657 μs |  62.89 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  15.10 μs | 245.09 μs | 13.434 μs |   8.336 μs |   6.383 μs |  30.57 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  35.22 μs | 158.69 μs |  8.698 μs |  32.490 μs |  28.212 μs |  44.95 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  53.78 μs |  73.03 μs |  4.003 μs |  54.547 μs |  49.456 μs |  57.35 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **22.44 μs** | **334.62 μs** | **18.342 μs** |  **11.872 μs** |  **11.832 μs** |  **43.62 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 316.59 μs | 327.39 μs | 17.945 μs | 324.887 μs | 296.002 μs | 328.89 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 148.90 μs |  15.07 μs |  0.826 μs | 148.809 μs | 148.127 μs | 149.77 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  67.74 μs | 273.38 μs | 14.985 μs |  73.106 μs |  50.814 μs |  79.31 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 236.46 μs | 547.49 μs | 30.010 μs | 232.093 μs | 208.869 μs | 268.41 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  14.24 μs | 183.08 μs | 10.035 μs |   9.968 μs |   7.053 μs |  25.71 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  86.08 μs | 556.38 μs | 30.497 μs |  69.019 μs |  67.927 μs | 121.29 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 306.84 μs | 184.89 μs | 10.134 μs | 309.473 μs | 295.647 μs | 315.39 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.03 μs | 292.21 μs | 16.017 μs |   7.875 μs |   7.695 μs |  35.53 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 120.76 μs | 205.61 μs | 11.270 μs | 115.115 μs | 113.432 μs | 133.74 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 150.84 μs | 148.22 μs |  8.124 μs | 147.345 μs | 145.050 μs | 160.13 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.33 μs | 237.85 μs | 13.037 μs |  58.959 μs |  49.642 μs |  75.39 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 230.46 μs | 556.87 μs | 30.524 μs | 225.722 μs | 202.589 μs | 263.08 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.34 μs | 195.71 μs | 10.728 μs |   7.182 μs |   7.113 μs |  25.73 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  85.11 μs | 304.07 μs | 16.667 μs |  91.360 μs |  66.223 μs |  97.75 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 305.80 μs | 387.98 μs | 21.267 μs | 307.244 μs | 283.849 μs | 326.31 μs |  19.97 KB |
