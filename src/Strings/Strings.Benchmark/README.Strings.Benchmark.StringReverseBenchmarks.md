```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **22.22 μs** | **398.460 μs** | **21.841 μs** |  **10.986 μs** |   **8.290 μs** |  **47.40 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  99.65 μs | 320.958 μs | 17.593 μs | 101.702 μs |  81.124 μs | 116.13 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.16 μs | 182.152 μs |  9.984 μs |  34.039 μs |  27.406 μs |  47.03 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.98 μs | 191.387 μs | 10.491 μs |  15.439 μs |  14.427 μs |  33.08 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.82 μs | 293.516 μs | 16.089 μs |  53.646 μs |  51.462 μs |  80.36 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.71 μs | 150.685 μs |  8.260 μs |   8.136 μs |   7.745 μs |  22.24 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  51.57 μs | 549.353 μs | 30.112 μs |  41.790 μs |  27.572 μs |  85.36 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **21.79 μs** | **262.130 μs** | **14.368 μs** |  **15.469 μs** |  **11.661 μs** |  **38.23 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 310.18 μs | 406.738 μs | 22.295 μs | 316.684 μs | 285.354 μs | 328.50 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.08 μs |   8.279 μs |  0.454 μs | 152.979 μs | 152.678 μs | 153.57 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.02 μs | 205.835 μs | 11.283 μs |  60.499 μs |  51.574 μs |  73.98 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 265.34 μs | 372.008 μs | 20.391 μs | 256.304 μs | 251.024 μs | 288.69 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.67 μs | 241.660 μs | 13.246 μs |  11.292 μs |  10.761 μs |  33.97 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.68 μs | 522.373 μs | 28.633 μs |  69.721 μs |  68.579 μs | 118.73 μs |  68.69 KB |
