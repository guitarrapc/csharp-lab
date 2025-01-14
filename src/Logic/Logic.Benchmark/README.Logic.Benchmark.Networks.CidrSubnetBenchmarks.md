```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **461.66 ns** | **109.117 ns** |  **5.981 ns** |   **454.76 ns** |   **465.12 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |   104.92 ns |  29.794 ns |  1.633 ns |   103.21 ns |   106.46 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   251.26 ns |  57.699 ns |  3.163 ns |   249.03 ns |   254.88 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.47 ns |   6.618 ns |  0.363 ns |    42.06 ns |    42.72 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.92 ns |   6.872 ns |  0.377 ns |   144.55 ns |   145.31 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    31.04 ns |   8.406 ns |  0.461 ns |    30.77 ns |    31.57 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,434.04 ns** | **259.375 ns** | **14.217 ns** | **1,419.51 ns** | **1,447.92 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   286.64 ns |  77.784 ns |  4.264 ns |   282.54 ns |   291.05 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   731.57 ns |  27.496 ns |  1.507 ns |   729.84 ns |   732.55 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   132.22 ns |  31.410 ns |  1.722 ns |   131.04 ns |   134.20 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   443.47 ns |  58.000 ns |  3.179 ns |   439.94 ns |   446.11 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    90.89 ns |  38.880 ns |  2.131 ns |    89.41 ns |    93.34 ns | 0.0315 |     528 B |
