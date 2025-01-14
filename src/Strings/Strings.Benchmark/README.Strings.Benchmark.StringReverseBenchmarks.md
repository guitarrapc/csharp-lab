```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **11.86 μs** | **155.23 μs** |  **8.509 μs** |   **6.993 μs** |   **6.893 μs** |  **21.68 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  46.15 μs | 122.58 μs |  6.719 μs |  43.136 μs |  41.462 μs |  53.85 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  32.27 μs | 252.88 μs | 13.861 μs |  27.190 μs |  21.670 μs |  47.96 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.06 μs | 150.56 μs |  8.252 μs |  14.378 μs |  10.481 μs |  26.32 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.95 μs | 218.71 μs | 11.988 μs |  49.078 μs |  47.032 μs |  68.74 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.31 μs | 193.38 μs | 10.600 μs |   9.072 μs |   7.359 μs |  26.51 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.90 μs | 160.47 μs |  8.796 μs |  32.747 μs |  29.120 μs |  45.84 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.71 μs** | **243.33 μs** | **13.338 μs** |  **11.522 μs** |   **8.597 μs** |  **33.02 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 134.05 μs | 263.60 μs | 14.449 μs | 140.912 μs | 117.448 μs | 143.79 μs |  37.94 KB |
| RecursiveReverse       | 64     | 100    | 151.54 μs | 144.06 μs |  7.896 μs | 147.054 μs | 146.914 μs | 160.66 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  66.50 μs | 358.96 μs | 19.676 μs |  59.670 μs |  51.155 μs |  88.69 μs |  30.08 KB |
| StackReverse           | 64     | 100    | 254.42 μs | 694.26 μs | 38.055 μs | 249.706 μs | 218.938 μs | 294.61 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  13.85 μs | 199.86 μs | 10.955 μs |   7.563 μs |   7.484 μs |  26.50 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  82.73 μs | 228.80 μs | 12.541 μs |  81.611 μs |  70.791 μs |  95.80 μs |  37.94 KB |
