```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error       | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|------------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.24 μs** |   **148.50 μs** |  **8.140 μs** |  **11.751 μs** |   **7.634 μs** |  **23.33 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    | 117.40 μs |   341.87 μs | 18.739 μs | 117.870 μs |  98.424 μs | 135.89 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  75.55 μs | 1,168.93 μs | 64.073 μs |  51.937 μs |  26.630 μs | 148.08 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.54 μs |   173.98 μs |  9.536 μs |  15.468 μs |  10.919 μs |  29.23 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  54.94 μs |   234.60 μs | 12.859 μs |  48.161 μs |  46.888 μs |  69.77 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.42 μs |   153.29 μs |  8.402 μs |   7.664 μs |   7.473 μs |  22.12 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  35.16 μs |   233.52 μs | 12.800 μs |  28.294 μs |  27.251 μs |  49.92 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.37 μs** |   **294.96 μs** | **16.168 μs** |   **9.076 μs** |   **8.996 μs** |  **37.04 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 307.99 μs |   160.64 μs |  8.805 μs | 312.707 μs | 297.829 μs | 313.43 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 166.10 μs |   157.65 μs |  8.641 μs | 165.998 μs | 157.512 μs | 174.79 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.74 μs |   249.30 μs | 13.665 μs |  61.048 μs |  51.621 μs |  78.55 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.45 μs |   504.55 μs | 27.656 μs | 234.541 μs | 211.369 μs | 266.45 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.93 μs |   212.68 μs | 11.658 μs |   8.636 μs |   7.774 μs |  28.38 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  93.33 μs |   566.57 μs | 31.056 μs |  84.672 μs |  67.530 μs | 127.80 μs |  68.69 KB |
