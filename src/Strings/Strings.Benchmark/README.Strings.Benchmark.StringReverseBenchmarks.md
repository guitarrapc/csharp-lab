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
| Method                 | Runtime  | Length | Number | Mean      | Error        | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|-------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **18.28 μs** |   **259.371 μs** | **14.217 μs** |  **10.349 μs** |   **9.799 μs** |  **34.69 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  82.03 μs |   245.614 μs | 13.463 μs |  82.834 μs |  68.186 μs |  95.08 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.43 μs |   270.529 μs | 14.829 μs |  24.866 μs |  21.020 μs |  48.41 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  19.79 μs |   186.774 μs | 10.238 μs |  14.075 μs |  13.685 μs |  31.61 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  64.44 μs |   297.150 μs | 16.288 μs |  55.948 μs |  54.155 μs |  83.22 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.91 μs |   206.346 μs | 11.311 μs |   6.592 μs |   6.172 μs |  25.97 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  40.00 μs |   282.716 μs | 15.497 μs |  36.307 μs |  26.679 μs |  57.01 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  55.46 μs |    71.594 μs |  3.924 μs |  55.599 μs |  51.471 μs |  59.32 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.68 μs |   136.586 μs |  7.487 μs |  10.469 μs |   6.542 μs |  21.02 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  47.70 μs |   121.260 μs |  6.647 μs |  49.593 μs |  40.316 μs |  53.20 μs |  17.63 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  29.76 μs |   239.670 μs | 13.137 μs |  24.486 μs |  20.078 μs |  44.71 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  20.37 μs |   169.021 μs |  9.265 μs |  24.615 μs |   9.748 μs |  26.76 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  51.86 μs |   259.882 μs | 14.245 μs |  44.072 μs |  43.200 μs |  68.30 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.21 μs |   158.095 μs |  8.666 μs |   6.303 μs |   6.102 μs |  21.21 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  41.53 μs |   209.781 μs | 11.499 μs |  48.090 μs |  28.254 μs |  48.25 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  67.99 μs |   100.921 μs |  5.532 μs |  67.847 μs |  62.526 μs |  73.59 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.39 μs** |   **284.284 μs** | **15.583 μs** |   **8.918 μs** |   **7.886 μs** |  **35.38 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 328.02 μs |   348.548 μs | 19.105 μs | 325.045 μs | 310.578 μs | 348.44 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 172.18 μs |   331.771 μs | 18.185 μs | 182.129 μs | 151.191 μs | 183.22 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  62.13 μs |   223.235 μs | 12.236 μs |  61.359 μs |  50.298 μs |  74.73 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 235.70 μs |   486.864 μs | 26.687 μs | 234.787 μs | 209.479 μs | 262.83 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.75 μs |   195.195 μs | 10.699 μs |   7.714 μs |   7.424 μs |  26.10 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 102.72 μs |   498.433 μs | 27.321 μs |  97.080 μs |  78.666 μs | 132.43 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 339.30 μs | 1,153.411 μs | 63.222 μs | 318.793 μs | 288.868 μs | 410.22 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.17 μs |   268.904 μs | 14.740 μs |   7.895 μs |   7.434 μs |  33.19 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 131.60 μs |   322.539 μs | 17.679 μs | 136.926 μs | 111.869 μs | 146.00 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 144.99 μs |     5.441 μs |  0.298 μs | 144.820 μs | 144.809 μs | 145.33 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  69.45 μs |   310.160 μs | 17.001 μs |  60.222 μs |  59.050 μs |  89.06 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 236.00 μs |   510.991 μs | 28.009 μs | 232.573 μs | 209.862 μs | 265.56 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.28 μs |   199.402 μs | 10.930 μs |   7.002 μs |   6.932 μs |  25.90 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  74.99 μs |   278.694 μs | 15.276 μs |  66.214 μs |  66.134 μs |  92.63 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 336.98 μs | 1,074.293 μs | 58.886 μs | 313.644 μs | 293.345 μs | 403.96 μs |  20.25 KB |
