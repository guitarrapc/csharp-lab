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
| **ArrayReverse**           | **10**     | **100**    |  **14.49 μs** | **160.82 μs** |  **8.815 μs** |  **11.593 μs** |   **7.485 μs** |  **24.39 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.21 μs | 242.75 μs | 13.306 μs |  76.654 μs |  70.772 μs |  96.19 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  47.66 μs | 318.03 μs | 17.432 μs |  38.402 μs |  36.808 μs |  67.77 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.10 μs | 143.83 μs |  7.884 μs |  14.827 μs |  10.599 μs |  25.87 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  56.38 μs | 234.45 μs | 12.851 μs |  49.253 μs |  48.672 μs |  71.22 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.10 μs | 182.65 μs | 10.012 μs |   7.614 μs |   7.033 μs |  24.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.22 μs | 249.15 μs | 13.657 μs |  27.633 μs |  27.041 μs |  50.99 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.59 μs** | **278.93 μs** | **15.289 μs** |   **8.916 μs** |   **8.616 μs** |  **35.25 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 300.67 μs | 292.08 μs | 16.010 μs | 299.373 μs | 285.346 μs | 317.29 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.51 μs | 100.95 μs |  5.533 μs | 151.505 μs | 149.250 μs | 159.76 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.45 μs | 219.97 μs | 12.057 μs |  61.065 μs |  51.146 μs |  75.14 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.47 μs | 526.22 μs | 28.844 μs | 241.084 μs | 215.895 μs | 273.43 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.78 μs | 203.09 μs | 11.132 μs |   8.411 μs |   8.302 μs |  27.64 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  83.90 μs | 551.51 μs | 30.230 μs |  66.579 μs |  66.320 μs | 118.81 μs |  68.69 KB |
