```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
| Method                 | Length | Number | Mean      | Error     | StdDev    | Median     | Min        | Max       | Allocated |
|----------------------- |------- |------- |----------:|----------:|----------:|-----------:|-----------:|----------:|----------:|
| **ArrayReverse**           | **10**     | **100**    |  **12.42 μs** | **161.18 μs** |  **8.835 μs** |   **7.641 μs** |   **7.009 μs** |  **22.62 μs** |  **10.09 KB** |
| EnumerableReverse      | 10     | 100    |  51.68 μs | 186.88 μs | 10.243 μs |  46.688 μs |  44.884 μs |  63.46 μs |  17.91 KB |
| RecursiveReverse       | 10     | 100    |  32.10 μs | 246.91 μs | 13.534 μs |  26.989 μs |  21.870 μs |  47.45 μs |  33.25 KB |
| ReverseXor             | 10     | 100    |  22.17 μs | 199.29 μs | 10.924 μs |  17.261 μs |  14.557 μs |  34.68 μs |   9.81 KB |
| StackReverse           | 10     | 100    |  53.78 μs | 260.64 μs | 14.287 μs |  46.406 μs |  44.694 μs |  70.25 μs |  31.19 KB |
| StringSpan             | 10     | 100    |  12.12 μs | 163.91 μs |  8.985 μs |   7.128 μs |   6.747 μs |  22.50 μs |   5.41 KB |
| StringExtensionReverse | 10     | 100    |  36.76 μs |  95.14 μs |  5.215 μs |  34.714 μs |  32.881 μs |  42.69 μs |  17.63 KB |
| **ArrayReverse**           | **64**     | **100**    |  **18.47 μs** | **261.57 μs** | **14.338 μs** |  **12.314 μs** |   **8.236 μs** |  **34.86 μs** |  **30.41 KB** |
| EnumerableReverse      | 64     | 100    | 140.00 μs | 341.05 μs | 18.694 μs | 141.484 μs | 120.605 μs | 157.91 μs |  37.94 KB |
| RecursiveReverse       | 64     | 100    | 159.94 μs | 225.69 μs | 12.371 μs | 160.239 μs | 147.425 μs | 172.16 μs | 560.88 KB |
| ReverseXor             | 64     | 100    |  66.18 μs | 198.76 μs | 10.894 μs |  65.844 μs |  55.464 μs |  77.24 μs |  30.13 KB |
| StackReverse           | 64     | 100    | 250.25 μs | 594.19 μs | 32.570 μs | 267.575 μs | 212.683 μs | 270.50 μs |  88.22 KB |
| StringSpan             | 64     | 100    |  17.55 μs | 263.88 μs | 14.464 μs |  10.559 μs |   7.914 μs |  34.18 μs |  15.28 KB |
| StringExtensionReverse | 64     | 100    |  77.25 μs | 207.93 μs | 11.397 μs |  70.882 μs |  70.461 μs |  90.41 μs |  38.22 KB |
