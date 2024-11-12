```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.71 μs** | **178.15 μs** |  **9.765 μs** |  **10.759 μs** |   **7.535 μs** |  **25.83 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.35 μs | 145.89 μs |  7.997 μs |  78.238 μs |  66.305 μs |  81.49 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.18 μs | 278.31 μs | 15.255 μs |  26.470 μs |  22.422 μs |  50.63 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.13 μs | 172.54 μs |  9.457 μs |  14.576 μs |  10.970 μs |  28.85 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  75.48 μs | 343.91 μs | 18.851 μs |  65.032 μs |  64.170 μs |  97.24 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.28 μs | 182.56 μs | 10.007 μs |   7.744 μs |   7.274 μs |  24.84 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.60 μs | 284.17 μs | 15.576 μs |  27.822 μs |  27.392 μs |  54.58 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.78 μs** | **269.84 μs** | **14.791 μs** |   **9.287 μs** |   **9.187 μs** |  **34.85 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 298.21 μs | 267.09 μs | 14.640 μs | 296.353 μs | 284.581 μs | 313.69 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.67 μs |  28.10 μs |  1.541 μs | 160.014 μs | 159.564 μs | 162.43 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.31 μs | 244.52 μs | 13.403 μs |  61.756 μs |  50.755 μs |  77.42 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 249.95 μs | 588.94 μs | 32.282 μs | 246.582 μs | 219.481 μs | 283.78 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.75 μs | 209.84 μs | 11.502 μs |   8.115 μs |   8.104 μs |  28.03 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.66 μs | 582.65 μs | 31.937 μs |  68.559 μs |  67.877 μs | 123.53 μs |  68.69 KB |
