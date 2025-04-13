```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **480.73 ns** |  **26.480 ns** |  **1.451 ns** |   **479.35 ns** |   **482.25 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   113.74 ns |  27.682 ns |  1.517 ns |   112.85 ns |   115.50 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   229.01 ns |  39.992 ns |  2.192 ns |   226.84 ns |   231.22 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.78 ns |   3.493 ns |  0.191 ns |    37.56 ns |    37.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   140.30 ns |   9.600 ns |  0.526 ns |   139.97 ns |   140.91 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    33.73 ns |   1.099 ns |  0.060 ns |    33.67 ns |    33.79 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   422.51 ns |  30.958 ns |  1.697 ns |   420.72 ns |   424.09 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    93.22 ns |   6.546 ns |  0.359 ns |    92.83 ns |    93.54 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   244.01 ns |  40.740 ns |  2.233 ns |   241.43 ns |   245.40 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    39.49 ns |   2.815 ns |  0.154 ns |    39.32 ns |    39.62 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   144.25 ns |  15.601 ns |  0.855 ns |   143.38 ns |   145.09 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.90 ns |   2.207 ns |  0.121 ns |    29.81 ns |    30.04 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,536.42 ns** |  **26.945 ns** |  **1.477 ns** | **1,535.55 ns** | **1,538.12 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   335.89 ns | 151.623 ns |  8.311 ns |   330.93 ns |   345.49 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   669.55 ns |  15.097 ns |  0.828 ns |   668.60 ns |   670.07 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   110.43 ns |  10.130 ns |  0.555 ns |   109.83 ns |   110.92 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   405.92 ns |  11.070 ns |  0.607 ns |   405.23 ns |   406.32 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |    99.00 ns |  17.483 ns |  0.958 ns |    98.10 ns |   100.01 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,310.79 ns | 148.080 ns |  8.117 ns | 1,302.08 ns | 1,318.14 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   287.05 ns |  77.765 ns |  4.263 ns |   283.08 ns |   291.55 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   712.47 ns | 187.935 ns | 10.301 ns |   700.86 ns |   720.54 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   129.03 ns |  23.943 ns |  1.312 ns |   128.17 ns |   130.54 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   435.87 ns |  45.755 ns |  2.508 ns |   433.23 ns |   438.22 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    87.97 ns |  10.684 ns |  0.586 ns |    87.32 ns |    88.46 ns | 0.0315 |     528 B |
