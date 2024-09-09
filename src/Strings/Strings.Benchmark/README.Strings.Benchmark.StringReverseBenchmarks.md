```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.02 μs** |   **167.61 μs** |  **9.187 μs** |   **7.894 μs** |   **7.534 μs** |  **23.62 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 116.91 μs | 1,202.80 μs | 65.929 μs |  80.490 μs |  77.234 μs | 193.02 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.07 μs |   253.07 μs | 13.871 μs |  26.309 μs |  22.000 μs |  47.89 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.45 μs |   218.44 μs | 11.973 μs |  14.777 μs |  14.306 μs |  35.28 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.94 μs |   471.11 μs | 25.823 μs |  47.078 μs |  46.988 μs |  91.76 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  17.51 μs |   237.11 μs | 12.997 μs |  10.380 μs |   9.638 μs |  32.51 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.84 μs |   264.54 μs | 14.500 μs |  27.936 μs |  27.005 μs |  52.57 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.67 μs** |   **278.87 μs** | **15.286 μs** |   **9.177 μs** |   **8.516 μs** |  **35.32 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 307.99 μs |   279.99 μs | 15.347 μs | 311.906 μs | 291.067 μs | 321.00 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 158.65 μs |    91.30 μs |  5.005 μs | 157.713 μs | 154.178 μs | 164.06 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.10 μs |   228.36 μs | 12.517 μs |  61.965 μs |  51.185 μs |  76.14 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 242.10 μs |   518.00 μs | 28.393 μs | 242.191 μs | 213.668 μs | 270.45 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.86 μs |   235.25 μs | 12.895 μs |   8.746 μs |   8.094 μs |  30.75 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  92.58 μs |   519.89 μs | 28.497 μs |  84.558 μs |  68.959 μs | 124.23 μs |  68.69 KB |
