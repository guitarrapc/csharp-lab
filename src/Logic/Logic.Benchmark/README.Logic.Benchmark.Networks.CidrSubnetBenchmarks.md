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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **491.50 ns** |  **21.150 ns** |  **1.159 ns** |   **490.40 ns** |   **492.71 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   111.48 ns |   0.751 ns |  0.041 ns |   111.44 ns |   111.51 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   225.73 ns |  12.877 ns |  0.706 ns |   225.05 ns |   226.46 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.80 ns |   1.190 ns |  0.065 ns |    37.73 ns |    37.86 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   137.88 ns |  38.391 ns |  2.104 ns |   136.40 ns |   140.29 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.99 ns |   0.382 ns |  0.021 ns |    34.97 ns |    35.01 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   415.54 ns |  37.633 ns |  2.063 ns |   414.33 ns |   417.92 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.79 ns |   4.089 ns |  0.224 ns |    94.64 ns |    95.05 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   233.87 ns |  63.011 ns |  3.454 ns |   231.51 ns |   237.84 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.01 ns |   1.927 ns |  0.106 ns |    39.91 ns |    40.12 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   140.15 ns |   3.826 ns |  0.210 ns |   139.97 ns |   140.38 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.14 ns |   3.937 ns |  0.216 ns |    30.89 ns |    31.29 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,537.61 ns** |  **85.247 ns** |  **4.673 ns** | **1,533.11 ns** | **1,542.44 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   331.54 ns |  19.808 ns |  1.086 ns |   330.59 ns |   332.72 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   692.00 ns |  77.055 ns |  4.224 ns |   688.51 ns |   696.69 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   121.73 ns |  78.457 ns |  4.300 ns |   116.85 ns |   124.96 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   423.37 ns |  44.065 ns |  2.415 ns |   420.69 ns |   425.38 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   103.83 ns |   8.133 ns |  0.446 ns |   103.40 ns |   104.29 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,421.30 ns | 248.168 ns | 13.603 ns | 1,407.06 ns | 1,434.16 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   287.92 ns |  20.820 ns |  1.141 ns |   286.94 ns |   289.17 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   709.05 ns |  93.478 ns |  5.124 ns |   703.47 ns |   713.54 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   131.13 ns |  22.759 ns |  1.247 ns |   130.40 ns |   132.57 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   429.21 ns |  37.841 ns |  2.074 ns |   426.96 ns |   431.04 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    91.02 ns |  25.109 ns |  1.376 ns |    89.84 ns |    92.53 ns | 0.0315 |     528 B |
