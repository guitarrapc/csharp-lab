```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.33 μs** | **152.94 μs** |  **8.383 μs** |  **11.753 μs** |   **7.544 μs** |  **23.70 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.87 μs | 243.90 μs | 13.369 μs |  76.328 μs |  72.159 μs |  97.12 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.11 μs | 246.82 μs | 13.529 μs |  26.368 μs |  22.391 μs |  47.56 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.04 μs | 202.06 μs | 11.076 μs |  15.139 μs |  14.157 μs |  33.81 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.84 μs | 238.00 μs | 13.046 μs |  48.331 μs |  48.281 μs |  70.90 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.02 μs | 204.37 μs | 11.202 μs |   9.739 μs |   9.367 μs |  28.95 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.23 μs | 318.54 μs | 17.460 μs |  27.165 μs |  27.135 μs |  57.39 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.31 μs** | **373.08 μs** | **20.450 μs** |  **11.761 μs** |   **9.297 μs** |  **45.88 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 307.72 μs | 159.06 μs |  8.719 μs | 310.288 μs | 298.006 μs | 314.87 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 163.15 μs |  54.87 μs |  3.008 μs | 161.851 μs | 161.011 μs | 166.59 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.28 μs | 238.11 μs | 13.052 μs |  61.864 μs |  50.995 μs |  76.98 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.28 μs | 563.62 μs | 30.894 μs | 244.885 μs | 211.614 μs | 273.34 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.45 μs | 200.33 μs | 10.981 μs |   8.345 μs |   7.884 μs |  27.13 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.82 μs | 545.95 μs | 29.925 μs |  68.172 μs |  66.920 μs | 119.37 μs |  68.69 KB |
