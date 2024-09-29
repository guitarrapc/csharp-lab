```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.34 μs** | **147.76 μs** |  **8.099 μs** |   **7.801 μs** |   **7.538 μs** |  **21.70 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 106.56 μs | 163.40 μs |  8.956 μs | 105.476 μs |  98.202 μs | 116.02 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.05 μs | 255.39 μs | 13.999 μs |  26.229 μs |  21.901 μs |  48.02 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  16.77 μs | 133.40 μs |  7.312 μs |  14.458 μs |  10.891 μs |  24.96 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.67 μs | 299.51 μs | 16.417 μs |  53.580 μs |  50.866 μs |  80.56 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.36 μs | 157.14 μs |  8.613 μs |   7.454 μs |   7.314 μs |  22.30 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.71 μs | 186.33 μs | 10.214 μs |  54.731 μs |  37.960 μs |  56.45 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.39 μs** | **335.14 μs** | **18.370 μs** |  **13.074 μs** |  **12.503 μs** |  **44.60 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 311.80 μs | 379.92 μs | 20.825 μs | 315.558 μs | 289.348 μs | 330.48 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 150.23 μs |  23.96 μs |  1.313 μs | 149.477 μs | 149.458 μs | 151.74 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.38 μs | 196.72 μs | 10.783 μs |  59.670 μs |  51.555 μs |  72.92 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 260.31 μs | 542.36 μs | 29.728 μs | 256.297 μs | 232.793 μs | 291.84 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.85 μs | 198.93 μs | 10.904 μs |   8.926 μs |   8.185 μs |  27.43 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.26 μs | 545.55 μs | 29.904 μs |  69.355 μs |  68.642 μs | 120.79 μs |  68.69 KB |
