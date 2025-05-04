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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.71 μs** | **131.76 μs** |  **7.222 μs** |   **9.748 μs** |   **9.328 μs** |  **22.04 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  74.15 μs | 147.13 μs |  8.064 μs |  71.014 μs |  68.118 μs |  83.31 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  42.55 μs | 260.48 μs | 14.278 μs |  37.586 μs |  31.414 μs |  58.65 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  16.64 μs | 152.22 μs |  8.343 μs |  13.792 μs |  10.094 μs |  26.04 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  53.17 μs | 237.58 μs | 13.022 μs |  46.187 μs |  45.135 μs |  68.20 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.45 μs | 160.09 μs |  8.775 μs |   6.402 μs |   6.363 μs |  21.58 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  35.64 μs | 272.31 μs | 14.926 μs |  27.602 μs |  26.450 μs |  52.86 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  66.72 μs | 106.79 μs |  5.854 μs |  66.905 μs |  60.773 μs |  72.48 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  13.30 μs | 123.68 μs |  6.779 μs |  11.071 μs |   7.924 μs |  20.92 μs |  10.09 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  52.65 μs | 143.76 μs |  7.880 μs |  52.558 μs |  44.814 μs |  60.57 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  31.16 μs | 268.30 μs | 14.707 μs |  25.138 μs |  20.419 μs |  47.92 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  17.36 μs | 183.84 μs | 10.077 μs |  13.455 μs |   9.818 μs |  28.80 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  53.78 μs | 295.36 μs | 16.190 μs |  44.734 μs |  44.142 μs |  72.47 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  16.78 μs | 301.56 μs | 16.530 μs |   7.875 μs |   6.603 μs |  35.85 μs |   5.41 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  36.75 μs | 149.90 μs |  8.217 μs |  33.112 μs |  30.979 μs |  46.16 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  56.18 μs |  74.01 μs |  4.057 μs |  56.176 μs |  52.119 μs |  60.23 μs |  10.09 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **23.14 μs** | **357.86 μs** | **19.615 μs** |  **11.993 μs** |  **11.632 μs** |  **45.79 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 304.98 μs | 260.09 μs | 14.256 μs | 304.230 μs | 291.116 μs | 319.60 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 149.86 μs |  32.46 μs |  1.779 μs | 148.839 μs | 148.829 μs | 151.92 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  75.31 μs | 274.83 μs | 15.064 μs |  74.389 μs |  60.734 μs |  90.82 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 252.90 μs | 801.35 μs | 43.925 μs | 255.268 μs | 207.839 μs | 295.59 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  15.02 μs | 237.08 μs | 12.995 μs |   7.620 μs |   7.409 μs |  30.02 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  87.84 μs | 476.43 μs | 26.115 μs |  76.212 μs |  69.560 μs | 117.75 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 339.24 μs | 518.84 μs | 28.440 μs | 334.929 μs | 313.208 μs | 369.59 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  17.18 μs | 298.48 μs | 16.361 μs |   7.766 μs |   7.695 μs |  36.07 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 124.02 μs | 229.64 μs | 12.587 μs | 118.351 μs | 115.255 μs | 138.44 μs |  37.94 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 157.82 μs | 371.89 μs | 20.384 μs | 147.631 μs | 144.547 μs | 181.29 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  62.52 μs | 245.69 μs | 13.467 μs |  59.160 μs |  51.045 μs |  77.34 μs |  30.41 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 257.64 μs | 569.76 μs | 31.231 μs | 264.866 μs | 223.429 μs | 284.62 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  13.99 μs | 223.31 μs | 12.240 μs |   7.013 μs |   6.832 μs |  28.12 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  78.55 μs | 343.77 μs | 18.843 μs |  68.749 μs |  66.635 μs | 100.28 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 313.48 μs | 610.73 μs | 33.476 μs | 301.705 μs | 287.488 μs | 351.26 μs |  20.25 KB |
