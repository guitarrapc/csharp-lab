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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.22 μs** | **176.51 μs** |  **9.675 μs** |  **10.740 μs** |  **10.529 μs** |  **27.39 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  76.80 μs | 370.64 μs | 20.316 μs |  67.286 μs |  62.987 μs | 100.13 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.35 μs | 248.69 μs | 13.631 μs |  25.918 μs |  21.269 μs |  46.86 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  22.19 μs | 323.60 μs | 17.738 μs |  14.057 μs |   9.969 μs |  42.53 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  52.34 μs | 250.79 μs | 13.747 μs |  44.463 μs |  44.353 μs |  68.22 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.84 μs | 161.77 μs |  8.867 μs |   6.823 μs |   6.622 μs |  22.08 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  36.02 μs | 297.07 μs | 16.283 μs |  26.906 μs |  26.334 μs |  54.82 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  57.90 μs |  46.85 μs |  2.568 μs |  57.028 μs |  55.886 μs |  60.79 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.78 μs | 135.24 μs |  7.413 μs |  11.071 μs |   6.371 μs |  20.90 μs |   9.81 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  53.03 μs | 256.24 μs | 14.045 μs |  56.075 μs |  37.711 μs |  65.30 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.58 μs | 262.21 μs | 14.373 μs |  24.907 μs |  19.917 μs |  46.93 μs |  33.25 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.70 μs | 158.55 μs |  8.691 μs |  13.630 μs |   9.954 μs |  26.50 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  49.14 μs | 263.29 μs | 14.432 μs |  41.307 μs |  40.316 μs |  65.79 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.39 μs | 155.50 μs |  8.523 μs |   6.522 μs |   6.412 μs |  21.23 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  44.43 μs | 247.46 μs | 13.564 μs |  40.416 μs |  33.333 μs |  59.55 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  53.70 μs |  83.90 μs |  4.599 μs |  53.641 μs |  49.133 μs |  58.33 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.33 μs** | **268.59 μs** | **14.722 μs** |   **7.989 μs** |   **7.670 μs** |  **33.33 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 299.02 μs | 268.61 μs | 14.724 μs | 297.529 μs | 285.096 μs | 314.43 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 149.11 μs |  12.81 μs |  0.702 μs | 149.460 μs | 148.297 μs | 149.56 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  62.37 μs | 244.91 μs | 13.425 μs |  59.812 μs |  50.414 μs |  76.89 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 259.87 μs | 728.72 μs | 39.944 μs | 261.781 μs | 219.011 μs | 298.83 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.25 μs | 254.66 μs | 13.959 μs |   7.404 μs |   6.984 μs |  31.37 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  86.76 μs | 532.95 μs | 29.213 μs |  74.409 μs |  65.745 μs | 120.12 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 291.39 μs | 150.51 μs |  8.250 μs | 295.243 μs | 281.918 μs | 297.01 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  15.97 μs | 258.23 μs | 14.154 μs |   7.895 μs |   7.694 μs |  32.31 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 129.55 μs | 321.81 μs | 17.640 μs | 124.819 μs | 114.760 μs | 149.07 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 150.79 μs | 192.94 μs | 10.576 μs | 145.333 μs | 144.050 μs | 162.98 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  60.86 μs | 210.41 μs | 11.533 μs |  59.381 μs |  50.133 μs |  73.06 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 229.55 μs | 531.52 μs | 29.134 μs | 227.056 μs | 201.738 μs | 259.85 μs |  87.94 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.38 μs | 194.01 μs | 10.635 μs |   7.495 μs |   6.994 μs |  25.66 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  89.39 μs | 330.23 μs | 18.101 μs |  80.371 μs |  77.565 μs | 110.23 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 310.47 μs |  35.22 μs |  1.930 μs | 309.982 μs | 308.830 μs | 312.60 μs |  19.97 KB |
