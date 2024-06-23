```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.73 μs** | **202.81 μs** | **11.117 μs** |  **10.520 μs** |  **10.109 μs** |  **29.57 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  70.95 μs | 147.52 μs |  8.086 μs |  69.409 μs |  63.749 μs |  79.70 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  32.51 μs | 272.30 μs | 14.926 μs |  26.189 μs |  21.782 μs |  49.55 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  17.10 μs | 139.50 μs |  7.646 μs |  14.787 μs |  10.880 μs |  25.64 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.31 μs | 255.87 μs | 14.025 μs |  43.812 μs |  42.619 μs |  67.49 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.36 μs | 187.83 μs | 10.296 μs |   7.634 μs |   7.203 μs |  25.25 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  37.75 μs | 283.31 μs | 15.529 μs |  28.963 μs |  28.613 μs |  55.68 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **22.34 μs** | **352.83 μs** | **19.340 μs** |  **12.994 μs** |   **9.458 μs** |  **44.58 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 320.97 μs | 615.55 μs | 33.740 μs | 308.078 μs | 295.573 μs | 359.25 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 158.13 μs | 106.13 μs |  5.817 μs | 161.092 μs | 151.424 μs | 161.86 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  74.03 μs | 367.01 μs | 20.117 μs |  67.722 μs |  57.824 μs |  96.55 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 237.38 μs | 490.33 μs | 26.877 μs | 234.310 μs | 212.168 μs | 265.66 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.07 μs | 213.04 μs | 11.678 μs |   8.515 μs |   8.144 μs |  28.55 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    | 106.93 μs | 632.10 μs | 34.648 μs | 119.174 μs |  67.828 μs | 133.80 μs |  68.69 KB |
