```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.63 μs** | **163.686 μs** |  **8.972 μs** |   **7.539 μs** |   **7.358 μs** |  **22.99 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  70.22 μs | 139.078 μs |  7.623 μs |  69.920 μs |  62.747 μs |  77.98 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  42.67 μs | 285.948 μs | 15.674 μs |  36.447 μs |  31.067 μs |  60.50 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.02 μs | 170.848 μs |  9.365 μs |  14.937 μs |  10.579 μs |  28.53 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.54 μs | 196.770 μs | 10.786 μs |  53.850 μs |  45.704 μs |  67.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.10 μs | 151.086 μs |  8.282 μs |   7.573 μs |   7.072 μs |  21.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.10 μs | 302.490 μs | 16.580 μs |  40.946 μs |  38.171 μs |  68.18 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.73 μs** | **375.283 μs** | **20.571 μs** |  **12.233 μs** |   **9.518 μs** |  **46.43 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 299.99 μs | 319.365 μs | 17.505 μs | 296.271 μs | 284.639 μs | 319.05 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 150.69 μs |   5.244 μs |  0.287 μs | 150.830 μs | 150.359 μs | 150.88 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  84.33 μs | 924.466 μs | 50.673 μs |  60.051 μs |  50.364 μs | 142.57 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 244.40 μs | 485.453 μs | 26.609 μs | 249.810 μs | 215.506 μs | 267.89 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.76 μs | 248.388 μs | 13.615 μs |  11.252 μs |  10.550 μs |  34.48 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.51 μs | 559.713 μs | 30.680 μs |  68.196 μs |  67.405 μs | 120.94 μs |  68.69 KB |
