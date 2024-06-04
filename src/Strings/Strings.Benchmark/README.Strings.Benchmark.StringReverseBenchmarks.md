```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev     | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|-----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.44 μs** |   **194.01 μs** |  **10.634 μs** |  **10.339 μs** |  **10.270 μs** |  **28.72 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  71.91 μs |   130.89 μs |   7.174 μs |  71.573 μs |  64.910 μs |  79.25 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  44.15 μs |   311.12 μs |  17.054 μs |  37.961 μs |  31.048 μs |  63.43 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.94 μs |   171.72 μs |   9.413 μs |  14.296 μs |  10.899 μs |  28.63 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  62.16 μs |   324.72 μs |  17.799 μs |  52.452 μs |  51.320 μs |  82.70 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.74 μs |   166.48 μs |   9.125 μs |   7.563 μs |   7.374 μs |  23.27 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.15 μs |   262.68 μs |  14.398 μs |  28.033 μs |  27.633 μs |  52.77 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.69 μs** |   **295.12 μs** |  **16.176 μs** |   **8.475 μs** |   **8.224 μs** |  **36.37 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.91 μs |   251.03 μs |  13.760 μs | 301.507 μs | 293.171 μs | 320.05 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.17 μs |   109.04 μs |   5.977 μs | 149.608 μs | 147.895 μs | 159.00 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  70.39 μs |   285.13 μs |  15.629 μs |  67.020 μs |  56.721 μs |  87.43 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 246.81 μs |   536.35 μs |  29.399 μs | 243.444 μs | 219.238 μs | 277.75 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.32 μs |   255.28 μs |  13.993 μs |  10.380 μs |  10.099 μs |  34.47 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 197.42 μs | 3,345.41 μs | 183.373 μs |  93.355 μs |  89.758 μs | 409.15 μs |  68.69 KB |
