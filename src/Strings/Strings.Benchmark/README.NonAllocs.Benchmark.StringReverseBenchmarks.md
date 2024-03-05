```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.94 μs** | **200.731 μs** | **11.003 μs** |  **10.690 μs** |  **10.489 μs** |  **29.65 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  86.38 μs | 256.046 μs | 14.035 μs |  79.469 μs |  77.146 μs | 102.53 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.20 μs | 378.134 μs | 20.727 μs |  25.638 μs |  24.826 μs |  61.12 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.20 μs | 156.692 μs |  8.589 μs |  14.527 μs |  10.269 μs |  26.81 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.19 μs | 198.678 μs | 10.890 μs |  52.098 μs |  46.187 μs |  67.30 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.07 μs | 150.339 μs |  8.241 μs |   7.435 μs |   7.184 μs |  21.58 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.72 μs | 284.522 μs | 15.596 μs |  27.878 μs |  27.558 μs |  54.73 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.33 μs** | **275.602 μs** | **15.107 μs** |   **8.776 μs** |   **8.446 μs** |  **34.77 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 318.17 μs | 320.400 μs | 17.562 μs | 312.399 μs | 304.213 μs | 337.89 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.49 μs |   4.637 μs |  0.254 μs | 173.376 μs | 173.306 μs | 173.78 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.30 μs | 234.532 μs | 12.855 μs |  61.740 μs |  51.301 μs |  76.87 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.14 μs | 499.028 μs | 27.353 μs | 246.444 μs | 211.528 μs | 265.46 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.46 μs | 205.977 μs | 11.290 μs |   8.375 μs |   7.524 μs |  27.49 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.65 μs | 545.207 μs | 29.885 μs |  67.778 μs |  67.017 μs | 119.16 μs |  68.69 KB |
