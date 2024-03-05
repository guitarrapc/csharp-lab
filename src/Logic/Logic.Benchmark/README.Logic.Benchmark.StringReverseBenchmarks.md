```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.39 μs** | **156.24 μs** |  **8.564 μs** |  **11.678 μs** |   **7.510 μs** |  **23.98 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.06 μs | 213.75 μs | 11.717 μs |  78.368 μs |  74.410 μs |  96.39 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  49.89 μs | 421.23 μs | 23.089 μs |  37.551 μs |  35.587 μs |  76.52 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.60 μs | 150.53 μs |  8.251 μs |  14.927 μs |  11.010 μs |  26.85 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.19 μs | 266.45 μs | 14.605 μs |  45.014 μs |  44.504 μs |  70.05 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.30 μs | 215.37 μs | 11.805 μs |   7.705 μs |   7.274 μs |  27.93 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.57 μs | 260.76 μs | 14.293 μs |  28.603 μs |  28.032 μs |  53.07 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.99 μs** | **352.58 μs** | **19.326 μs** |  **12.433 μs** |  **11.241 μs** |  **45.30 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 298.85 μs | 316.60 μs | 17.354 μs | 297.731 μs | 282.082 μs | 316.74 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 176.65 μs |  48.77 μs |  2.673 μs | 177.365 μs | 173.688 μs | 178.89 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  65.46 μs | 308.82 μs | 16.928 μs |  61.306 μs |  50.996 μs |  84.08 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.36 μs | 492.19 μs | 26.979 μs | 235.073 μs | 211.599 μs | 265.41 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  19.99 μs | 296.86 μs | 16.272 μs |  10.736 μs |  10.454 μs |  38.78 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.87 μs | 625.58 μs | 34.290 μs |  69.111 μs |  69.030 μs | 128.46 μs |  68.69 KB |
