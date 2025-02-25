```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **500.13 ns** |  **34.727 ns** |  **1.904 ns** |   **498.00 ns** |   **501.66 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   111.14 ns |   1.131 ns |  0.062 ns |   111.08 ns |   111.20 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   232.14 ns |  23.095 ns |  1.266 ns |   230.92 ns |   233.45 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.15 ns |   1.002 ns |  0.055 ns |    38.11 ns |    38.22 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   142.78 ns |   7.808 ns |  0.428 ns |   142.34 ns |   143.19 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.28 ns |   3.005 ns |  0.165 ns |    34.11 ns |    34.44 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   442.93 ns |   9.179 ns |  0.503 ns |   442.35 ns |   443.29 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    95.52 ns |   6.900 ns |  0.378 ns |    95.14 ns |    95.90 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   235.89 ns |  29.745 ns |  1.630 ns |   234.65 ns |   237.73 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.05 ns |  10.066 ns |  0.552 ns |    40.42 ns |    41.43 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   138.73 ns |  11.416 ns |  0.626 ns |   138.35 ns |   139.45 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.22 ns |   6.975 ns |  0.382 ns |    29.81 ns |    30.57 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,557.62 ns** | **191.047 ns** | **10.472 ns** | **1,545.85 ns** | **1,565.92 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   330.82 ns |   3.299 ns |  0.181 ns |   330.67 ns |   331.02 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   704.98 ns | 168.803 ns |  9.253 ns |   695.04 ns |   713.33 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   118.81 ns |  19.906 ns |  1.091 ns |   117.59 ns |   119.69 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   441.65 ns |   4.880 ns |  0.268 ns |   441.48 ns |   441.96 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   106.35 ns |  26.447 ns |  1.450 ns |   104.91 ns |   107.81 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,385.26 ns |  32.746 ns |  1.795 ns | 1,383.93 ns | 1,387.31 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   290.60 ns |  26.583 ns |  1.457 ns |   288.97 ns |   291.77 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   703.05 ns |  26.499 ns |  1.452 ns |   701.65 ns |   704.55 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   120.76 ns |  11.076 ns |  0.607 ns |   120.12 ns |   121.32 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   441.40 ns |  62.187 ns |  3.409 ns |   439.18 ns |   445.32 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    88.71 ns |   3.813 ns |  0.209 ns |    88.47 ns |    88.86 ns | 0.0315 |     528 B |
