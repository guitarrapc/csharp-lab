```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.80 μs** | **255.89 μs** | **14.026 μs** |  **11.082 μs** |  **10.320 μs** |  **34.99 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.15 μs | 196.94 μs | 10.795 μs |  79.158 μs |  73.167 μs |  94.13 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.62 μs | 343.71 μs | 18.840 μs |  28.633 μs |  26.880 μs |  60.35 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  24.66 μs | 184.54 μs | 10.116 μs |  22.392 μs |  15.870 μs |  35.72 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.07 μs | 255.33 μs | 13.996 μs |  54.823 μs |  45.976 μs |  73.40 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.65 μs | 157.07 μs |  8.610 μs |   7.736 μs |   7.625 μs |  22.59 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.54 μs | 300.20 μs | 16.455 μs |  27.421 μs |  26.660 μs |  55.53 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **20.26 μs** | **358.06 μs** | **19.626 μs** |   **9.037 μs** |   **8.816 μs** |  **42.92 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.19 μs | 271.57 μs | 14.886 μs | 298.859 μs | 287.608 μs | 317.10 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 193.90 μs | 376.39 μs | 20.631 μs | 191.758 μs | 174.417 μs | 215.51 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  73.58 μs | 310.29 μs | 17.008 μs |  68.909 μs |  59.392 μs |  92.43 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 245.61 μs | 563.59 μs | 30.892 μs | 241.512 μs | 216.976 μs | 278.35 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.28 μs | 221.63 μs | 12.148 μs |   8.370 μs |   8.169 μs |  29.31 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  97.68 μs | 558.19 μs | 30.596 μs |  81.202 μs |  78.848 μs | 132.98 μs |  68.69 KB |
