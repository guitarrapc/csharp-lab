```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **14.72 μs** | **223.46 μs** | **12.249 μs** |   **7.714 μs** |   **7.584 μs** |  **28.86 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  81.04 μs | 222.11 μs | 12.175 μs |  81.972 μs |  68.427 μs |  92.72 μs |  25.72 KB |
| RecursiveReverse       | 10     | 100    |  50.16 μs | 370.29 μs | 20.297 μs |  40.886 μs |  36.157 μs |  73.44 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  21.30 μs | 203.84 μs | 11.173 μs |  14.997 μs |  14.707 μs |  34.20 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  51.80 μs | 225.70 μs | 12.371 μs |  45.004 μs |  44.323 μs |  66.08 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  13.91 μs | 202.42 μs | 11.095 μs |   7.874 μs |   7.133 μs |  26.71 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.84 μs | 271.70 μs | 14.893 μs |  28.372 μs |  28.122 μs |  54.04 μs |  28.84 KB |
| **ArrayReverse**           | **64**     | **100**    |  **17.14 μs** | **268.78 μs** | **14.733 μs** |   **8.722 μs** |   **8.540 μs** |  **34.15 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 316.30 μs | 548.87 μs | 30.086 μs | 315.719 μs | 286.504 μs | 346.67 μs |  59.31 KB |
| RecursiveReverse       | 64     | 100    | 150.94 μs |  27.18 μs |  1.490 μs | 150.762 μs | 149.539 μs | 152.50 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  61.47 μs | 220.59 μs | 12.092 μs |  59.981 μs |  50.193 μs |  74.24 μs |  30.41 KB |
| StackReverse           | 64     | 100    | 250.27 μs | 581.93 μs | 31.898 μs | 247.101 μs | 220.071 μs | 283.63 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.41 μs | 205.64 μs | 11.272 μs |   8.194 μs |   7.614 μs |  27.42 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  97.59 μs | 587.55 μs | 32.206 μs |  80.350 μs |  77.665 μs | 134.74 μs |  68.69 KB |
