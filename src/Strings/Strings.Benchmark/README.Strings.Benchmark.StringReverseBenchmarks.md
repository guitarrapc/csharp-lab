```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **16.86 μs** | **219.38 μs** | **12.025 μs** |   **9.918 μs** |   **9.918 μs** |  **30.75 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  61.66 μs | 167.75 μs |  9.195 μs |  57.478 μs |  55.303 μs |  72.20 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  31.96 μs | 260.03 μs | 14.253 μs |  26.120 μs |  21.561 μs |  48.21 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  22.73 μs | 148.03 μs |  8.114 μs |  20.980 μs |  15.639 μs |  31.58 μs |   9.81 KB |
| StackReverse           | 10     | 100    |  60.31 μs | 396.80 μs | 21.750 μs |  53.620 μs |  42.690 μs |  84.62 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.36 μs | 172.44 μs |  9.452 μs |   6.912 μs |   6.892 μs |  23.27 μs |   5.13 KB |
| StringExtensionReverse | 10     | 100    |  36.58 μs | 107.78 μs |  5.908 μs |  34.444 μs |  32.039 μs |  43.26 μs |  17.63 KB |
| **ArrayReverse**           | **64**     | **100**    |  **24.56 μs** | **365.22 μs** | **20.019 μs** |  **13.755 μs** |  **12.262 μs** |  **47.66 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 127.35 μs | 239.83 μs | 13.146 μs | 120.966 μs | 118.611 μs | 142.47 μs |  37.94 KB |
| RecursiveReverse       | 64     | 100    | 143.87 μs |  39.00 μs |  2.138 μs | 144.468 μs | 141.493 μs | 145.64 μs | 560.59 KB |
| ReverseXor             | 64     | 100    |  73.81 μs | 473.18 μs | 25.936 μs |  67.847 μs |  51.376 μs | 102.21 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 229.97 μs | 543.69 μs | 29.801 μs | 226.681 μs | 201.946 μs | 261.28 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.55 μs | 195.98 μs | 10.742 μs |   8.928 μs |   7.794 μs |  26.94 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  85.22 μs | 234.86 μs | 12.874 μs |  86.051 μs |  71.955 μs |  97.66 μs |  38.22 KB |
