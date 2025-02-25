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
| Method                 | Runtime  | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.07 μs** |   **144.20 μs** |  **7.904 μs** |  **10.645 μs** |   **6.668 μs** |  **21.91 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  83.01 μs |   262.49 μs | 14.388 μs |  78.354 μs |  71.532 μs |  99.15 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.88 μs |   247.39 μs | 13.561 μs |  26.449 μs |  21.881 μs |  47.32 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.74 μs |   154.24 μs |  8.455 μs |  14.085 μs |   9.938 μs |  26.21 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  53.08 μs |   224.69 μs | 12.316 μs |  46.615 μs |  45.344 μs |  67.28 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.61 μs |   161.24 μs |  8.838 μs |   6.513 μs |   6.493 μs |  21.81 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  34.85 μs |   237.50 μs | 13.018 μs |  27.512 μs |  27.161 μs |  49.88 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  62.62 μs |   247.19 μs | 13.550 μs |  57.791 μs |  52.141 μs |  77.92 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.73 μs |   190.61 μs | 10.448 μs |   9.197 μs |   6.311 μs |  25.68 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  48.35 μs |   162.23 μs |  8.892 μs |  52.758 μs |  38.111 μs |  54.17 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.29 μs |   239.06 μs | 13.104 μs |  25.306 μs |  20.407 μs |  45.15 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.40 μs |   141.09 μs |  7.734 μs |  13.976 μs |  10.170 μs |  25.06 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  53.03 μs |   257.08 μs | 14.091 μs |  45.433 μs |  44.362 μs |  69.29 μs |  30.91 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.39 μs |   158.83 μs |  8.706 μs |   6.482 μs |   6.242 μs |  21.44 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  35.83 μs |   166.24 μs |  9.112 μs |  33.081 μs |  28.402 μs |  45.99 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  54.11 μs |    72.57 μs |  3.978 μs |  54.035 μs |  50.167 μs |  58.12 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **15.97 μs** |   **259.21 μs** | **14.208 μs** |   **8.006 μs** |   **7.524 μs** |  **32.37 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 306.67 μs |   215.34 μs | 11.803 μs | 308.168 μs | 294.183 μs | 317.65 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 156.84 μs |   119.02 μs |  6.524 μs | 160.125 μs | 149.325 μs | 161.07 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  65.71 μs |   337.54 μs | 18.502 μs |  60.056 μs |  50.688 μs |  86.37 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 246.07 μs |   541.25 μs | 29.668 μs | 254.089 μs | 213.213 μs | 270.90 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  14.81 μs |   189.09 μs | 10.365 μs |  10.741 μs |   7.093 μs |  26.59 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  82.23 μs |   529.58 μs | 29.028 μs |  65.500 μs |  65.450 μs | 115.75 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 345.02 μs |   969.87 μs | 53.162 μs | 320.691 μs | 308.368 μs | 405.99 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.14 μs |   254.66 μs | 13.959 μs |   8.431 μs |   7.739 μs |  32.25 μs |  30.13 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 144.37 μs |   445.06 μs | 24.395 μs | 155.778 μs | 116.365 μs | 160.98 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 144.23 μs |    11.18 μs |  0.613 μs | 144.091 μs | 143.701 μs | 144.90 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  67.92 μs |   147.64 μs |  8.093 μs |  69.699 μs |  59.089 μs |  74.98 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 244.10 μs |   332.95 μs | 18.250 μs | 242.878 μs | 226.498 μs | 262.94 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  14.23 μs |   187.80 μs | 10.294 μs |  10.019 μs |   6.703 μs |  25.96 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    | 106.76 μs |   294.66 μs | 16.152 μs | 108.250 μs |  89.916 μs | 122.12 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 351.55 μs | 1,021.02 μs | 55.966 μs | 344.675 μs | 299.341 μs | 410.64 μs |  20.25 KB |
