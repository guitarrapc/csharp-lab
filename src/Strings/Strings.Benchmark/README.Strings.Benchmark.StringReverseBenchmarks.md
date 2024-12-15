```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.26 μs** |   **227.24 μs** | **12.456 μs** |  **10.470 μs** |   **7.755 μs** |  **30.56 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.94 μs |   249.33 μs | 13.667 μs |  77.675 μs |  72.686 μs |  98.45 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  47.69 μs |   278.68 μs | 15.275 μs |  42.589 μs |  35.616 μs |  64.86 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.98 μs |   142.58 μs |  7.815 μs |  15.729 μs |  11.531 μs |  26.67 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  49.64 μs |   241.81 μs | 13.255 μs |  42.459 μs |  41.517 μs |  64.93 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.88 μs |   169.64 μs |  9.298 μs |   7.575 μs |   7.445 μs |  23.61 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.15 μs |   250.67 μs | 13.740 μs |  27.781 μs |  26.670 μs |  51.01 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **32.93 μs** |   **752.04 μs** | **41.222 μs** |   **9.167 μs** |   **9.098 μs** |  **80.53 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 398.69 μs | 1,340.57 μs | 73.481 μs | 441.099 μs | 313.841 μs | 441.13 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.22 μs |    34.36 μs |  1.883 μs | 151.695 μs | 150.651 μs | 154.31 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.80 μs |   244.37 μs | 13.395 μs |  60.609 μs |  50.630 μs |  77.15 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.11 μs |   555.42 μs | 30.445 μs | 238.436 μs | 212.087 μs | 272.80 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.81 μs |   216.52 μs | 11.868 μs |  11.551 μs |   8.475 μs |  30.40 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.02 μs |   601.18 μs | 32.953 μs |  68.749 μs |  67.256 μs | 125.06 μs |  68.69 KB |
