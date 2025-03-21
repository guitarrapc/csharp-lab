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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.48 μs** | **196.23 μs** | **10.756 μs** |  **10.354 μs** |  **10.184 μs** |  **28.90 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  72.06 μs | 147.33 μs |  8.076 μs |  70.210 μs |  65.072 μs |  80.90 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  34.18 μs | 301.43 μs | 16.522 μs |  27.731 μs |  21.860 μs |  52.96 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.70 μs | 148.07 μs |  8.116 μs |  14.197 μs |  10.139 μs |  25.78 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  66.51 μs | 297.56 μs | 16.310 μs |  57.603 μs |  56.592 μs |  85.33 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  12.97 μs | 157.11 μs |  8.611 μs |   9.798 μs |   6.401 μs |  22.72 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  36.37 μs | 261.72 μs | 14.346 μs |  28.133 μs |  28.033 μs |  52.93 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  76.60 μs | 241.96 μs | 13.263 μs |  75.692 μs |  63.810 μs |  90.29 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.62 μs | 148.61 μs |  8.146 μs |   9.682 μs |   6.348 μs |  21.83 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  53.70 μs | 131.40 μs |  7.203 μs |  53.270 μs |  46.718 μs |  61.10 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.98 μs | 264.78 μs | 14.513 μs |  25.023 μs |  20.392 μs |  47.52 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.74 μs | 153.52 μs |  8.415 μs |  14.256 μs |   9.848 μs |  26.12 μs |   9.81 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  51.70 μs | 286.71 μs | 15.716 μs |  44.142 μs |  41.197 μs |  69.77 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  12.78 μs | 203.00 μs | 11.127 μs |   6.522 μs |   6.191 μs |  25.63 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  48.72 μs | 259.36 μs | 14.217 μs |  44.053 μs |  37.419 μs |  64.68 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  76.50 μs | 484.71 μs | 26.569 μs |  74.293 μs |  51.111 μs | 104.11 μs |   9.81 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.51 μs** | **284.58 μs** | **15.599 μs** |   **8.716 μs** |   **8.287 μs** |  **35.52 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 316.38 μs | 260.57 μs | 14.283 μs | 309.818 μs | 306.552 μs | 332.76 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 176.28 μs | 146.14 μs |  8.010 μs | 175.948 μs | 168.444 μs | 184.45 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  63.93 μs | 250.21 μs | 13.715 μs |  61.169 μs |  51.801 μs |  78.81 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 238.88 μs | 536.97 μs | 29.433 μs | 235.960 μs | 211.014 μs | 269.66 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.77 μs | 197.72 μs | 10.838 μs |   8.139 μs |   6.907 μs |  26.26 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  86.93 μs | 531.74 μs | 29.146 μs |  70.803 μs |  69.410 μs | 120.58 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 310.33 μs | 202.51 μs | 11.100 μs | 316.160 μs | 297.525 μs | 317.29 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.67 μs | 276.80 μs | 15.172 μs |   7.964 μs |   7.864 μs |  34.19 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 125.45 μs | 248.88 μs | 13.642 μs | 118.682 μs | 116.518 μs | 141.15 μs |  37.94 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 152.55 μs | 152.25 μs |  8.346 μs | 152.094 μs | 144.449 μs | 161.12 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  66.88 μs | 374.31 μs | 20.517 μs |  60.152 μs |  50.574 μs |  89.92 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 230.89 μs | 541.03 μs | 29.656 μs | 227.926 μs | 202.820 μs | 261.91 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  14.08 μs | 217.60 μs | 11.927 μs |   7.274 μs |   7.114 μs |  27.85 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  87.81 μs | 379.20 μs | 20.785 μs |  82.172 μs |  70.431 μs | 110.84 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 298.69 μs | 126.06 μs |  6.910 μs | 302.589 μs | 290.707 μs | 302.76 μs |  20.25 KB |
