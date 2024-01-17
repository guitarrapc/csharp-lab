```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.15 μs** | **170.662 μs** |  **9.355 μs** |   **8.035 μs** |   **7.463 μs** |  **23.94 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.87 μs | 157.662 μs |  8.642 μs |  75.371 μs |  67.495 μs |  84.76 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.59 μs | 341.603 μs | 18.724 μs |  26.143 μs |  25.413 μs |  58.20 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.57 μs | 157.300 μs |  8.622 μs |  14.321 μs |  11.045 μs |  27.34 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  58.86 μs | 230.076 μs | 12.611 μs |  55.925 μs |  47.970 μs |  72.68 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.81 μs | 173.199 μs |  9.494 μs |   7.510 μs |   7.149 μs |  23.77 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  34.80 μs | 246.072 μs | 13.488 μs |  27.230 μs |  26.800 μs |  50.37 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **23.67 μs** | **368.290 μs** | **20.187 μs** |  **12.353 μs** |  **11.682 μs** |  **46.98 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 346.36 μs | 252.067 μs | 13.817 μs | 345.385 μs | 333.052 μs | 360.63 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 172.51 μs |   7.683 μs |  0.421 μs | 172.481 μs | 172.101 μs | 172.94 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  62.74 μs | 221.734 μs | 12.154 μs |  61.329 μs |  51.351 μs |  75.54 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 266.08 μs | 219.775 μs | 12.047 μs | 269.985 μs | 252.562 μs | 275.69 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.62 μs | 208.227 μs | 11.414 μs |   8.175 μs |   7.894 μs |  27.80 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.01 μs | 540.187 μs | 29.609 μs |  68.628 μs |  67.215 μs | 119.19 μs |  68.69 KB |
