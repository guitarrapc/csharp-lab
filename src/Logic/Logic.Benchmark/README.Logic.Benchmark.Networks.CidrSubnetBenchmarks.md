```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **493.38 ns** |  **64.582 ns** | **3.540 ns** |   **489.30 ns** |   **495.68 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   107.80 ns |  12.554 ns | 0.688 ns |   107.34 ns |   108.59 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   224.57 ns |  13.260 ns | 0.727 ns |   224.03 ns |   225.40 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.95 ns |   8.131 ns | 0.446 ns |    37.64 ns |    38.46 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   136.32 ns |   9.756 ns | 0.535 ns |   135.94 ns |   136.93 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    33.75 ns |   4.165 ns | 0.228 ns |    33.49 ns |    33.92 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   427.17 ns |  48.740 ns | 2.672 ns |   425.11 ns |   430.19 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.57 ns |   4.431 ns | 0.243 ns |    94.37 ns |    94.84 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   232.68 ns |   6.340 ns | 0.347 ns |   232.46 ns |   233.08 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.54 ns |   3.457 ns | 0.190 ns |    40.32 ns |    40.66 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.53 ns |  27.234 ns | 1.493 ns |   140.52 ns |   143.25 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.04 ns |   0.556 ns | 0.030 ns |    30.02 ns |    30.08 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,498.16 ns** | **133.131 ns** | **7.297 ns** | **1,489.74 ns** | **1,502.56 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   330.08 ns |   7.311 ns | 0.401 ns |   329.83 ns |   330.54 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   700.08 ns |  55.957 ns | 3.067 ns |   696.75 ns |   702.79 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   115.34 ns |  42.462 ns | 2.327 ns |   113.07 ns |   117.72 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   412.80 ns |  37.799 ns | 2.072 ns |   411.60 ns |   415.19 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   103.04 ns |   7.620 ns | 0.418 ns |   102.69 ns |   103.50 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,378.46 ns |  63.640 ns | 3.488 ns | 1,375.63 ns | 1,382.36 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   282.56 ns |  18.550 ns | 1.017 ns |   281.66 ns |   283.66 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   699.41 ns |  68.604 ns | 3.760 ns |   696.88 ns |   703.73 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   122.39 ns |  33.840 ns | 1.855 ns |   120.47 ns |   124.17 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   441.11 ns |  19.760 ns | 1.083 ns |   439.86 ns |   441.77 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    90.21 ns |  24.168 ns | 1.325 ns |    89.14 ns |    91.70 ns | 0.0315 |     528 B |
