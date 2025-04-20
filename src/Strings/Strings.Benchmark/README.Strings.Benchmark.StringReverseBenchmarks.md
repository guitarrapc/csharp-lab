```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

InvocationCount=1  IterationCount=3  LaunchCount=1  
UnrollFactor=1  WarmupCount=3  

```
| Method                 | Runtime  | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |--------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **16.55 μs** | **151.88 μs** |  **8.325 μs** |  **14.767 μs** |   **9.267 μs** |  **25.63 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  72.28 μs | 170.82 μs |  9.363 μs |  68.188 μs |  65.663 μs |  83.00 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  31.96 μs | 263.16 μs | 14.425 μs |  25.337 μs |  22.041 μs |  48.51 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  22.79 μs | 212.77 μs | 11.663 μs |  24.767 μs |  10.260 μs |  33.33 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  52.31 μs | 267.62 μs | 14.669 μs |  43.852 μs |  43.831 μs |  69.25 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.29 μs | 150.16 μs |  8.231 μs |   6.543 μs |   6.543 μs |  20.80 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.61 μs | 261.34 μs | 14.325 μs |  27.651 μs |  27.030 μs |  52.15 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  55.27 μs |  79.34 μs |  4.349 μs |  56.325 μs |  50.494 μs |  59.00 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  14.60 μs | 205.51 μs | 11.265 μs |   9.818 μs |   6.522 μs |  27.47 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  58.82 μs | 404.94 μs | 22.196 μs |  50.553 μs |  41.948 μs |  83.97 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  31.53 μs | 276.44 μs | 15.153 μs |  25.427 μs |  20.378 μs |  48.78 μs |  33.25 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  20.27 μs | 190.93 μs | 10.465 μs |  14.818 μs |  13.666 μs |  32.34 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  60.95 μs | 376.23 μs | 20.623 μs |  53.205 μs |  45.319 μs |  84.32 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  12.10 μs | 179.66 μs |  9.848 μs |   6.513 μs |   6.322 μs |  23.47 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  39.48 μs | 223.56 μs | 12.254 μs |  35.261 μs |  29.890 μs |  53.28 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  58.50 μs | 216.43 μs | 11.863 μs |  53.640 μs |  49.842 μs |  72.02 μs |   9.81 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.20 μs** | **265.99 μs** | **14.580 μs** |   **8.070 μs** |   **7.489 μs** |  **33.03 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 302.80 μs | 257.88 μs | 14.135 μs | 301.251 μs | 289.510 μs | 317.65 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 155.14 μs |  63.90 μs |  3.502 μs | 155.228 μs | 151.593 μs | 158.60 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  67.15 μs | 362.84 μs | 19.888 μs |  60.001 μs |  51.826 μs |  89.63 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 239.23 μs | 494.45 μs | 27.103 μs | 236.576 μs | 213.553 μs | 267.56 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  18.86 μs | 319.17 μs | 17.495 μs |  10.290 μs |   7.294 μs |  38.98 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    | 101.86 μs | 607.07 μs | 33.276 μs |  85.468 μs |  79.958 μs | 140.15 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 296.02 μs | 209.41 μs | 11.478 μs | 298.276 μs | 283.579 μs | 306.20 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  16.24 μs | 264.57 μs | 14.502 μs |   8.021 μs |   7.720 μs |  32.99 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 129.56 μs | 233.16 μs | 12.780 μs | 132.877 μs | 115.445 μs | 140.35 μs |  37.94 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 149.92 μs | 123.03 μs |  6.744 μs | 146.207 μs | 145.856 μs | 157.71 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  69.64 μs | 465.41 μs | 25.511 μs |  59.681 μs |  50.605 μs |  98.62 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 233.87 μs | 526.38 μs | 28.853 μs | 233.044 μs | 205.442 μs | 263.13 μs |  87.94 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  19.45 μs | 392.79 μs | 21.530 μs |   7.274 μs |   6.774 μs |  44.31 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  77.00 μs | 272.95 μs | 14.961 μs |  68.376 μs |  68.347 μs |  94.28 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 306.37 μs | 110.46 μs |  6.055 μs | 307.693 μs | 299.769 μs | 311.66 μs |  19.59 KB |
