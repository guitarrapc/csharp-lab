```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.19 μs** | **160.93 μs** |  **8.821 μs** |  **11.050 μs** |   **7.373 μs** |  **24.16 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  86.54 μs | 188.80 μs | 10.349 μs |  81.752 μs |  79.448 μs |  98.41 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  48.49 μs | 355.00 μs | 19.459 μs |  37.845 μs |  36.673 μs |  70.95 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  18.38 μs | 178.25 μs |  9.771 μs |  14.917 μs |  10.819 μs |  29.41 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  53.33 μs | 223.19 μs | 12.234 μs |  46.387 μs |  46.147 μs |  67.46 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.77 μs | 158.61 μs |  8.694 μs |   7.864 μs |   7.644 μs |  22.81 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.76 μs | 255.81 μs | 14.022 μs |  28.733 μs |  28.593 μs |  52.95 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **19.15 μs** | **253.96 μs** | **13.921 μs** |  **12.428 μs** |   **9.873 μs** |  **35.16 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 319.90 μs | 302.57 μs | 16.585 μs | 322.591 μs | 302.133 μs | 334.97 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 176.72 μs |  33.61 μs |  1.842 μs | 177.230 μs | 174.675 μs | 178.25 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  74.47 μs | 332.18 μs | 18.208 μs |  69.821 μs |  59.031 μs |  94.55 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 235.05 μs | 494.96 μs | 27.131 μs | 231.816 μs | 209.685 μs | 263.66 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  18.43 μs | 237.47 μs | 13.016 μs |  11.131 μs |  10.691 μs |  33.45 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  86.64 μs | 549.28 μs | 30.108 μs |  69.461 μs |  69.059 μs | 121.41 μs |  68.69 KB |
