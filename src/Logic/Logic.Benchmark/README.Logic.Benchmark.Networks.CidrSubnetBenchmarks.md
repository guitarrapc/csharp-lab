```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **496.39 ns** |  **50.519 ns** | **2.769 ns** |   **494.33 ns** |   **499.54 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   112.16 ns |  14.423 ns | 0.791 ns |   111.42 ns |   112.99 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   230.87 ns |   8.884 ns | 0.487 ns |   230.35 ns |   231.32 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    39.32 ns |   3.797 ns | 0.208 ns |    39.16 ns |    39.56 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   134.86 ns |   7.275 ns | 0.399 ns |   134.56 ns |   135.31 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    33.82 ns |   0.562 ns | 0.031 ns |    33.79 ns |    33.86 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   421.17 ns | 111.314 ns | 6.101 ns |   414.41 ns |   426.27 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    92.98 ns |   4.900 ns | 0.269 ns |    92.67 ns |    93.16 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   226.21 ns |   7.500 ns | 0.411 ns |   225.73 ns |   226.49 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    39.89 ns |   0.883 ns | 0.048 ns |    39.86 ns |    39.95 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   139.11 ns |   3.681 ns | 0.202 ns |   138.88 ns |   139.26 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.34 ns |   3.863 ns | 0.212 ns |    29.12 ns |    29.54 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,516.22 ns** |  **20.571 ns** | **1.128 ns** | **1,515.27 ns** | **1,517.47 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   330.54 ns |  10.186 ns | 0.558 ns |   330.15 ns |   331.18 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   683.45 ns |  44.283 ns | 2.427 ns |   681.67 ns |   686.22 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   117.42 ns |  37.378 ns | 2.049 ns |   115.93 ns |   119.75 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   413.13 ns |  46.288 ns | 2.537 ns |   410.23 ns |   414.97 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   104.34 ns |   4.857 ns | 0.266 ns |   104.10 ns |   104.63 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,353.88 ns |  23.878 ns | 1.309 ns | 1,352.75 ns | 1,355.32 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   296.48 ns |  24.784 ns | 1.358 ns |   295.57 ns |   298.04 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   694.30 ns |  26.046 ns | 1.428 ns |   692.82 ns |   695.67 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   118.11 ns |   1.612 ns | 0.088 ns |   118.02 ns |   118.19 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   433.00 ns |  17.786 ns | 0.975 ns |   432.33 ns |   434.12 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    86.02 ns |   0.392 ns | 0.021 ns |    86.00 ns |    86.04 ns | 0.0315 |     528 B |
