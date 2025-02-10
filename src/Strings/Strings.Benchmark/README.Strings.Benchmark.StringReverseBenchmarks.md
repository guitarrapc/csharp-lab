```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.85 μs** | **140.63 μs** |  **7.708 μs** |  **11.668 μs** |   **7.460 μs** |  **22.41 μs** |   **9.81 KB** |
| EnumerableReverse      | 10     | 100    |  47.92 μs | 159.26 μs |  8.730 μs |  43.752 μs |  42.048 μs |  57.95 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  33.98 μs | 281.16 μs | 15.412 μs |  29.936 μs |  20.988 μs |  51.01 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.11 μs | 205.50 μs | 11.264 μs |  14.797 μs |  14.416 μs |  34.11 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.91 μs | 267.78 μs | 14.678 μs |  42.560 μs |  42.310 μs |  67.86 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.82 μs | 200.14 μs | 10.971 μs |   8.006 μs |   6.973 μs |  26.47 μs |   5.13 KB |
| StringExtensionReverse | 10     | 100    |  39.43 μs | 161.47 μs |  8.850 μs |  34.395 μs |  34.255 μs |  49.65 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.45 μs** | **266.36 μs** | **14.600 μs** |   **9.909 μs** |   **8.155 μs** |  **34.27 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 131.23 μs | 233.07 μs | 12.775 μs | 124.819 μs | 122.925 μs | 145.94 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 144.92 μs |  60.29 μs |  3.305 μs | 144.737 μs | 141.712 μs | 148.31 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  81.91 μs | 387.76 μs | 21.255 μs |  79.097 μs |  62.196 μs | 104.43 μs |  30.13 KB |
| StackReverse           | 64     | 100    | 248.30 μs | 499.09 μs | 27.357 μs | 235.531 μs | 229.661 μs | 279.71 μs |  87.94 KB |
| StringSpan             | 64     | 100    |  20.24 μs | 391.41 μs | 21.454 μs |   7.950 μs |   7.750 μs |  45.01 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  77.38 μs | 281.42 μs | 15.426 μs |  69.861 μs |  67.146 μs |  95.12 μs |  37.89 KB |
