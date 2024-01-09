```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.63 μs** | **199.32 μs** | **10.925 μs** |  **11.793 μs** |  **10.870 μs** |  **30.24 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  71.99 μs | 153.63 μs |  8.421 μs |  69.481 μs |  65.113 μs |  81.38 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  43.66 μs | 354.48 μs | 19.430 μs |  38.727 μs |  27.165 μs |  65.08 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  19.15 μs | 194.86 μs | 10.681 μs |  14.908 μs |  11.240 μs |  31.30 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.47 μs | 269.45 μs | 14.770 μs |  46.231 μs |  45.651 μs |  71.52 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.69 μs | 173.30 μs |  9.499 μs |   7.344 μs |   7.064 μs |  23.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  38.01 μs | 284.09 μs | 15.572 μs |  29.705 μs |  28.353 μs |  55.98 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.58 μs** | **263.59 μs** | **14.448 μs** |   **9.437 μs** |   **9.046 μs** |  **34.26 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 310.65 μs | 319.46 μs | 17.511 μs | 309.725 μs | 293.615 μs | 328.60 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 183.40 μs | 134.04 μs |  7.347 μs | 183.132 μs | 176.190 μs | 190.88 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  67.08 μs | 221.93 μs | 12.165 μs |  70.648 μs |  53.536 μs |  77.07 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 245.47 μs | 765.62 μs | 41.966 μs | 233.662 μs | 210.669 μs | 292.07 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.04 μs | 209.89 μs | 11.505 μs |   8.851 μs |   7.960 μs |  28.32 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.93 μs | 518.23 μs | 28.406 μs |  76.578 μs |  68.793 μs | 121.42 μs |  68.69 KB |
