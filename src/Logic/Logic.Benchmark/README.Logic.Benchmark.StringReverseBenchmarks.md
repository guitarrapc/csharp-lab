```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error      | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|-----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.16 μs** | **157.958 μs** |  **8.658 μs** |  **11.075 μs** |   **7.468 μs** |  **23.94 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  76.51 μs | 147.962 μs |  8.110 μs |  79.929 μs |  67.245 μs |  82.34 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  38.67 μs | 361.383 μs | 19.809 μs |  27.607 μs |  26.866 μs |  61.54 μs |  56.97 KB |
| ReverseXor             | 10     | 100    |  17.56 μs | 152.979 μs |  8.385 μs |  14.768 μs |  10.921 μs |  26.98 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.60 μs | 237.194 μs | 13.001 μs |  43.590 μs |  42.608 μs |  65.60 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.30 μs | 182.717 μs | 10.015 μs |   7.554 μs |   7.484 μs |  24.87 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  48.08 μs | 297.153 μs | 16.288 μs |  39.889 μs |  37.514 μs |  66.84 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.84 μs** | **269.136 μs** | **14.752 μs** |   **9.969 μs** |   **8.686 μs** |  **34.85 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 319.92 μs | 548.603 μs | 30.071 μs | 321.592 μs | 289.053 μs | 349.12 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 171.77 μs |   3.629 μs |  0.199 μs | 171.689 μs | 171.628 μs | 172.00 μs | 710.88 KB |
| ReverseXor             | 64     | 100    |  63.81 μs | 248.855 μs | 13.641 μs |  61.519 μs |  51.460 μs |  78.45 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 247.47 μs | 794.158 μs | 43.530 μs | 234.296 μs | 212.054 μs | 296.07 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  15.85 μs | 221.762 μs | 12.156 μs |   8.836 μs |   8.826 μs |  29.89 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  87.40 μs | 550.235 μs | 30.160 μs |  70.291 μs |  69.690 μs | 122.23 μs |  68.69 KB |
