```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **13.23 μs** | **170.81 μs** |  **9.363 μs** |   **7.934 μs** |   **7.724 μs** |  **24.05 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  73.97 μs | 141.38 μs |  7.750 μs |  73.106 μs |  66.685 μs |  82.11 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.80 μs | 370.91 μs | 20.331 μs |  26.359 μs |  25.768 μs |  61.27 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.22 μs | 156.65 μs |  8.587 μs |  15.318 μs |  11.461 μs |  27.88 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.31 μs | 252.76 μs | 13.855 μs |  43.922 μs |  42.719 μs |  67.30 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  14.01 μs | 180.16 μs |  9.875 μs |   9.136 μs |   7.524 μs |  25.38 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.21 μs | 252.29 μs | 13.829 μs |  28.573 μs |  27.891 μs |  52.18 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.88 μs** | **343.82 μs** | **18.846 μs** |  **12.123 μs** |  **11.883 μs** |  **44.64 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 303.54 μs | 334.85 μs | 18.354 μs | 299.619 μs | 287.457 μs | 323.53 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 177.22 μs | 148.92 μs |  8.163 μs | 173.067 μs | 171.965 μs | 186.62 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  64.55 μs | 241.03 μs | 13.212 μs |  64.820 μs |  51.205 μs |  77.62 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 247.71 μs | 641.67 μs | 35.172 μs | 252.661 μs | 210.322 μs | 280.14 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.62 μs | 207.86 μs | 11.393 μs |   9.593 μs |   8.501 μs |  28.76 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  91.34 μs | 570.15 μs | 31.252 μs |  79.758 μs |  67.526 μs | 126.73 μs |  68.69 KB |
