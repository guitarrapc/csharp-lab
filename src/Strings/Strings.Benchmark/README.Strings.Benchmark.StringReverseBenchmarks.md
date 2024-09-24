```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.79 μs** | **188.26 μs** | **10.319 μs** |  **11.262 μs** |  **10.410 μs** |  **28.69 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  80.31 μs | 439.39 μs | 24.085 μs |  68.647 μs |  64.269 μs | 108.00 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.90 μs | 265.23 μs | 14.538 μs |  26.759 μs |  22.441 μs |  49.50 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.69 μs | 153.63 μs |  8.421 μs |  15.198 μs |  10.789 μs |  27.07 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.70 μs | 253.82 μs | 13.913 μs |  47.878 μs |  47.459 μs |  71.76 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.49 μs | 155.88 μs |  8.544 μs |   7.635 μs |   7.474 μs |  22.35 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.28 μs | 248.18 μs | 13.603 μs |  28.637 μs |  28.227 μs |  51.99 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.71 μs** | **275.63 μs** | **15.108 μs** |   **9.246 μs** |   **8.736 μs** |  **35.16 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.48 μs | 279.98 μs | 15.347 μs | 303.675 μs | 292.724 μs | 323.03 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.28 μs | 151.27 μs |  8.291 μs | 164.756 μs | 150.710 μs | 165.37 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  74.23 μs | 395.01 μs | 21.652 μs |  76.201 μs |  51.666 μs |  94.84 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 235.07 μs | 555.30 μs | 30.438 μs | 231.040 μs | 206.854 μs | 267.33 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.23 μs | 271.95 μs | 14.907 μs |   8.717 μs |   8.536 μs |  34.45 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  90.76 μs | 524.23 μs | 28.735 μs |  82.093 μs |  67.356 μs | 122.83 μs |  68.69 KB |
