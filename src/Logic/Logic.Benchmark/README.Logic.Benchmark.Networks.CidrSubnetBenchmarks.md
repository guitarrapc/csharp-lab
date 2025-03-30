```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **503.12 ns** |  **49.199 ns** | **2.697 ns** |   **500.16 ns** |   **505.45 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   110.73 ns |  10.672 ns | 0.585 ns |   110.14 ns |   111.31 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   227.69 ns |  30.169 ns | 1.654 ns |   226.56 ns |   229.59 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.23 ns |   2.809 ns | 0.154 ns |    38.06 ns |    38.33 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   136.00 ns |  11.885 ns | 0.651 ns |   135.47 ns |   136.73 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.37 ns |   6.982 ns | 0.383 ns |    33.93 ns |    34.62 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   430.14 ns |  30.744 ns | 1.685 ns |   428.70 ns |   431.99 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.21 ns |  15.245 ns | 0.836 ns |    95.32 ns |    96.97 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   234.55 ns |  13.403 ns | 0.735 ns |   233.76 ns |   235.21 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.47 ns |   3.718 ns | 0.204 ns |    40.25 ns |    40.65 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.38 ns |  18.613 ns | 1.020 ns |   140.78 ns |   142.56 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.80 ns |   2.063 ns | 0.113 ns |    30.68 ns |    30.91 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,530.83 ns** |  **80.090 ns** | **4.390 ns** | **1,525.78 ns** | **1,533.74 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   334.22 ns |  17.603 ns | 0.965 ns |   333.21 ns |   335.13 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   699.45 ns | 151.379 ns | 8.298 ns |   690.06 ns |   705.82 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   116.03 ns |  11.165 ns | 0.612 ns |   115.35 ns |   116.54 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   413.19 ns |  37.045 ns | 2.031 ns |   410.96 ns |   414.93 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   105.74 ns |  36.959 ns | 2.026 ns |   103.51 ns |   107.45 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,364.22 ns | 178.386 ns | 9.778 ns | 1,354.53 ns | 1,374.08 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   297.44 ns |  24.132 ns | 1.323 ns |   296.20 ns |   298.84 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   723.59 ns |  37.972 ns | 2.081 ns |   722.02 ns |   725.95 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   119.39 ns |  30.664 ns | 1.681 ns |   118.24 ns |   121.32 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   439.44 ns |  70.165 ns | 3.846 ns |   436.13 ns |   443.66 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    89.42 ns |  22.620 ns | 1.240 ns |    88.02 ns |    90.38 ns | 0.0315 |     528 B |
