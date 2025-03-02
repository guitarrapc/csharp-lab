```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **510.38 ns** |  **69.456 ns** |  **3.807 ns** |   **506.03 ns** |   **513.13 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   109.33 ns |   7.901 ns |  0.433 ns |   108.90 ns |   109.77 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   227.16 ns |  46.141 ns |  2.529 ns |   225.16 ns |   230.01 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.67 ns |   4.085 ns |  0.224 ns |    37.49 ns |    37.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   142.23 ns |   8.525 ns |  0.467 ns |   141.70 ns |   142.60 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.03 ns |   1.536 ns |  0.084 ns |    33.94 ns |    34.11 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   441.28 ns |  26.850 ns |  1.472 ns |   439.83 ns |   442.77 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.65 ns |   4.634 ns |  0.254 ns |    94.36 ns |    94.80 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   231.14 ns |   5.599 ns |  0.307 ns |   230.86 ns |   231.46 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.37 ns |   2.578 ns |  0.141 ns |    40.26 ns |    40.53 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   143.25 ns |  21.178 ns |  1.161 ns |   141.92 ns |   144.06 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.94 ns |   2.730 ns |  0.150 ns |    29.81 ns |    30.11 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,523.24 ns** | **105.780 ns** |  **5.798 ns** | **1,519.51 ns** | **1,529.92 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   332.64 ns |  18.806 ns |  1.031 ns |   331.51 ns |   333.53 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   682.60 ns |  34.453 ns |  1.889 ns |   680.65 ns |   684.42 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   118.12 ns |  15.781 ns |  0.865 ns |   117.22 ns |   118.95 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   429.87 ns |  22.963 ns |  1.259 ns |   428.42 ns |   430.68 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   101.35 ns |  11.263 ns |  0.617 ns |   100.93 ns |   102.06 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,363.21 ns | 261.217 ns | 14.318 ns | 1,353.55 ns | 1,379.66 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   282.71 ns |   4.085 ns |  0.224 ns |   282.45 ns |   282.87 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   690.30 ns |  81.900 ns |  4.489 ns |   687.57 ns |   695.48 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   122.11 ns |  29.640 ns |  1.625 ns |   120.52 ns |   123.76 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   439.36 ns |  56.479 ns |  3.096 ns |   437.30 ns |   442.92 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |   105.94 ns |  29.994 ns |  1.644 ns |   104.06 ns |   107.10 ns | 0.0315 |     528 B |
