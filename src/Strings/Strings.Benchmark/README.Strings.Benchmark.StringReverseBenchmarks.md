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
| **ArrayReverse**           | **10**     | **100**    |  **14.76 μs** | **176.08 μs** |  **9.651 μs** |  **11.552 μs** |   **7.124 μs** |  **25.61 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.75 μs | 213.95 μs | 11.727 μs |  78.005 μs |  72.345 μs |  94.89 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  33.06 μs | 244.00 μs | 13.375 μs |  28.563 μs |  22.521 μs |  48.11 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  23.39 μs | 174.15 μs |  9.546 μs |  20.459 μs |  15.649 μs |  34.05 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.62 μs | 252.00 μs | 13.813 μs |  46.215 μs |  45.093 μs |  69.56 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.08 μs | 171.40 μs |  9.395 μs |   7.814 μs |   7.494 μs |  23.92 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.88 μs | 250.78 μs | 13.746 μs |  27.992 μs |  27.902 μs |  51.76 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.72 μs** | **279.97 μs** | **15.346 μs** |   **9.026 μs** |   **8.686 μs** |  **35.44 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 332.40 μs | 324.08 μs | 17.764 μs | 329.681 μs | 316.147 μs | 351.36 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 159.50 μs | 237.85 μs | 13.037 μs | 154.341 μs | 149.833 μs | 174.33 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  62.98 μs | 206.27 μs | 11.307 μs |  62.026 μs |  52.188 μs |  74.74 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.46 μs | 543.41 μs | 29.786 μs | 238.182 μs | 211.883 μs | 271.32 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.66 μs | 190.56 μs | 10.445 μs |  11.011 μs |   8.345 μs |  27.62 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  84.57 μs | 545.27 μs | 29.888 μs |  68.082 μs |  66.549 μs | 119.07 μs |  68.69 KB |
