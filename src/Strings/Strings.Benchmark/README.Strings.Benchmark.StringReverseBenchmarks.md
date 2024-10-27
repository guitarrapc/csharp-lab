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
| **ArrayReverse**           | **10**     | **100**    |  **18.66 μs** | **190.93 μs** | **10.466 μs** |  **14.947 μs** |  **10.559 μs** |  **30.48 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.23 μs | 247.77 μs | 13.581 μs |  77.946 μs |  69.590 μs |  96.15 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.43 μs | 247.81 μs | 13.583 μs |  26.920 μs |  22.461 μs |  47.90 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  20.57 μs | 241.09 μs | 13.215 μs |  14.917 μs |  11.130 μs |  35.68 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.31 μs | 451.61 μs | 24.754 μs |  50.755 μs |  43.590 μs |  89.60 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.93 μs | 165.40 μs |  9.066 μs |   8.085 μs |   7.324 μs |  23.39 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  39.14 μs | 378.57 μs | 20.751 μs |  27.189 μs |  27.120 μs |  63.10 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **21.98 μs** | **372.03 μs** | **20.392 μs** |  **11.526 μs** |   **8.932 μs** |  **45.48 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 305.84 μs | 243.83 μs | 13.365 μs | 301.719 μs | 295.027 μs | 320.79 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.66 μs |  40.61 μs |  2.226 μs | 160.452 μs | 158.549 μs | 162.99 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  95.26 μs | 345.98 μs | 18.964 μs | 104.374 μs |  73.456 μs | 107.94 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 244.06 μs | 585.95 μs | 32.118 μs | 234.904 μs | 217.523 μs | 279.77 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.18 μs | 289.78 μs | 15.884 μs |   8.074 μs |   7.954 μs |  35.52 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.58 μs | 576.42 μs | 31.596 μs |  67.917 μs |  66.765 μs | 122.06 μs |  68.69 KB |
