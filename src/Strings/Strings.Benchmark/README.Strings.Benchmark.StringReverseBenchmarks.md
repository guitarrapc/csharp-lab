```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.52 μs** | **154.56 μs** |  **8.472 μs** |  **14.958 μs** |  **10.629 μs** |  **26.98 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  73.94 μs | 166.05 μs |  9.102 μs |  71.155 μs |  66.556 μs |  84.11 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.43 μs | 254.24 μs | 13.936 μs |  26.779 μs |  22.202 μs |  48.30 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.51 μs | 152.00 μs |  8.331 μs |  14.723 μs |  10.927 μs |  26.88 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  63.05 μs | 301.25 μs | 16.513 μs |  54.578 μs |  52.493 μs |  82.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.78 μs | 232.79 μs | 12.760 μs |   7.623 μs |   7.213 μs |  29.52 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  38.00 μs | 304.63 μs | 16.698 μs |  28.573 μs |  28.142 μs |  57.28 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.34 μs** | **268.02 μs** | **14.691 μs** |   **9.056 μs** |   **8.666 μs** |  **34.30 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 309.27 μs | 258.31 μs | 14.159 μs | 309.534 μs | 294.986 μs | 323.30 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 168.43 μs | 588.73 μs | 32.270 μs | 151.094 μs | 148.540 μs | 205.67 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.07 μs | 239.21 μs | 13.112 μs |  62.007 μs |  50.515 μs |  76.67 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.03 μs | 501.33 μs | 27.480 μs | 240.985 μs | 212.080 μs | 267.01 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.43 μs | 233.60 μs | 12.804 μs |   8.357 μs |   7.715 μs |  30.21 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  90.16 μs | 551.46 μs | 30.227 μs |  73.338 μs |  72.086 μs | 125.06 μs |  68.69 KB |
