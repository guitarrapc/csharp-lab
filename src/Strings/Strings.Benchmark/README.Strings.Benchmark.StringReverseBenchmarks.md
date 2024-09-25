```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.56 μs** | **185.51 μs** | **10.168 μs** |  **11.025 μs** |  **10.364 μs** |  **28.30 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.71 μs | 254.30 μs | 13.939 μs |  78.317 μs |  73.267 μs |  99.54 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  48.50 μs | 321.33 μs | 17.613 μs |  40.896 μs |  35.967 μs |  68.64 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  16.97 μs | 129.74 μs |  7.111 μs |  15.249 μs |  10.881 μs |  24.79 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.69 μs | 244.67 μs | 13.411 μs |  48.592 μs |  47.328 μs |  71.16 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.28 μs | 154.76 μs |  8.483 μs |   7.455 μs |   7.305 μs |  22.07 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.26 μs | 267.87 μs | 14.683 μs |  28.023 μs |  27.541 μs |  53.21 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **27.85 μs** | **289.22 μs** | **15.853 μs** |  **28.233 μs** |  **11.803 μs** |  **43.50 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 298.95 μs | 278.82 μs | 15.283 μs | 297.863 μs | 284.236 μs | 314.74 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 162.07 μs |  41.33 μs |  2.266 μs | 163.305 μs | 159.458 μs | 163.46 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.45 μs | 217.45 μs | 11.919 μs |  60.442 μs |  51.667 μs |  75.25 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.56 μs | 619.41 μs | 33.952 μs | 234.529 μs | 210.034 μs | 277.13 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.73 μs | 203.16 μs | 11.136 μs |   8.477 μs |   8.136 μs |  27.59 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.51 μs | 521.85 μs | 28.604 μs |  69.180 μs |  66.835 μs | 117.51 μs |  68.69 KB |
