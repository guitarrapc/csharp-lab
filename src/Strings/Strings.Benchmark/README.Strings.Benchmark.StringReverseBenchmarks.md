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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.33 μs** | **192.50 μs** | **10.551 μs** |  **10.359 μs** |  **10.118 μs** |  **28.51 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  85.89 μs | 195.51 μs | 10.716 μs |  84.031 μs |  76.228 μs |  97.42 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  42.77 μs | 259.46 μs | 14.222 μs |  38.221 μs |  31.379 μs |  58.71 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  23.68 μs | 154.47 μs |  8.467 μs |  26.349 μs |  14.197 μs |  30.49 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  55.23 μs | 264.21 μs | 14.482 μs |  47.058 μs |  46.686 μs |  71.95 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  17.63 μs | 271.18 μs | 14.864 μs |   9.277 μs |   8.826 μs |  34.79 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.13 μs | 257.82 μs | 14.132 μs |  27.140 μs |  26.799 μs |  51.45 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  55.57 μs |  72.44 μs |  3.971 μs |  55.264 μs |  51.757 μs |  59.68 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  11.34 μs | 159.61 μs |  8.749 μs |   6.332 μs |   6.242 μs |  21.44 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  44.73 μs | 135.85 μs |  7.447 μs |  42.941 μs |  38.342 μs |  52.91 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.91 μs | 242.01 μs | 13.266 μs |  27.011 μs |  20.028 μs |  45.69 μs |  33.25 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  18.37 μs | 208.77 μs | 11.444 μs |  13.495 μs |  10.178 μs |  31.45 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  51.55 μs | 248.88 μs | 13.642 μs |  44.152 μs |  43.210 μs |  67.30 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.72 μs | 167.27 μs |  9.169 μs |   6.562 μs |   6.302 μs |  22.31 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  40.63 μs | 149.77 μs |  8.209 μs |  43.311 μs |  31.418 μs |  47.17 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  68.98 μs | 135.50 μs |  7.427 μs |  72.361 μs |  60.468 μs |  74.12 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **20.69 μs** | **400.29 μs** | **21.941 μs** |   **8.285 μs** |   **7.764 μs** |  **46.02 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 300.85 μs | 290.51 μs | 15.924 μs | 298.957 μs | 285.952 μs | 317.63 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 157.12 μs | 100.14 μs |  5.489 μs | 159.688 μs | 150.821 μs | 160.86 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  71.87 μs | 263.17 μs | 14.425 μs |  67.726 μs |  59.971 μs |  87.91 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 266.70 μs | 562.57 μs | 30.836 μs | 262.875 μs | 237.958 μs | 299.27 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.25 μs | 191.86 μs | 10.517 μs |   7.298 μs |   7.059 μs |  25.39 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  89.92 μs | 502.45 μs | 27.541 μs |  83.456 μs |  66.193 μs | 120.12 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 317.84 μs | 173.23 μs |  9.496 μs | 322.284 μs | 306.938 μs | 324.30 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  22.57 μs | 471.86 μs | 25.864 μs |   7.668 μs |   7.599 μs |  52.43 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 147.47 μs | 317.56 μs | 17.407 μs | 143.181 μs | 132.602 μs | 166.62 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 159.82 μs |  79.78 μs |  4.373 μs | 157.619 μs | 156.977 μs | 164.85 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  71.71 μs | 281.90 μs | 15.452 μs |  67.144 μs |  59.050 μs |  88.93 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 246.56 μs | 567.53 μs | 31.108 μs | 248.398 μs | 214.575 μs | 276.71 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.08 μs | 198.24 μs | 10.866 μs |   6.882 μs |   6.732 μs |  25.63 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  76.15 μs | 280.25 μs | 15.362 μs |  67.667 μs |  66.905 μs |  93.89 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 294.31 μs | 201.62 μs | 11.052 μs | 295.344 μs | 282.781 μs | 304.81 μs |  20.25 KB |
