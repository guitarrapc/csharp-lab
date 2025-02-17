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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **504.26 ns** |  **37.373 ns** |  **2.049 ns** |   **502.95 ns** |   **506.62 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   112.23 ns |  17.346 ns |  0.951 ns |   111.27 ns |   113.17 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   226.81 ns |  65.837 ns |  3.609 ns |   223.77 ns |   230.80 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.51 ns |   3.057 ns |  0.168 ns |    38.41 ns |    38.71 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   142.72 ns |  43.344 ns |  2.376 ns |   141.26 ns |   145.47 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    36.95 ns |  14.348 ns |  0.786 ns |    36.06 ns |    37.54 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   423.93 ns | 116.273 ns |  6.373 ns |   416.59 ns |   428.01 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.32 ns |   4.907 ns |  0.269 ns |    96.01 ns |    96.49 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   243.19 ns |  16.056 ns |  0.880 ns |   242.44 ns |   244.16 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    42.56 ns |  19.613 ns |  1.075 ns |    41.50 ns |    43.65 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   144.01 ns |  27.765 ns |  1.522 ns |   142.37 ns |   145.39 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    36.47 ns |  12.677 ns |  0.695 ns |    35.75 ns |    37.13 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,520.54 ns** |  **58.686 ns** |  **3.217 ns** | **1,517.08 ns** | **1,523.44 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   335.11 ns |   7.190 ns |  0.394 ns |   334.74 ns |   335.53 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   702.50 ns | 116.247 ns |  6.372 ns |   696.81 ns |   709.38 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   118.40 ns |  32.124 ns |  1.761 ns |   116.67 ns |   120.19 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   410.61 ns |  27.150 ns |  1.488 ns |   409.46 ns |   412.29 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   104.62 ns |  31.831 ns |  1.745 ns |   102.68 ns |   106.07 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,515.67 ns | 214.281 ns | 11.745 ns | 1,504.29 ns | 1,527.75 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   292.75 ns |  11.378 ns |  0.624 ns |   292.23 ns |   293.44 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   759.19 ns |  42.936 ns |  2.353 ns |   756.73 ns |   761.42 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   128.41 ns |  43.330 ns |  2.375 ns |   126.93 ns |   131.15 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   453.82 ns |   6.486 ns |  0.356 ns |   453.41 ns |   454.05 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    94.30 ns |  40.753 ns |  2.234 ns |    91.73 ns |    95.74 ns | 0.0315 |     528 B |
