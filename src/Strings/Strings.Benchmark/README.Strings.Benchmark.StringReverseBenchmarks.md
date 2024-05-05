```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.73 μs** | **176.13 μs** |  **9.655 μs** |  **13.856 μs** |  **10.619 μs** |  **28.72 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  92.38 μs | 300.79 μs | 16.487 μs | 100.106 μs |  73.448 μs | 103.58 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.68 μs | 348.09 μs | 19.080 μs |  25.728 μs |  25.598 μs |  58.71 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.49 μs | 150.11 μs |  8.228 μs |  14.847 μs |  10.900 μs |  26.71 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  49.71 μs | 242.07 μs | 13.268 μs |  43.061 μs |  41.087 μs |  64.99 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.64 μs | 164.28 μs |  9.005 μs |   7.615 μs |   7.264 μs |  23.03 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.04 μs | 264.05 μs | 14.474 μs |  27.831 μs |  27.530 μs |  52.75 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **25.38 μs** | **425.73 μs** | **23.336 μs** |  **12.212 μs** |  **11.611 μs** |  **52.33 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 308.09 μs | 320.36 μs | 17.560 μs | 305.755 μs | 291.818 μs | 326.70 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 173.55 μs |  14.48 μs |  0.794 μs | 173.814 μs | 172.661 μs | 174.18 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  61.92 μs | 221.88 μs | 12.162 μs |  61.363 μs |  50.053 μs |  74.36 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.71 μs | 443.86 μs | 24.330 μs | 231.672 μs | 220.410 μs | 267.04 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  16.23 μs | 257.66 μs | 14.123 μs |   8.606 μs |   7.564 μs |  32.53 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.40 μs | 544.64 μs | 29.853 μs |  69.349 μs |  68.988 μs | 120.88 μs |  68.69 KB |
