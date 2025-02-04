```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **438.46 ns** |   **6.020 ns** |  **0.330 ns** |   **438.09 ns** |   **438.72 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    93.28 ns |   5.316 ns |  0.291 ns |    93.09 ns |    93.61 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   229.00 ns |   4.864 ns |  0.267 ns |   228.82 ns |   229.31 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.04 ns |   3.479 ns |  0.191 ns |    39.83 ns |    40.21 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.65 ns |   1.978 ns |  0.108 ns |   141.56 ns |   141.77 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    33.13 ns |   1.758 ns |  0.096 ns |    33.02 ns |    33.19 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,411.45 ns** | **249.925 ns** | **13.699 ns** | **1,396.29 ns** | **1,422.94 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   282.06 ns |   4.233 ns |  0.232 ns |   281.84 ns |   282.30 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   732.36 ns |   8.527 ns |  0.467 ns |   731.83 ns |   732.71 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   118.08 ns |  11.980 ns |  0.657 ns |   117.34 ns |   118.57 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   432.28 ns |  64.540 ns |  3.538 ns |   429.82 ns |   436.33 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    89.44 ns |  26.755 ns |  1.467 ns |    87.78 ns |    90.57 ns | 0.0315 |     528 B |
