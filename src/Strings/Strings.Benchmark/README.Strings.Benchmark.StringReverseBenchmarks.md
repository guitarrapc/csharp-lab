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
| **ArrayReverse**           | **10**     | **100**    |  **13.82 μs** | **146.59 μs** |  **8.035 μs** |  **11.391 μs** |   **7.284 μs** |  **22.79 μs** |   **9.44 KB** |
| EnumerableReverse      | 10     | 100    |  47.97 μs | 162.93 μs |  8.931 μs |  44.062 μs |  41.658 μs |  58.19 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  32.14 μs | 285.44 μs | 15.646 μs |  25.357 μs |  21.030 μs |  50.03 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.07 μs | 149.75 μs |  8.208 μs |  14.371 μs |  10.544 μs |  26.28 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.03 μs | 235.60 μs | 12.914 μs |  45.635 μs |  43.561 μs |  66.89 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.62 μs | 247.42 μs | 13.562 μs |   8.988 μs |   8.597 μs |  32.28 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.71 μs | 128.81 μs |  7.061 μs |  36.327 μs |  29.845 μs |  43.95 μs |  17.63 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.30 μs** | **249.34 μs** | **13.667 μs** |  **30.131 μs** |   **8.681 μs** |  **34.08 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 138.78 μs | 358.37 μs | 19.643 μs | 133.964 μs | 121.993 μs | 160.38 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 159.02 μs | 198.72 μs | 10.893 μs | 165.167 μs | 146.442 μs | 165.45 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.73 μs | 213.77 μs | 11.717 μs |  59.962 μs |  50.995 μs |  74.23 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 255.98 μs | 656.14 μs | 35.965 μs | 266.917 μs | 215.811 μs | 285.20 μs |  87.94 KB |
| StringSpan             | 64     | 100    |  13.86 μs | 196.81 μs | 10.788 μs |   7.715 μs |   7.555 μs |  26.32 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 100.59 μs | 633.63 μs | 34.732 μs |  81.891 μs |  79.207 μs | 140.66 μs |  38.22 KB |
