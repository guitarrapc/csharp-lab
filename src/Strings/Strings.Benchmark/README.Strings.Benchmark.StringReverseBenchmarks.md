```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.31 μs** | **205.72 μs** | **11.276 μs** |  **11.010 μs** |  **10.589 μs** |  **30.33 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 107.30 μs | 221.46 μs | 12.139 μs | 102.080 μs |  98.644 μs | 121.18 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.19 μs | 244.00 μs | 13.374 μs |  26.910 μs |  22.262 μs |  47.40 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.86 μs | 161.97 μs |  8.878 μs |  14.697 μs |  10.990 μs |  27.88 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  70.85 μs | 291.33 μs | 15.969 μs |  62.197 μs |  61.075 μs |  89.28 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.63 μs | 163.68 μs |  8.972 μs |   7.544 μs |   7.363 μs |  22.99 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.85 μs | 265.26 μs | 14.540 μs |  28.895 μs |  28.023 μs |  53.63 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.73 μs** | **271.06 μs** | **14.858 μs** |   **9.319 μs** |   **8.987 μs** |  **34.89 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 315.68 μs | 282.77 μs | 15.500 μs | 312.955 μs | 301.724 μs | 332.36 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.46 μs |  11.25 μs |  0.617 μs | 152.555 μs | 151.803 μs | 153.03 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.24 μs | 236.16 μs | 12.945 μs |  61.084 μs |  51.516 μs |  77.13 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.67 μs | 524.98 μs | 28.776 μs | 235.310 μs | 210.143 μs | 267.55 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.18 μs | 219.36 μs | 12.024 μs |   8.437 μs |   8.046 μs |  29.07 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.07 μs | 551.27 μs | 30.217 μs |  69.009 μs |  68.237 μs | 120.96 μs |  68.69 KB |
