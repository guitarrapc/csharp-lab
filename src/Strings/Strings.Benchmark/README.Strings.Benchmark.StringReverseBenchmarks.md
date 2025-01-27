```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.78 μs** |   **179.05 μs** |  **9.814 μs** |   **7.253 μs** |   **6.983 μs** |  **24.11 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  57.88 μs |   141.20 μs |  7.739 μs |  54.602 μs |  52.327 μs |  66.72 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  38.42 μs |   140.61 μs |  7.707 μs |  37.806 μs |  31.034 μs |  46.41 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.23 μs |   179.63 μs |  9.846 μs |  14.698 μs |  14.398 μs |  31.60 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.02 μs |   286.63 μs | 15.711 μs |  45.580 μs |  44.337 μs |  72.15 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  11.90 μs |   157.99 μs |  8.660 μs |   6.922 μs |   6.882 μs |  21.90 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.31 μs |    99.55 μs |  5.457 μs |  33.984 μs |  32.411 μs |  42.55 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.43 μs** |   **267.66 μs** | **14.671 μs** |   **9.453 μs** |   **8.470 μs** |  **34.36 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 134.94 μs |   598.31 μs | 32.796 μs | 116.727 μs | 115.295 μs | 172.80 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 143.64 μs |    19.43 μs |  1.065 μs | 143.968 μs | 142.454 μs | 144.51 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  60.85 μs |   211.01 μs | 11.566 μs |  59.742 μs |  49.883 μs |  72.94 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 256.50 μs | 1,057.69 μs | 57.975 μs | 250.836 μs | 201.565 μs | 317.10 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.63 μs |   240.23 μs | 13.168 μs |  10.099 μs |   9.950 μs |  32.83 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  81.03 μs |   274.30 μs | 15.035 μs |  79.213 μs |  66.980 μs |  96.89 μs |  38.22 KB |
