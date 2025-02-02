```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.06 μs** | **177.30 μs** |  **9.719 μs** |  **10.810 μs** |  **10.089 μs** |  **27.27 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  45.75 μs | 119.33 μs |  6.541 μs |  42.742 μs |  41.248 μs |  53.25 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  32.20 μs | 259.49 μs | 14.223 μs |  26.169 μs |  21.981 μs |  48.44 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.08 μs | 153.77 μs |  8.429 μs |  14.136 μs |  10.510 μs |  26.58 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.07 μs | 240.13 μs | 13.162 μs |  44.730 μs |  44.209 μs |  67.26 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  20.38 μs | 214.02 μs | 11.731 μs |  27.091 μs |   6.832 μs |  27.21 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  38.16 μs | 209.94 μs | 11.508 μs |  34.114 μs |  29.226 μs |  51.15 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **16.60 μs** | **267.89 μs** | **14.684 μs** |   **8.186 μs** |   **8.055 μs** |  **33.55 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 139.88 μs | 271.37 μs | 14.874 μs | 147.881 μs | 122.713 μs | 149.03 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 160.21 μs | 260.33 μs | 14.270 μs | 157.690 μs | 147.370 μs | 175.57 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.33 μs | 214.70 μs | 11.769 μs |  60.113 μs |  50.215 μs |  73.66 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 229.22 μs | 509.69 μs | 27.938 μs | 224.269 μs | 204.091 μs | 259.30 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.90 μs | 217.31 μs | 11.912 μs |   8.241 μs |   7.801 μs |  28.65 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  80.19 μs | 395.50 μs | 21.679 μs |  68.594 μs |  66.781 μs | 105.20 μs |  38.22 KB |
