```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **18.96 μs** | **198.74 μs** | **10.894 μs** |  **15.048 μs** |  **10.560 μs** |  **31.27 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.85 μs | 127.87 μs |  7.009 μs |  73.629 μs |  68.538 μs |  82.39 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  35.80 μs | 237.73 μs | 13.031 μs |  30.177 μs |  26.520 μs |  50.69 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.38 μs | 148.51 μs |  8.140 μs |  14.687 μs |  10.920 μs |  26.52 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.02 μs | 219.64 μs | 12.039 μs |  57.297 μs |  46.366 μs |  70.41 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.09 μs | 210.91 μs | 11.560 μs |   9.518 μs |   9.307 μs |  29.43 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.87 μs | 326.03 μs | 17.871 μs |  39.484 μs |  37.650 μs |  69.48 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.01 μs** | **376.23 μs** | **20.623 μs** |  **12.653 μs** |  **11.571 μs** |  **47.82 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 298.79 μs | 289.56 μs | 15.872 μs | 297.817 μs | 283.420 μs | 315.12 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 160.39 μs | 299.21 μs | 16.401 μs | 151.603 μs | 150.260 μs | 179.31 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  79.34 μs | 504.30 μs | 27.642 μs |  67.867 μs |  59.291 μs | 110.88 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 238.55 μs | 500.01 μs | 27.407 μs | 234.868 μs | 213.168 μs | 267.61 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.05 μs | 223.32 μs | 12.241 μs |   8.130 μs |   7.830 μs |  29.18 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  99.76 μs | 589.56 μs | 32.316 μs |  82.945 μs |  79.318 μs | 137.02 μs |  68.69 KB |
