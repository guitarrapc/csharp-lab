```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.17 μs** | **198.86 μs** | **10.900 μs** |  **12.152 μs** |   **7.856 μs** |  **28.51 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  75.13 μs | 151.42 μs |  8.300 μs |  78.767 μs |  65.632 μs |  80.99 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.50 μs | 236.65 μs | 12.971 μs |  37.559 μs |  23.033 μs |  48.91 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.67 μs | 174.54 μs |  9.567 μs |  19.466 μs |  15.108 μs |  33.42 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.73 μs | 248.98 μs | 13.647 μs |  46.066 μs |  45.646 μs |  69.49 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.00 μs | 167.29 μs |  9.170 μs |   8.135 μs |   7.283 μs |  23.57 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.73 μs | 252.29 μs | 13.829 μs |  27.968 μs |  27.517 μs |  51.69 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.25 μs** | **297.11 μs** | **16.286 μs** |   **8.938 μs** |   **8.767 μs** |  **37.06 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 311.08 μs | 326.38 μs | 17.890 μs | 313.541 μs | 292.082 μs | 327.61 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 151.09 μs |  37.52 μs |  2.057 μs | 151.483 μs | 148.868 μs | 152.93 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.99 μs | 220.42 μs | 12.082 μs |  62.106 μs |  51.376 μs |  75.49 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 254.46 μs | 545.58 μs | 29.905 μs | 252.692 μs | 225.481 μs | 285.21 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.84 μs | 258.69 μs | 14.180 μs |  10.901 μs |  10.400 μs |  35.21 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  92.05 μs | 754.00 μs | 41.329 μs |  68.434 μs |  67.953 μs | 139.78 μs |  68.69 KB |
