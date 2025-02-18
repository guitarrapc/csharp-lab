```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **12.08 μs** | **165.47 μs** |  **9.070 μs** |   **6.892 μs** |   **6.793 μs** |  **22.55 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  72.36 μs | 148.21 μs |  8.124 μs |  69.600 μs |  65.974 μs |  81.50 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  43.26 μs | 275.82 μs | 15.118 μs |  37.043 μs |  32.245 μs |  60.50 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  19.85 μs | 183.64 μs | 10.066 μs |  14.156 μs |  13.915 μs |  31.47 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  69.55 μs | 517.80 μs | 28.383 μs |  54.050 μs |  52.297 μs | 102.31 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  17.97 μs | 277.03 μs | 15.185 μs |   9.547 μs |   8.856 μs |  35.50 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.03 μs | 236.93 μs | 12.987 μs |  27.723 μs |  27.340 μs |  50.02 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  67.81 μs | 293.88 μs | 16.109 μs |  60.553 μs |  56.605 μs |  86.27 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  11.21 μs | 153.06 μs |  8.390 μs |   6.673 μs |   6.062 μs |  20.89 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  47.91 μs |  92.50 μs |  5.070 μs |  50.084 μs |  42.118 μs |  51.54 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  43.24 μs | 353.84 μs | 19.395 μs |  35.085 μs |  29.255 μs |  65.38 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.08 μs | 141.15 μs |  7.737 μs |  13.665 μs |   9.838 μs |  24.74 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  50.91 μs | 295.86 μs | 16.217 μs |  41.898 μs |  41.197 μs |  69.63 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  12.81 μs | 168.73 μs |  9.249 μs |   8.796 μs |   6.241 μs |  23.38 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  47.87 μs | 173.91 μs |  9.533 μs |  45.014 μs |  40.085 μs |  58.50 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  57.02 μs |  89.82 μs |  4.923 μs |  59.666 μs |  51.341 μs |  60.06 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.27 μs** | **261.04 μs** | **14.308 μs** |   **8.450 μs** |   **7.580 μs** |  **32.79 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 301.95 μs | 277.63 μs | 15.218 μs | 304.273 μs | 285.698 μs | 315.87 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 166.07 μs | 256.95 μs | 14.084 μs | 173.384 μs | 149.830 μs | 174.99 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  61.21 μs | 218.82 μs | 11.994 μs |  60.282 μs |  49.714 μs |  73.65 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 253.84 μs | 886.17 μs | 48.574 μs | 233.888 μs | 218.428 μs | 309.22 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  16.63 μs | 256.39 μs | 14.054 μs |   9.969 μs |   7.154 μs |  32.78 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  89.89 μs | 745.79 μs | 40.880 μs |  67.075 μs |  65.512 μs | 137.09 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 309.19 μs | 172.95 μs |  9.480 μs | 307.795 μs | 300.491 μs | 319.30 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  23.12 μs | 385.18 μs | 21.113 μs |  11.061 μs |  10.801 μs |  47.50 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 133.74 μs | 329.47 μs | 18.059 μs | 137.923 μs | 113.959 μs | 149.34 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 159.96 μs | 272.04 μs | 14.911 μs | 165.169 μs | 143.138 μs | 171.56 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.84 μs | 242.22 μs | 13.277 μs |  59.201 μs |  50.074 μs |  76.23 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 240.79 μs | 655.19 μs | 35.913 μs | 230.731 μs | 210.984 μs | 280.66 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.61 μs | 197.89 μs | 10.847 μs |   7.754 μs |   6.952 μs |  26.13 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  86.48 μs | 105.08 μs |  5.760 μs |  89.016 μs |  79.889 μs |  90.54 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 291.86 μs | 136.74 μs |  7.495 μs | 294.460 μs | 283.409 μs | 297.71 μs |  20.25 KB |
