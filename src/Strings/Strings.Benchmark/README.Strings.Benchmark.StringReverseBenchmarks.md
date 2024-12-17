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
| **ArrayReverse**           | **10**     | **100**    |  **12.46 μs** | **175.26 μs** |  **9.607 μs** |   **7.092 μs** |   **6.743 μs** |  **23.55 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  47.77 μs | 196.39 μs | 10.765 μs |  44.172 μs |  39.262 μs |  59.87 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  45.82 μs | 317.03 μs | 17.378 μs |  39.334 μs |  32.611 μs |  65.50 μs |  33.53 KB |
| ReverseXor             | 10     | 100    |  18.67 μs | 164.55 μs |  9.020 μs |  17.137 μs |  10.514 μs |  28.36 μs |  10.09 KB |
| StackReverse           | 10     | 100    |  50.20 μs | 250.82 μs | 13.748 μs |  42.630 μs |  41.908 μs |  66.07 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  15.45 μs | 213.54 μs | 11.705 μs |   8.976 μs |   8.415 μs |  28.96 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  51.04 μs | 312.92 μs | 17.152 μs |  42.701 μs |  39.645 μs |  70.76 μs |  17.91 KB |
| **ArrayReverse**           | **64**     | **100**    |  **21.73 μs** | **319.50 μs** | **17.513 μs** |  **11.963 μs** |  **11.281 μs** |  **41.95 μs** |  **30.13 KB** |
| EnumerableReverse      | 64     | 100    | 127.13 μs | 197.93 μs | 10.849 μs | 120.990 μs | 120.740 μs | 139.66 μs |  38.22 KB |
| RecursiveReverse       | 64     | 100    | 145.13 μs |  47.93 μs |  2.627 μs | 143.958 μs | 143.287 μs | 148.14 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  63.15 μs | 239.43 μs | 13.124 μs |  60.237 μs |  51.733 μs |  77.49 μs |  30.13 KB |
| StackReverse           | 64     | 100    | 230.67 μs | 551.67 μs | 30.239 μs | 227.945 μs | 201.886 μs | 262.18 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  14.49 μs | 206.75 μs | 11.333 μs |   8.100 μs |   7.800 μs |  27.58 μs |  15.56 KB |
| StringExtensionReverse | 64     | 100    |  74.88 μs | 241.30 μs | 13.226 μs |  67.937 μs |  66.565 μs |  90.13 μs |  38.22 KB |
