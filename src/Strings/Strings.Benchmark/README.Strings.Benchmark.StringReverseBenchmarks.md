```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.14 μs** | **163.60 μs** |  **8.967 μs** |   **8.145 μs** |   **7.785 μs** |  **23.49 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.94 μs | 208.74 μs | 11.442 μs |  73.411 μs |  65.968 μs |  88.43 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  35.71 μs | 304.36 μs | 16.683 μs |  28.479 μs |  23.860 μs |  54.79 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.47 μs | 188.98 μs | 10.359 μs |  14.677 μs |  10.550 μs |  30.20 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  59.51 μs | 255.35 μs | 13.997 μs |  56.655 μs |  47.167 μs |  74.72 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.33 μs | 157.81 μs |  8.650 μs |   7.559 μs |   7.118 μs |  22.32 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  42.11 μs | 194.49 μs | 10.661 μs |  45.035 μs |  30.287 μs |  51.00 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.69 μs** | **277.30 μs** | **15.200 μs** |  **10.280 μs** |   **9.557 μs** |  **36.24 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 302.23 μs | 269.33 μs | 14.763 μs | 298.978 μs | 289.360 μs | 318.34 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 157.67 μs | 106.43 μs |  5.834 μs | 157.213 μs | 152.074 μs | 163.72 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  68.54 μs | 257.65 μs | 14.123 μs |  72.425 μs |  52.878 μs |  80.31 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 243.96 μs | 556.87 μs | 30.524 μs | 248.254 μs | 211.515 μs | 272.11 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.31 μs | 219.29 μs | 12.020 μs |   8.435 μs |   8.315 μs |  29.19 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.64 μs | 579.23 μs | 31.750 μs |  70.352 μs |  68.288 μs | 124.28 μs |  68.69 KB |
