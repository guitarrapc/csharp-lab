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
| **ArrayReverse**           | **10**     | **100**    |  **13.91 μs** | **148.19 μs** |  **8.123 μs** |  **10.890 μs** |   **7.734 μs** |  **23.11 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  74.37 μs | 156.86 μs |  8.598 μs |  77.714 μs |  64.600 μs |  80.79 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  36.76 μs | 365.03 μs | 20.009 μs |  25.419 μs |  24.997 μs |  59.86 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.28 μs | 145.18 μs |  7.958 μs |  14.767 μs |  10.880 μs |  26.19 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.63 μs | 253.65 μs | 13.903 μs |  42.699 μs |  42.508 μs |  66.68 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.47 μs | 161.11 μs |  8.831 μs |   7.634 μs |   7.114 μs |  22.66 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  39.74 μs | 221.48 μs | 12.140 μs |  39.264 μs |  27.852 μs |  52.12 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.66 μs** | **273.34 μs** | **14.983 μs** |   **9.223 μs** |   **8.802 μs** |  **34.96 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 323.43 μs | 573.18 μs | 31.418 μs | 341.557 μs | 287.154 μs | 341.59 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 185.62 μs |  33.93 μs |  1.860 μs | 186.147 μs | 183.553 μs | 187.16 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  61.14 μs | 199.62 μs | 10.942 μs |  60.113 μs |  50.755 μs |  72.57 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 240.61 μs | 592.95 μs | 32.501 μs | 234.989 μs | 211.284 μs | 275.55 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  21.24 μs | 324.40 μs | 17.782 μs |  11.311 μs |  10.639 μs |  41.77 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  94.89 μs | 815.43 μs | 44.697 μs |  69.405 μs |  68.763 μs | 146.50 μs |  68.69 KB |
