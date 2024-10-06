```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.55 μs** | **149.51 μs** |  **8.195 μs** |   **7.975 μs** |   **7.665 μs** |  **22.01 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  73.20 μs | 147.17 μs |  8.067 μs |  70.611 μs |  66.743 μs |  82.24 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  42.84 μs | 269.28 μs | 14.760 μs |  37.058 μs |  31.839 μs |  59.61 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.73 μs | 150.65 μs |  8.258 μs |  19.270 μs |  14.973 μs |  30.93 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.87 μs | 224.95 μs | 12.331 μs |  45.495 μs |  44.032 μs |  66.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.02 μs | 235.52 μs | 12.910 μs |   7.815 μs |   7.323 μs |  29.93 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.33 μs | 253.03 μs | 13.870 μs |  28.563 μs |  28.092 μs |  52.35 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.06 μs** | **287.60 μs** | **15.764 μs** |   **9.342 μs** |   **8.570 μs** |  **36.25 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 323.48 μs | 575.62 μs | 31.552 μs | 339.630 μs | 287.123 μs | 343.69 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 156.87 μs | 190.41 μs | 10.437 μs | 151.501 μs | 150.219 μs | 168.90 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  68.94 μs | 294.95 μs | 16.167 μs |  70.370 μs |  52.106 μs |  84.35 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 235.05 μs | 526.03 μs | 28.834 μs | 231.900 μs | 207.925 μs | 265.33 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.98 μs | 246.33 μs | 13.502 μs |  11.552 μs |  10.821 μs |  34.56 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.50 μs | 559.19 μs | 30.651 μs |  68.392 μs |  67.230 μs | 120.89 μs |  68.69 KB |
