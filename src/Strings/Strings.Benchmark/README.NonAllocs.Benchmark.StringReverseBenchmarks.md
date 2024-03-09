```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.03 μs** | **150.18 μs** |  **8.232 μs** |  **11.431 μs** |   **7.404 μs** |  **23.24 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  77.29 μs | 168.69 μs |  9.246 μs |  74.339 μs |  69.881 μs |  87.65 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.74 μs | 352.15 μs | 19.302 μs |  25.678 μs |  25.519 μs |  59.03 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  23.31 μs | 182.00 μs |  9.976 μs |  20.319 μs |  15.179 μs |  34.45 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.30 μs | 245.67 μs | 13.466 μs |  45.545 μs |  45.504 μs |  68.85 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.41 μs | 202.38 μs | 11.093 μs |  10.200 μs |   9.808 μs |  29.21 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  44.61 μs | 540.12 μs | 29.606 μs |  27.812 μs |  27.230 μs |  78.80 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.14 μs** | **269.48 μs** | **14.771 μs** |   **8.696 μs** |   **8.525 μs** |  **34.19 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.67 μs | 303.90 μs | 16.658 μs | 301.162 μs | 288.409 μs | 321.44 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 188.71 μs |  33.50 μs |  1.836 μs | 188.952 μs | 186.758 μs | 190.41 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  66.79 μs | 146.03 μs |  8.005 μs |  66.755 μs |  58.800 μs |  74.81 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 258.41 μs | 723.68 μs | 39.667 μs | 267.305 μs | 215.048 μs | 292.87 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.50 μs | 208.65 μs | 11.437 μs |   8.034 μs |   7.755 μs |  27.70 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.66 μs | 586.52 μs | 32.149 μs |  69.249 μs |  66.975 μs | 123.76 μs |  68.69 KB |
