```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.64 μs** | **211.591 μs** | **11.598 μs** |  **11.015 μs** |  **10.876 μs** |  **31.03 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  79.00 μs | 149.971 μs |  8.220 μs |  82.785 μs |  69.570 μs |  84.65 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.48 μs | 247.762 μs | 13.581 μs |  26.890 μs |  22.581 μs |  47.96 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.83 μs | 127.898 μs |  7.011 μs |  20.354 μs |  15.675 μs |  29.46 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  60.39 μs | 233.715 μs | 12.811 μs |  53.200 μs |  52.789 μs |  75.18 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  18.60 μs | 258.448 μs | 14.166 μs |  10.600 μs |  10.240 μs |  34.95 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.48 μs | 284.481 μs | 15.593 μs |  30.578 μs |  26.530 μs |  55.33 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.87 μs** | **256.626 μs** | **14.067 μs** |  **12.904 μs** |   **8.766 μs** |  **34.93 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 298.51 μs | 273.558 μs | 14.995 μs | 295.260 μs | 285.413 μs | 314.87 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 149.61 μs |   8.026 μs |  0.440 μs | 149.358 μs | 149.358 μs | 150.12 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  76.68 μs | 196.715 μs | 10.783 μs |  75.640 μs |  66.454 μs |  87.94 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 260.88 μs | 759.839 μs | 41.649 μs | 265.605 μs | 217.064 μs | 299.96 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  21.83 μs | 418.074 μs | 22.916 μs |   8.896 μs |   8.305 μs |  48.29 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.03 μs | 606.688 μs | 33.255 μs |  67.046 μs |  66.625 μs | 124.43 μs |  68.69 KB |
