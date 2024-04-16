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
| **ArrayReverse**           | **10**     | **100**    |  **17.28 μs** | **199.01 μs** | **10.909 μs** |  **11.741 μs** |  **10.249 μs** |  **29.84 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  72.11 μs | 145.10 μs |  7.953 μs |  69.454 μs |  65.817 μs |  81.05 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  37.17 μs | 343.01 μs | 18.802 μs |  27.050 μs |  25.587 μs |  58.86 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.05 μs | 161.87 μs |  8.873 μs |  15.169 μs |  10.971 μs |  28.00 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.61 μs | 301.75 μs | 16.540 μs |  44.583 μs |  43.541 μs |  72.70 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.22 μs | 185.21 μs | 10.152 μs |   7.484 μs |   7.243 μs |  24.95 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.79 μs | 254.82 μs | 13.967 μs |  29.785 μs |  27.701 μs |  52.87 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.20 μs** | **269.24 μs** | **14.758 μs** |  **10.084 μs** |   **9.272 μs** |  **35.23 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 304.06 μs | 312.82 μs | 17.147 μs | 300.281 μs | 289.120 μs | 322.78 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 203.41 μs | 909.05 μs | 49.828 μs | 175.347 μs | 173.934 μs | 260.94 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  61.78 μs | 230.52 μs | 12.636 μs |  60.222 μs |  49.993 μs |  75.12 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 239.55 μs | 517.91 μs | 28.389 μs | 237.164 μs | 212.437 μs | 269.06 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.53 μs | 234.55 μs | 12.857 μs |   8.530 μs |   7.699 μs |  30.37 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.35 μs | 539.43 μs | 29.568 μs |  69.940 μs |  68.627 μs | 120.48 μs |  68.69 KB |
