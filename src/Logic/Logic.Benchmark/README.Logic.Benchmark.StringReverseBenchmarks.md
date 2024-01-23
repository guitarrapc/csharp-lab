```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.04 μs** | **203.08 μs** | **11.131 μs** |   **7.625 μs** |   **7.595 μs** |  **26.89 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  83.98 μs | 236.31 μs | 12.953 μs |  78.570 μs |  74.603 μs |  98.76 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  39.21 μs | 387.29 μs | 21.229 μs |  27.055 μs |  26.855 μs |  63.72 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.03 μs | 154.45 μs |  8.466 μs |  15.288 μs |  11.280 μs |  27.53 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  52.83 μs | 235.50 μs | 12.908 μs |  45.674 μs |  45.093 μs |  67.74 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.88 μs | 166.53 μs |  9.128 μs |   9.238 μs |   8.005 μs |  24.40 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  40.26 μs | 257.67 μs | 14.124 μs |  37.310 μs |  27.842 μs |  55.62 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.61 μs** | **253.82 μs** | **13.913 μs** |  **12.284 μs** |   **8.988 μs** |  **34.56 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 316.58 μs | 332.69 μs | 18.236 μs | 313.651 μs | 299.986 μs | 336.10 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 175.53 μs |  27.00 μs |  1.480 μs | 176.257 μs | 173.822 μs | 176.50 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  72.79 μs | 339.35 μs | 18.601 μs |  78.076 μs |  52.117 μs |  88.17 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 236.16 μs | 483.34 μs | 26.493 μs | 233.723 μs | 210.971 μs | 263.79 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.81 μs | 239.86 μs | 13.148 μs |  11.482 μs |  10.951 μs |  33.98 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.94 μs | 542.75 μs | 29.750 μs |  68.086 μs |  67.445 μs | 119.29 μs |  68.69 KB |
