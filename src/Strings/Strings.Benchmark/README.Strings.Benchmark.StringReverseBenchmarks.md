```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev     | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|-----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **19.33 μs** |   **195.86 μs** |  **10.736 μs** |  **16.050 μs** |  **10.611 μs** |  **31.32 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.39 μs |   244.86 μs |  13.422 μs |  69.509 μs |  64.089 μs |  89.57 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  34.39 μs |   274.67 μs |  15.055 μs |  28.192 μs |  23.423 μs |  51.55 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.42 μs |   149.81 μs |   8.211 μs |  14.747 μs |  10.870 μs |  26.63 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  55.30 μs |   279.16 μs |  15.302 μs |  46.737 μs |  46.197 μs |  72.97 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.87 μs |   178.60 μs |   9.790 μs |   7.453 μs |   6.992 μs |  24.17 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  51.41 μs |   387.60 μs |  21.246 μs |  40.525 μs |  37.810 μs |  75.89 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.56 μs** |   **276.96 μs** |  **15.181 μs** |   **8.927 μs** |   **8.656 μs** |  **35.09 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 355.48 μs | 2,031.97 μs | 111.379 μs | 297.062 μs | 285.470 μs | 483.92 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 153.81 μs |    39.84 μs |   2.184 μs | 154.187 μs | 151.461 μs | 155.78 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.66 μs |   212.62 μs |  11.655 μs |  61.380 μs |  51.702 μs |  74.90 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 251.24 μs |   783.25 μs |  42.932 μs | 238.954 μs | 215.790 μs | 298.98 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  38.89 μs |   893.81 μs |  48.993 μs |  10.781 μs |  10.420 μs |  95.46 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.36 μs |   544.29 μs |  29.834 μs |  67.475 μs |  66.805 μs | 118.81 μs |  68.69 KB |
