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
| **ArrayReverse**           | **10**     | **100**    |  **15.88 μs** | **177.51 μs** |  **9.730 μs** |  **10.530 μs** |   **9.998 μs** |  **27.11 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  56.35 μs | 248.73 μs | 13.634 μs |  56.897 μs |  42.449 μs |  69.70 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  30.74 μs | 238.82 μs | 13.090 μs |  25.227 μs |  21.309 μs |  45.69 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.36 μs | 146.67 μs |  8.040 μs |  14.883 μs |  10.845 μs |  26.34 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.80 μs | 259.71 μs | 14.236 μs |  46.889 μs |  46.276 μs |  71.23 μs |  30.91 KB |
| StringSpan             | 10     | 100    |  11.93 μs | 162.78 μs |  8.922 μs |   6.863 μs |   6.692 μs |  22.23 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.16 μs | 156.93 μs |  8.602 μs |  33.578 μs |  29.149 μs |  45.76 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.60 μs** | **368.92 μs** | **20.222 μs** |  **13.390 μs** |  **12.469 μs** |  **47.95 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 125.37 μs | 273.84 μs | 15.010 μs | 117.119 μs | 116.298 μs | 142.70 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 141.88 μs |  12.67 μs |  0.694 μs | 141.657 μs | 141.325 μs | 142.66 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  71.52 μs | 132.04 μs |  7.237 μs |  73.233 μs |  63.575 μs |  77.74 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 231.29 μs | 524.53 μs | 28.751 μs | 226.645 μs | 205.145 μs | 262.08 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.36 μs | 214.57 μs | 11.761 μs |   7.774 μs |   7.373 μs |  27.94 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  76.26 μs | 233.52 μs | 12.800 μs |  69.100 μs |  68.649 μs |  91.04 μs |  37.94 KB |
