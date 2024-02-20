```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.81 μs** | **163.26 μs** |  **8.949 μs** |   **7.725 μs** |   **7.565 μs** |  **23.14 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  84.68 μs | 153.70 μs |  8.425 μs |  85.670 μs |  75.801 μs |  92.56 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.68 μs | 369.44 μs | 20.250 μs |  26.259 μs |  25.727 μs |  61.06 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  20.83 μs | 186.32 μs | 10.213 μs |  15.198 μs |  14.677 μs |  32.62 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.29 μs | 274.85 μs | 15.066 μs |  43.671 μs |  43.521 μs |  69.69 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.74 μs | 196.41 μs | 10.766 μs |   9.693 μs |   9.352 μs |  28.17 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.23 μs | 245.28 μs | 13.445 μs |  31.088 μs |  27.953 μs |  52.65 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.78 μs** | **272.88 μs** | **14.958 μs** |   **9.537 μs** |   **8.756 μs** |  **35.05 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.18 μs | 315.59 μs | 17.298 μs | 298.217 μs | 285.554 μs | 319.77 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 178.43 μs | 123.81 μs |  6.786 μs | 175.688 μs | 173.443 μs | 186.16 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.75 μs | 225.28 μs | 12.348 μs |  61.029 μs |  51.350 μs |  75.87 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.46 μs | 529.77 μs | 29.038 μs | 249.796 μs | 209.170 μs | 265.43 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.52 μs | 192.37 μs | 10.544 μs |  10.850 μs |   8.114 μs |  27.59 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.14 μs | 569.10 μs | 31.194 μs |  69.970 μs |  68.307 μs | 123.15 μs |  68.69 KB |
