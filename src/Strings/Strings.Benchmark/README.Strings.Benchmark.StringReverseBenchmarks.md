```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.33 μs** | **146.66 μs** |  **8.039 μs** |  **10.970 μs** |   **6.732 μs** |  **22.28 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  82.82 μs | 231.47 μs | 12.688 μs |  79.038 μs |  72.455 μs |  96.97 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  38.61 μs | 407.45 μs | 22.334 μs |  28.910 μs |  22.767 μs |  64.15 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  17.11 μs | 159.22 μs |  8.727 μs |  14.336 μs |  10.109 μs |  26.89 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  64.48 μs | 410.70 μs | 22.512 μs |  59.973 μs |  44.564 μs |  88.91 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  14.91 μs | 190.63 μs | 10.449 μs |   9.227 μs |   8.536 μs |  26.97 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.53 μs | 286.54 μs | 15.706 μs |  26.850 μs |  26.078 μs |  53.66 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  57.08 μs |  63.64 μs |  3.488 μs |  57.838 μs |  53.271 μs |  60.12 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.63 μs | 135.42 μs |  7.423 μs |  10.490 μs |   6.512 μs |  20.89 μs |   9.81 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  44.97 μs | 137.31 μs |  7.526 μs |  42.720 μs |  38.831 μs |  53.37 μs |  17.63 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  43.22 μs | 263.06 μs | 14.419 μs |  39.289 μs |  31.174 μs |  59.20 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  18.79 μs | 112.92 μs |  6.189 μs |  15.654 μs |  14.802 μs |  25.92 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  60.84 μs | 232.84 μs | 12.763 μs |  66.994 μs |  46.166 μs |  69.36 μs |  30.86 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.99 μs | 176.22 μs |  9.659 μs |   6.652 μs |   6.181 μs |  23.14 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  42.76 μs | 180.48 μs |  9.893 μs |  48.295 μs |  31.343 μs |  48.66 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  58.56 μs |  64.51 μs |  3.536 μs |  58.991 μs |  54.833 μs |  61.87 μs |   9.81 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.02 μs** | **273.27 μs** | **14.979 μs** |   **8.375 μs** |   **8.365 μs** |  **34.31 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 328.34 μs | 351.64 μs | 19.274 μs | 336.920 μs | 306.262 μs | 341.83 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 168.72 μs | 232.32 μs | 12.734 μs | 168.293 μs | 156.211 μs | 181.67 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  64.33 μs | 244.16 μs | 13.383 μs |  62.606 μs |  51.886 μs |  78.49 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 278.50 μs | 672.16 μs | 36.843 μs | 279.471 μs | 241.180 μs | 314.85 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.86 μs | 208.75 μs | 11.442 μs |   7.343 μs |   7.163 μs |  27.07 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  86.50 μs | 548.23 μs | 30.050 μs |  69.320 μs |  68.979 μs | 121.20 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 315.77 μs | 580.36 μs | 31.811 μs | 304.459 μs | 291.154 μs | 351.69 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  24.18 μs | 395.74 μs | 21.692 μs |  12.062 μs |  11.251 μs |  49.22 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 122.63 μs | 228.73 μs | 12.537 μs | 116.167 μs | 114.635 μs | 137.08 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 154.91 μs | 145.75 μs |  7.989 μs | 156.162 μs | 146.364 μs | 162.19 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  61.23 μs | 226.10 μs | 12.393 μs |  58.900 μs |  50.163 μs |  74.62 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 242.85 μs | 640.15 μs | 35.089 μs | 231.301 μs | 214.991 μs | 282.26 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  19.60 μs | 379.94 μs | 20.826 μs |   8.255 μs |   6.903 μs |  43.63 μs |  15.23 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  94.16 μs | 373.24 μs | 20.459 μs |  87.513 μs |  77.855 μs | 117.12 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 297.14 μs | 195.46 μs | 10.714 μs | 300.761 μs | 285.082 μs | 305.57 μs |  20.25 KB |
