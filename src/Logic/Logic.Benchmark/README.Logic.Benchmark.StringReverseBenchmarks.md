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
| **ArrayReverse**           | **10**     | **100**    |  **14.88 μs** | **162.01 μs** |  **8.880 μs** |  **11.932 μs** |   **7.844 μs** |  **24.86 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  87.35 μs | 188.86 μs | 10.352 μs |  84.527 μs |  78.706 μs |  98.82 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  47.36 μs | 367.61 μs | 20.150 μs |  36.698 μs |  34.784 μs |  70.60 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.31 μs | 142.62 μs |  7.817 μs |  14.763 μs |  11.086 μs |  26.09 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  65.82 μs | 300.76 μs | 16.486 μs |  57.246 μs |  55.392 μs |  84.83 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  16.55 μs | 205.56 μs | 11.267 μs |  10.374 μs |   9.712 μs |  29.55 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.48 μs | 264.05 μs | 14.473 μs |  28.464 μs |  27.792 μs |  53.19 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.07 μs** | **291.33 μs** | **15.969 μs** |   **9.007 μs** |   **8.696 μs** |  **36.51 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 322.93 μs | 781.96 μs | 42.862 μs | 300.860 μs | 295.591 μs | 372.32 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 181.33 μs | 182.23 μs |  9.989 μs | 181.198 μs | 171.410 μs | 191.39 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  72.94 μs | 272.46 μs | 14.934 μs |  69.215 μs |  60.218 μs |  89.38 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 241.57 μs | 523.02 μs | 28.668 μs | 242.211 μs | 212.586 μs | 269.91 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.00 μs | 199.04 μs | 10.910 μs |   9.096 μs |   8.316 μs |  27.59 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.15 μs | 535.57 μs | 29.356 μs |  70.421 μs |  68.017 μs | 120.02 μs |  68.69 KB |
