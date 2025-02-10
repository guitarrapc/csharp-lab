```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **22.59 μs** | **188.445 μs** | **10.329 μs** |  **27.962 μs** |  **10.681 μs** |  **29.12 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  60.14 μs | 153.054 μs |  8.389 μs |  57.006 μs |  53.761 μs |  69.64 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  30.86 μs | 235.003 μs | 12.881 μs |  25.537 μs |  21.500 μs |  45.55 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.41 μs | 156.299 μs |  8.567 μs |  14.607 μs |  10.600 μs |  27.03 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.38 μs | 237.063 μs | 12.994 μs |  50.474 μs |  42.078 μs |  67.58 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.07 μs | 161.098 μs |  8.830 μs |   7.079 μs |   6.867 μs |  22.27 μs |   5.13 KB |
| StringExtensionReverse | 10     | 100    |  44.60 μs | 420.331 μs | 23.040 μs |  33.423 μs |  29.275 μs |  71.09 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.11 μs** | **269.236 μs** | **14.758 μs** |   **8.837 μs** |   **8.336 μs** |  **34.14 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 135.85 μs | 265.776 μs | 14.568 μs | 127.763 μs | 127.121 μs | 152.67 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 141.36 μs |   4.753 μs |  0.261 μs | 141.443 μs | 141.071 μs | 141.57 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  80.63 μs | 649.782 μs | 35.617 μs |  71.513 μs |  50.463 μs | 119.92 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.37 μs | 545.035 μs | 29.875 μs | 242.821 μs | 205.141 μs | 264.14 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.32 μs | 265.231 μs | 14.538 μs |  10.280 μs |   7.635 μs |  34.03 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  83.68 μs | 261.873 μs | 14.354 μs |  83.995 μs |  69.168 μs |  97.87 μs |  38.22 KB |
