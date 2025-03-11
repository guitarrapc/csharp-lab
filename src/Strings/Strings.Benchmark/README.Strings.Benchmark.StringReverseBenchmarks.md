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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.04 μs** | **177.01 μs** |  **9.703 μs** |  **10.460 μs** |  **10.409 μs** |  **27.24 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  77.17 μs | 218.72 μs | 11.989 μs |  77.415 μs |  65.053 μs |  89.03 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.64 μs | 256.18 μs | 14.042 μs |  25.647 μs |  21.580 μs |  47.68 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  17.19 μs | 155.85 μs |  8.542 μs |  14.607 μs |  10.229 μs |  26.72 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  50.84 μs | 236.55 μs | 12.966 μs |  43.391 μs |  43.322 μs |  65.81 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.58 μs | 156.25 μs |  8.565 μs |   6.763 μs |   6.513 μs |  21.47 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  51.30 μs | 287.44 μs | 15.756 μs |  43.471 μs |  40.996 μs |  69.44 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  64.88 μs | 129.13 μs |  7.078 μs |  62.682 μs |  59.155 μs |  72.79 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  17.38 μs | 282.06 μs | 15.461 μs |  10.840 μs |   6.262 μs |  35.03 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  44.98 μs |  91.23 μs |  5.001 μs |  43.402 μs |  40.967 μs |  50.59 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.41 μs | 255.58 μs | 14.009 μs |  24.736 μs |  20.127 μs |  46.37 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  17.15 μs | 158.84 μs |  8.707 μs |  14.171 μs |  10.324 μs |  26.95 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  49.33 μs | 260.08 μs | 14.256 μs |  41.156 μs |  41.046 μs |  65.79 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  17.66 μs | 363.81 μs | 19.942 μs |   6.281 μs |   6.011 μs |  40.69 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  34.68 μs | 142.59 μs |  7.816 μs |  32.941 μs |  27.882 μs |  43.22 μs |  17.63 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  54.24 μs |  69.18 μs |  3.792 μs |  54.978 μs |  50.129 μs |  57.60 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.44 μs** | **269.27 μs** | **14.759 μs** |   **8.075 μs** |   **7.764 μs** |  **33.48 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 302.97 μs | 253.25 μs | 13.882 μs | 298.439 μs | 291.927 μs | 318.56 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 154.93 μs | 106.11 μs |  5.816 μs | 153.997 μs | 149.630 μs | 161.15 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  61.73 μs | 208.01 μs | 11.402 μs |  60.163 μs |  51.186 μs |  73.83 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 235.56 μs | 532.83 μs | 29.206 μs | 233.877 μs | 207.237 μs | 265.58 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  14.94 μs | 249.21 μs | 13.660 μs |   7.102 μs |   7.013 μs |  30.72 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  84.16 μs | 511.16 μs | 28.019 μs |  69.811 μs |  66.225 μs | 116.45 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 309.90 μs | 323.80 μs | 17.749 μs | 319.709 μs | 289.412 μs | 320.58 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.65 μs | 280.29 μs | 15.364 μs |   7.914 μs |   7.654 μs |  34.39 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 140.34 μs | 522.07 μs | 28.616 μs | 130.544 μs | 117.901 μs | 172.56 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 143.89 μs |  14.99 μs |  0.822 μs | 143.870 μs | 143.078 μs | 144.72 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  60.95 μs | 215.14 μs | 11.792 μs |  59.090 μs |  50.204 μs |  73.57 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 243.99 μs | 637.43 μs | 34.940 μs | 260.326 μs | 203.870 μs | 267.76 μs |  87.94 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.16 μs | 197.87 μs | 10.846 μs |   6.983 μs |   6.822 μs |  25.69 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  94.31 μs | 192.51 μs | 10.552 μs |  88.526 μs |  87.915 μs | 106.49 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 293.09 μs | 135.37 μs |  7.420 μs | 295.873 μs | 284.682 μs | 298.72 μs |  20.25 KB |
