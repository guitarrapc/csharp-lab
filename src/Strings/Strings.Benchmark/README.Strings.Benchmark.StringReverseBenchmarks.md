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
| **ArrayReverse**           | **10**     | **100**    |  **13.00 μs** | **168.90 μs** |  **9.258 μs** |   **7.750 μs** |   **7.559 μs** |  **23.69 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.21 μs | 244.04 μs | 13.377 μs |  76.252 μs |  71.022 μs |  96.36 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.21 μs | 264.38 μs | 14.491 μs |  26.600 μs |  23.194 μs |  49.82 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  27.98 μs | 483.73 μs | 26.515 μs |  14.757 μs |  10.680 μs |  58.51 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.23 μs | 242.28 μs | 13.280 μs |  43.921 μs |  43.220 μs |  66.56 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.30 μs | 212.48 μs | 11.647 μs |   9.539 μs |   7.654 μs |  28.70 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.60 μs | 251.02 μs | 13.759 μs |  28.382 μs |  26.950 μs |  51.47 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.27 μs** | **278.98 μs** | **15.292 μs** |   **9.562 μs** |   **9.312 μs** |  **35.92 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 305.08 μs | 279.52 μs | 15.321 μs | 303.033 μs | 290.891 μs | 321.33 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 151.59 μs |  11.24 μs |  0.616 μs | 151.882 μs | 150.881 μs | 152.00 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  70.39 μs | 300.60 μs | 16.477 μs |  61.925 μs |  59.862 μs |  89.38 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 252.71 μs | 601.59 μs | 32.975 μs | 253.276 μs | 219.462 μs | 285.40 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.30 μs | 221.57 μs | 12.145 μs |   8.765 μs |   7.824 μs |  29.31 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.55 μs | 532.63 μs | 29.195 μs |  68.197 μs |  67.204 μs | 118.26 μs |  68.69 KB |
