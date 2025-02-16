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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **14.06 μs** | **164.74 μs** |  **9.030 μs** |  **11.331 μs** |   **6.702 μs** |  **24.13 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  80.07 μs | 244.91 μs | 13.424 μs |  87.618 μs |  64.575 μs |  88.03 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  36.66 μs | 426.92 μs | 23.401 μs |  25.216 μs |  21.179 μs |  63.58 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.23 μs | 145.59 μs |  7.980 μs |  13.726 μs |   9.809 μs |  25.17 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  51.99 μs | 251.10 μs | 13.764 μs |  44.955 μs |  43.161 μs |  67.85 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  16.93 μs | 243.66 μs | 13.356 μs |   9.528 μs |   8.916 μs |  32.35 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.05 μs | 247.11 μs | 13.545 μs |  27.362 μs |  27.090 μs |  50.69 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  57.75 μs |  90.12 μs |  4.940 μs |  60.358 μs |  52.053 μs |  60.84 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  12.66 μs | 138.21 μs |  7.576 μs |  10.700 μs |   6.252 μs |  21.02 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  44.95 μs | 139.50 μs |  7.646 μs |  42.961 μs |  38.502 μs |  53.40 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  30.31 μs | 227.80 μs | 12.486 μs |  26.610 μs |  20.097 μs |  44.23 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  16.43 μs | 140.12 μs |  7.680 μs |  14.798 μs |   9.699 μs |  24.80 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  49.50 μs | 277.28 μs | 15.199 μs |  41.417 μs |  40.054 μs |  67.03 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  18.02 μs | 188.59 μs | 10.337 μs |  21.941 μs |   6.292 μs |  25.82 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  54.82 μs | 252.46 μs | 13.838 μs |  57.977 μs |  39.674 μs |  66.80 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  70.50 μs | 364.50 μs | 19.979 μs |  59.060 μs |  58.880 μs |  93.58 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **16.37 μs** | **261.76 μs** | **14.348 μs** |   **8.606 μs** |   **7.583 μs** |  **32.93 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 303.25 μs | 258.00 μs | 14.142 μs | 306.159 μs | 287.877 μs | 315.71 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 151.60 μs |  17.05 μs |  0.935 μs | 151.883 μs | 150.560 μs | 152.36 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  74.60 μs | 272.00 μs | 14.909 μs |  68.437 μs |  63.758 μs |  91.60 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 240.41 μs | 522.52 μs | 28.641 μs | 243.413 μs | 210.392 μs | 267.44 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  13.22 μs | 197.06 μs | 10.802 μs |   7.214 μs |   6.753 μs |  25.69 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  94.86 μs | 562.62 μs | 30.839 μs |  77.163 μs |  76.953 μs | 130.47 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 293.96 μs | 132.49 μs |  7.262 μs | 297.744 μs | 285.591 μs | 298.56 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  21.30 μs | 331.65 μs | 18.179 μs |  11.039 μs |  10.570 μs |  42.29 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 130.18 μs | 305.80 μs | 16.762 μs | 137.426 μs | 111.017 μs | 142.10 μs |  38.22 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 143.77 μs |  21.26 μs |  1.165 μs | 143.617 μs | 142.695 μs | 145.01 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  62.89 μs | 261.92 μs | 14.357 μs |  59.773 μs |  50.344 μs |  78.55 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 230.47 μs | 534.76 μs | 29.312 μs | 227.935 μs | 202.507 μs | 260.97 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.17 μs | 195.64 μs | 10.724 μs |   7.034 μs |   6.934 μs |  25.56 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  94.25 μs | 389.83 μs | 21.368 μs |  88.665 μs |  76.222 μs | 117.85 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 308.42 μs | 217.27 μs | 11.909 μs | 307.958 μs | 296.747 μs | 320.55 μs |  20.25 KB |
