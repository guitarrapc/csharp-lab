```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **499.76 ns** |    **72.391 ns** |  **3.968 ns** |   **496.83 ns** |   **504.28 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   119.06 ns |     4.618 ns |  0.253 ns |   118.84 ns |   119.34 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   230.57 ns |     5.289 ns |  0.290 ns |   230.26 ns |   230.83 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.74 ns |     1.864 ns |  0.102 ns |    37.62 ns |    37.80 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   145.87 ns |    61.838 ns |  3.390 ns |   143.74 ns |   149.77 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.51 ns |    17.660 ns |  0.968 ns |    33.85 ns |    35.62 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   440.25 ns |    47.345 ns |  2.595 ns |   437.93 ns |   443.05 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    99.09 ns |     1.109 ns |  0.061 ns |    99.04 ns |    99.15 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   233.41 ns |    71.082 ns |  3.896 ns |   230.23 ns |   237.75 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.37 ns |     9.466 ns |  0.519 ns |    39.88 ns |    40.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.42 ns |     7.554 ns |  0.414 ns |   141.01 ns |   141.84 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.33 ns |     5.573 ns |  0.305 ns |    30.10 ns |    30.68 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,591.63 ns** | **1,026.365 ns** | **56.259 ns** | **1,546.74 ns** | **1,654.74 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   338.53 ns |    44.455 ns |  2.437 ns |   335.71 ns |   340.01 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   689.35 ns |   321.053 ns | 17.598 ns |   675.11 ns |   709.03 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   117.85 ns |    12.527 ns |  0.687 ns |   117.26 ns |   118.60 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   404.53 ns |    20.113 ns |  1.102 ns |   403.37 ns |   405.56 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.83 ns |     8.786 ns |  0.482 ns |   102.37 ns |   103.33 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,344.32 ns |    77.421 ns |  4.244 ns | 1,339.52 ns | 1,347.56 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   286.75 ns |    95.746 ns |  5.248 ns |   280.74 ns |   290.40 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   728.72 ns |   147.216 ns |  8.069 ns |   722.06 ns |   737.70 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   121.73 ns |    13.140 ns |  0.720 ns |   120.90 ns |   122.19 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   437.70 ns |    40.365 ns |  2.213 ns |   435.16 ns |   439.22 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    92.11 ns |    66.531 ns |  3.647 ns |    88.20 ns |    95.42 ns | 0.0315 |     528 B |
