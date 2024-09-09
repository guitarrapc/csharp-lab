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
| **ArrayReverse**           | **10**     | **100**    |  **14.21 μs** | **158.62 μs** |  **8.695 μs** |  **10.956 μs** |   **7.609 μs** |  **24.06 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.31 μs | 158.84 μs |  8.707 μs |  73.329 μs |  67.758 μs |  84.83 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  34.17 μs | 263.79 μs | 14.459 μs |  28.488 μs |  23.419 μs |  50.61 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.25 μs | 156.58 μs |  8.583 μs |  15.990 μs |  11.031 μs |  27.74 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.91 μs | 262.58 μs | 14.393 μs |  45.806 μs |  45.405 μs |  70.53 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.24 μs | 254.88 μs | 13.971 μs |   9.974 μs |   8.401 μs |  33.35 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  55.83 μs | 265.09 μs | 14.531 μs |  48.632 μs |  46.308 μs |  72.56 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.65 μs** | **300.33 μs** | **16.462 μs** |   **9.578 μs** |   **8.717 μs** |  **37.65 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 305.09 μs | 231.78 μs | 12.705 μs | 305.254 μs | 292.310 μs | 317.72 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.22 μs |  99.14 μs |  5.434 μs | 160.413 μs | 153.289 μs | 163.96 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.62 μs | 207.75 μs | 11.388 μs |  62.817 μs |  52.648 μs |  75.38 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.33 μs | 794.83 μs | 43.568 μs | 239.931 μs | 214.594 μs | 299.46 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  20.71 μs | 309.83 μs | 16.983 μs |  10.941 μs |  10.861 μs |  40.32 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  96.05 μs | 831.18 μs | 45.560 μs |  70.704 μs |  68.790 μs | 148.64 μs |  68.69 KB |
