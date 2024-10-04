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
| **ArrayReverse**           | **10**     | **100**    |  **16.27 μs** | **183.15 μs** | **10.039 μs** |  **10.504 μs** |  **10.434 μs** |  **27.86 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  86.57 μs | 281.73 μs | 15.443 μs |  78.577 μs |  76.753 μs | 104.37 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  46.80 μs | 327.46 μs | 17.949 μs |  37.621 μs |  35.287 μs |  67.48 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.52 μs | 179.14 μs |  9.819 μs |  15.107 μs |  10.870 μs |  29.59 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  60.90 μs | 491.14 μs | 26.921 μs |  45.825 μs |  44.893 μs |  91.98 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.64 μs | 162.99 μs |  8.934 μs |   7.554 μs |   7.403 μs |  22.95 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  44.46 μs | 542.96 μs | 29.761 μs |  27.591 μs |  26.970 μs |  78.83 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.18 μs** | **325.14 μs** | **17.822 μs** |   **8.947 μs** |   **8.827 μs** |  **39.76 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 308.80 μs | 284.74 μs | 15.608 μs | 307.052 μs | 294.139 μs | 325.21 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.38 μs |  36.94 μs |  2.025 μs | 151.342 μs | 151.091 μs | 154.72 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  71.96 μs | 275.38 μs | 15.094 μs |  66.914 μs |  60.041 μs |  88.94 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 539.07 μs | 411.78 μs | 22.571 μs | 528.404 μs | 523.816 μs | 565.00 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.44 μs | 246.71 μs | 13.523 μs |  10.885 μs |  10.374 μs |  34.05 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.00 μs | 505.90 μs | 27.730 μs |  68.818 μs |  67.174 μs | 116.00 μs |  68.69 KB |
