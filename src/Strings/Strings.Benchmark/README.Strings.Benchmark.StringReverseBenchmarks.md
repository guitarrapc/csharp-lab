```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.94 μs** | **197.57 μs** | **10.829 μs** |  **11.072 μs** |  **10.309 μs** |  **29.44 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  80.50 μs | 238.60 μs | 13.079 μs |  75.731 μs |  70.481 μs |  95.30 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  41.45 μs | 309.63 μs | 16.972 μs |  51.034 μs |  21.851 μs |  51.46 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.54 μs | 126.54 μs |  6.936 μs |  14.658 μs |  14.418 μs |  26.55 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.73 μs | 286.19 μs | 15.687 μs |  42.680 μs |  42.659 μs |  69.84 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.51 μs | 163.90 μs |  8.984 μs |   7.454 μs |   7.194 μs |  22.88 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  47.93 μs | 312.58 μs | 17.134 μs |  38.090 μs |  37.990 μs |  67.72 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.34 μs** | **303.15 μs** | **16.617 μs** |   **8.966 μs** |   **8.535 μs** |  **37.53 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 302.48 μs | 215.96 μs | 11.837 μs | 304.858 μs | 289.630 μs | 312.94 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 149.19 μs |  12.32 μs |  0.676 μs | 149.108 μs | 148.556 μs | 149.90 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.89 μs | 211.48 μs | 11.592 μs |  61.314 μs |  50.594 μs |  73.76 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.60 μs | 586.37 μs | 32.141 μs | 244.577 μs | 223.556 μs | 286.68 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.68 μs | 206.10 μs | 11.297 μs |   8.255 μs |   8.056 μs |  27.72 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.32 μs | 613.83 μs | 33.646 μs |  68.237 μs |  67.545 μs | 126.17 μs |  68.69 KB |
