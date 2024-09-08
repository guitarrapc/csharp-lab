```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **20.40 μs** | **229.724 μs** | **12.592 μs** |  **16.206 μs** |  **10.434 μs** |  **34.55 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.61 μs | 260.105 μs | 14.257 μs |  76.362 μs |  70.712 μs |  97.74 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.14 μs | 255.531 μs | 14.007 μs |  26.364 μs |  21.936 μs |  48.11 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.03 μs | 245.686 μs | 13.467 μs |  14.587 μs |  13.936 μs |  37.58 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  63.61 μs | 503.913 μs | 27.621 μs |  48.109 μs |  47.217 μs |  95.50 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.52 μs | 170.000 μs |  9.318 μs |   8.666 μs |   7.635 μs |  24.27 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  47.24 μs | 310.686 μs | 17.030 μs |  38.061 μs |  36.778 μs |  66.89 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.37 μs** | **285.032 μs** | **15.624 μs** |   **9.868 μs** |   **8.836 μs** |  **36.40 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 306.89 μs | 254.433 μs | 13.946 μs | 305.393 μs | 293.751 μs | 321.52 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.09 μs |   8.829 μs |  0.484 μs | 152.245 μs | 151.553 μs | 152.49 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  70.02 μs | 335.449 μs | 18.387 μs |  60.312 μs |  58.531 μs |  91.23 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 246.67 μs | 531.065 μs | 29.109 μs | 247.254 μs | 217.267 μs | 275.48 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.71 μs | 207.600 μs | 11.379 μs |   8.325 μs |   7.965 μs |  27.85 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  90.17 μs | 563.786 μs | 30.903 μs |  77.155 μs |  67.907 μs | 125.45 μs |  68.69 KB |
