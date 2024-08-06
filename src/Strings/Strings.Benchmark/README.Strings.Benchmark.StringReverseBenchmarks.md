```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.99 μs** | **167.23 μs** |  **9.166 μs** |   **7.876 μs** |   **7.525 μs** |  **23.57 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  84.34 μs | 223.01 μs | 12.224 μs |  80.060 μs |  74.840 μs |  98.13 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.63 μs | 235.08 μs | 12.886 μs |  34.225 μs |  26.791 μs |  51.88 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.75 μs | 157.45 μs |  8.631 μs |  14.587 μs |  11.140 μs |  27.51 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.74 μs | 302.98 μs | 16.607 μs |  43.327 μs |  42.986 μs |  71.92 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.54 μs | 189.26 μs | 10.374 μs |   7.815 μs |   7.295 μs |  25.52 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.23 μs | 244.08 μs | 13.379 μs |  29.887 μs |  29.125 μs |  52.67 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.36 μs** | **363.45 μs** | **19.922 μs** |  **12.033 μs** |  **11.692 μs** |  **46.37 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 333.01 μs | 732.51 μs | 40.151 μs | 319.721 μs | 301.186 μs | 378.12 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.10 μs |  14.27 μs |  0.782 μs | 151.694 μs | 151.614 μs | 153.01 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.31 μs | 217.88 μs | 11.943 μs |  60.047 μs |  51.653 μs |  75.22 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 394.84 μs | 666.17 μs | 36.515 μs | 402.625 μs | 355.057 μs | 426.83 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.78 μs | 209.26 μs | 11.470 μs |   8.160 μs |   8.160 μs |  28.03 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  99.14 μs | 606.97 μs | 33.270 μs |  81.063 μs |  78.829 μs | 137.54 μs |  68.69 KB |
