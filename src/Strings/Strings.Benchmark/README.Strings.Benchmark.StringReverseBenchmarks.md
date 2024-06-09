```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **15.83 μs** | **207.70 μs** | **11.385 μs** |  **10.591 μs** |   **8.014 μs** |  **28.89 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  70.68 μs | 158.80 μs |  8.705 μs |  68.317 μs |  63.398 μs |  80.32 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  31.99 μs | 252.58 μs | 13.845 μs |  26.075 μs |  22.076 μs |  47.80 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.59 μs | 187.40 μs | 10.272 μs |  14.567 μs |  10.940 μs |  30.27 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.53 μs | 236.59 μs | 12.968 μs |  46.178 μs |  45.917 μs |  68.51 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.22 μs | 181.73 μs |  9.961 μs |   7.544 μs |   7.385 μs |  24.72 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.35 μs | 250.74 μs | 13.744 μs |  42.059 μs |  40.787 μs |  65.20 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.16 μs** | **264.35 μs** | **14.490 μs** |   **9.086 μs** |   **8.496 μs** |  **33.88 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 305.80 μs | 275.64 μs | 15.109 μs | 306.579 μs | 290.318 μs | 320.51 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 152.78 μs |  15.37 μs |  0.842 μs | 152.831 μs | 151.920 μs | 153.60 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.84 μs | 260.42 μs | 14.275 μs |  60.913 μs |  49.622 μs |  77.98 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.92 μs | 540.52 μs | 29.628 μs | 238.748 μs | 214.011 μs | 273.01 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.73 μs | 210.52 μs | 11.539 μs |   8.296 μs |   7.845 μs |  28.05 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.38 μs | 562.88 μs | 30.854 μs |  68.584 μs |  68.543 μs | 122.00 μs |  68.69 KB |
