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
| **ArrayReverse**           | **.NET 8.0** | **10**     | **100**    |  **13.16 μs** | **137.62 μs** |  **7.544 μs** |  **11.712 μs** |   **6.442 μs** |  **21.32 μs** |  **10.09 KB** |
| EnumerableReverse      | .NET 8.0 | 10     | 100    |  81.92 μs | 252.99 μs | 13.867 μs |  76.778 μs |  71.349 μs |  97.62 μs |  25.72 KB |
| RecursiveReverse       | .NET 8.0 | 10     | 100    |  43.97 μs | 302.66 μs | 16.590 μs |  37.591 μs |  31.510 μs |  62.80 μs |  33.53 KB |
| ReverseXor             | .NET 8.0 | 10     | 100    |  23.44 μs | 179.22 μs |  9.824 μs |  18.965 μs |  16.650 μs |  34.70 μs |  10.09 KB |
| StackReverse           | .NET 8.0 | 10     | 100    |  58.74 μs | 291.20 μs | 15.962 μs |  50.444 μs |  48.641 μs |  77.14 μs |  31.19 KB |
| StringSpan             | .NET 8.0 | 10     | 100    |  11.79 μs | 170.85 μs |  9.365 μs |   6.622 μs |   6.152 μs |  22.60 μs |   5.41 KB |
| StringExtensionReverse | .NET 8.0 | 10     | 100    |  52.19 μs | 520.45 μs | 28.528 μs |  39.254 μs |  32.431 μs |  84.90 μs |  28.84 KB |
| TextElementEnumerator  | .NET 8.0 | 10     | 100    |  65.99 μs | 196.46 μs | 10.769 μs |  62.066 μs |  57.727 μs |  78.17 μs |  10.09 KB |
| ArrayReverse           | .NET 9.0 | 10     | 100    |  11.31 μs | 156.23 μs |  8.564 μs |   6.447 μs |   6.277 μs |  21.19 μs |   9.81 KB |
| EnumerableReverse      | .NET 9.0 | 10     | 100    |  51.85 μs | 233.14 μs | 12.779 μs |  45.455 μs |  43.532 μs |  66.56 μs |  17.91 KB |
| RecursiveReverse       | .NET 9.0 | 10     | 100    |  31.56 μs | 262.34 μs | 14.380 μs |  26.294 μs |  20.563 μs |  47.84 μs |  33.53 KB |
| ReverseXor             | .NET 9.0 | 10     | 100    |  18.05 μs | 206.74 μs | 11.332 μs |  13.825 μs |   9.437 μs |  30.89 μs |  10.09 KB |
| StackReverse           | .NET 9.0 | 10     | 100    |  58.83 μs | 356.99 μs | 19.568 μs |  50.474 μs |  44.833 μs |  81.19 μs |  31.19 KB |
| StringSpan             | .NET 9.0 | 10     | 100    |  11.60 μs | 158.70 μs |  8.699 μs |   6.593 μs |   6.572 μs |  21.65 μs |   5.13 KB |
| StringExtensionReverse | .NET 9.0 | 10     | 100    |  36.92 μs | 197.70 μs | 10.837 μs |  32.992 μs |  28.594 μs |  49.17 μs |  17.91 KB |
| TextElementEnumerator  | .NET 9.0 | 10     | 100    |  56.87 μs |  76.42 μs |  4.189 μs |  55.924 μs |  53.239 μs |  61.45 μs |   9.81 KB |
| **ArrayReverse**           | **.NET 8.0** | **64**     | **100**    |  **17.52 μs** | **258.19 μs** | **14.152 μs** |   **9.517 μs** |   **9.187 μs** |  **33.86 μs** |  **30.41 KB** |
| EnumerableReverse      | .NET 8.0 | 64     | 100    | 302.97 μs | 327.38 μs | 17.945 μs | 297.913 μs | 288.094 μs | 322.90 μs |  59.31 KB |
| RecursiveReverse       | .NET 8.0 | 64     | 100    | 149.08 μs |  15.97 μs |  0.875 μs | 148.819 μs | 148.358 μs | 150.05 μs | 560.88 KB |
| ReverseXor             | .NET 8.0 | 64     | 100    |  63.25 μs | 228.89 μs | 12.546 μs |  65.272 μs |  49.813 μs |  74.66 μs |  30.41 KB |
| StackReverse           | .NET 8.0 | 64     | 100    | 256.12 μs | 595.49 μs | 32.641 μs | 271.467 μs | 218.629 μs | 278.25 μs |  88.22 KB |
| StringSpan             | .NET 8.0 | 64     | 100    |  19.34 μs | 258.51 μs | 14.170 μs |  12.845 μs |   9.588 μs |  35.60 μs |  15.56 KB |
| StringExtensionReverse | .NET 8.0 | 64     | 100    |  86.38 μs | 526.45 μs | 28.856 μs |  69.942 μs |  69.490 μs | 119.69 μs |  68.69 KB |
| TextElementEnumerator  | .NET 8.0 | 64     | 100    | 298.16 μs |  17.30 μs |  0.948 μs | 298.518 μs | 297.086 μs | 298.88 μs |  20.25 KB |
| ArrayReverse           | .NET 9.0 | 64     | 100    |  22.20 μs | 364.27 μs | 19.967 μs |  11.091 μs |  10.249 μs |  45.25 μs |  30.41 KB |
| EnumerableReverse      | .NET 9.0 | 64     | 100    | 137.69 μs | 193.84 μs | 10.625 μs | 138.935 μs | 126.492 μs | 147.63 μs |  37.94 KB |
| RecursiveReverse       | .NET 9.0 | 64     | 100    | 154.98 μs | 243.87 μs | 13.367 μs | 149.059 μs | 145.601 μs | 170.29 μs | 560.88 KB |
| ReverseXor             | .NET 9.0 | 64     | 100    |  64.59 μs | 311.20 μs | 17.058 μs |  59.340 μs |  50.774 μs |  83.66 μs |  30.13 KB |
| StackReverse           | .NET 9.0 | 64     | 100    | 230.53 μs | 570.49 μs | 31.271 μs | 226.232 μs | 201.637 μs | 263.73 μs |  88.22 KB |
| StringSpan             | .NET 9.0 | 64     | 100    |  17.61 μs | 271.72 μs | 14.894 μs |   9.838 μs |   8.214 μs |  34.79 μs |  15.56 KB |
| StringExtensionReverse | .NET 9.0 | 64     | 100    |  92.31 μs | 342.59 μs | 18.779 μs |  82.469 μs |  80.505 μs | 113.97 μs |  38.22 KB |
| TextElementEnumerator  | .NET 9.0 | 64     | 100    | 337.96 μs | 969.20 μs | 53.125 μs | 338.252 μs | 284.683 μs | 390.93 μs |  20.25 KB |
