```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **17.78 μs** |   **132.39 μs** |  **7.257 μs** |  **15.720 μs** |  **11.783 μs** |  **25.85 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.59 μs |   299.66 μs | 16.426 μs |  74.971 μs |  69.500 μs | 100.29 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  68.29 μs | 1,330.55 μs | 72.932 μs |  26.204 μs |  26.155 μs | 152.50 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.45 μs |   147.99 μs |  8.112 μs |  14.737 μs |  11.040 μs |  26.57 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  61.31 μs |   426.31 μs | 23.368 μs |  51.837 μs |  44.162 μs |  87.92 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.51 μs |   185.11 μs | 10.147 μs |   7.784 μs |   7.524 μs |  25.23 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  49.05 μs |   325.79 μs | 17.858 μs |  39.745 μs |  37.771 μs |  69.64 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.05 μs** |   **275.99 μs** | **15.128 μs** |   **9.579 μs** |   **9.058 μs** |  **35.52 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 301.28 μs |   251.15 μs | 13.767 μs | 299.981 μs | 288.209 μs | 315.65 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 189.44 μs |   329.15 μs | 18.042 μs | 181.880 μs | 176.410 μs | 210.03 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  71.27 μs |   347.77 μs | 19.063 μs |  61.585 μs |  59.000 μs |  93.23 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 249.98 μs |   598.74 μs | 32.819 μs | 242.986 μs | 221.225 μs | 285.73 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  19.54 μs |   268.93 μs | 14.741 μs |  11.302 μs |  10.760 μs |  36.56 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  88.94 μs |   586.96 μs | 32.173 μs |  70.873 μs |  69.861 μs | 126.09 μs |  68.69 KB |
