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
| **ArrayReverse**           | **10**     | **100**    |  **18.23 μs** | **167.30 μs** |  **9.170 μs** |  **15.881 μs** |  **10.460 μs** |  **28.34 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  82.90 μs | 257.55 μs | 14.117 μs |  77.293 μs |  72.454 μs |  98.96 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.12 μs | 343.83 μs | 18.846 μs |  25.458 μs |  25.017 μs |  57.88 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.01 μs | 192.43 μs | 10.548 μs |  10.930 μs |  10.920 μs |  29.19 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  64.46 μs | 332.24 μs | 18.211 μs |  55.673 μs |  52.307 μs |  85.40 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.36 μs | 188.05 μs | 10.307 μs |   7.494 μs |   7.333 μs |  25.27 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  50.10 μs | 323.31 μs | 17.722 μs |  41.978 μs |  37.901 μs |  70.43 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.01 μs** | **284.16 μs** | **15.576 μs** |   **9.238 μs** |   **8.806 μs** |  **36.00 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 323.84 μs | 277.22 μs | 15.195 μs | 321.577 μs | 309.906 μs | 340.04 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 191.89 μs | 520.15 μs | 28.511 μs | 178.913 μs | 172.170 μs | 224.58 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  71.65 μs | 286.57 μs | 15.708 μs |  67.766 μs |  58.248 μs |  88.94 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.74 μs | 567.36 μs | 31.099 μs | 234.676 μs | 213.115 μs | 274.42 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.06 μs | 204.90 μs | 11.231 μs |   8.876 μs |   8.275 μs |  28.02 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.19 μs | 537.64 μs | 29.470 μs |  70.341 μs |  68.037 μs | 120.19 μs |  68.69 KB |
