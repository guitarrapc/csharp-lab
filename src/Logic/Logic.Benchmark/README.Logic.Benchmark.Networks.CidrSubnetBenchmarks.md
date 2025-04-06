```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **489.33 ns** | **25.466 ns** | **1.396 ns** |   **487.74 ns** |   **490.35 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   108.85 ns |  6.783 ns | 0.372 ns |   108.42 ns |   109.11 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   232.05 ns |  8.167 ns | 0.448 ns |   231.69 ns |   232.55 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.55 ns |  5.221 ns | 0.286 ns |    38.22 ns |    38.74 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   136.31 ns |  3.842 ns | 0.211 ns |   136.09 ns |   136.51 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.65 ns |  4.057 ns | 0.222 ns |    34.40 ns |    34.82 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   422.82 ns | 13.557 ns | 0.743 ns |   422.06 ns |   423.54 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.65 ns | 11.829 ns | 0.648 ns |    94.10 ns |    95.37 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   238.05 ns |  7.195 ns | 0.394 ns |   237.63 ns |   238.41 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.09 ns |  3.464 ns | 0.190 ns |    39.88 ns |    40.25 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   138.33 ns |  8.338 ns | 0.457 ns |   137.80 ns |   138.65 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.27 ns |  3.456 ns | 0.189 ns |    30.08 ns |    30.46 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,524.79 ns** | **70.753 ns** | **3.878 ns** | **1,520.63 ns** | **1,528.30 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   333.22 ns | 29.945 ns | 1.641 ns |   332.23 ns |   335.12 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   683.27 ns | 50.657 ns | 2.777 ns |   681.45 ns |   686.47 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   117.13 ns |  0.906 ns | 0.050 ns |   117.09 ns |   117.19 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   430.86 ns | 71.191 ns | 3.902 ns |   428.29 ns |   435.35 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   101.69 ns |  3.883 ns | 0.213 ns |   101.46 ns |   101.89 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,396.12 ns | 24.808 ns | 1.360 ns | 1,394.57 ns | 1,397.09 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   286.84 ns | 83.562 ns | 4.580 ns |   283.63 ns |   292.09 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   713.48 ns |  5.643 ns | 0.309 ns |   713.24 ns |   713.83 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   118.08 ns | 14.047 ns | 0.770 ns |   117.26 ns |   118.78 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   430.45 ns | 30.102 ns | 1.650 ns |   428.98 ns |   432.23 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    89.41 ns |  6.447 ns | 0.353 ns |    89.13 ns |    89.81 ns | 0.0315 |     528 B |
