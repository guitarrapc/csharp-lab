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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **491.17 ns** |  **83.472 ns** |  **4.575 ns** |   **486.11 ns** |   **495.00 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   108.52 ns |   5.415 ns |  0.297 ns |   108.19 ns |   108.74 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   245.57 ns |  36.201 ns |  1.984 ns |   244.29 ns |   247.85 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.59 ns |   3.004 ns |  0.165 ns |    38.49 ns |    38.78 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   134.94 ns |  15.111 ns |  0.828 ns |   134.07 ns |   135.72 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.57 ns |   6.657 ns |  0.365 ns |    34.15 ns |    34.84 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   443.74 ns |  39.486 ns |  2.164 ns |   441.25 ns |   445.13 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    93.76 ns |   0.535 ns |  0.029 ns |    93.73 ns |    93.79 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   239.25 ns |  21.331 ns |  1.169 ns |   238.51 ns |   240.60 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.18 ns |  11.048 ns |  0.606 ns |    40.64 ns |    41.83 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   144.78 ns |  10.418 ns |  0.571 ns |   144.20 ns |   145.35 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.75 ns |   4.426 ns |  0.243 ns |    29.55 ns |    30.02 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,568.35 ns** |  **67.774 ns** |  **3.715 ns** | **1,565.39 ns** | **1,572.52 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   330.28 ns |  20.341 ns |  1.115 ns |   329.24 ns |   331.46 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   704.22 ns | 129.173 ns |  7.080 ns |   698.24 ns |   712.04 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   117.99 ns |   7.187 ns |  0.394 ns |   117.71 ns |   118.44 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   423.80 ns |  88.119 ns |  4.830 ns |   418.60 ns |   428.14 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   103.56 ns |   1.510 ns |  0.083 ns |   103.47 ns |   103.62 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,399.82 ns | 222.286 ns | 12.184 ns | 1,386.56 ns | 1,410.53 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   285.82 ns |  33.617 ns |  1.843 ns |   284.06 ns |   287.73 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   719.87 ns |  65.582 ns |  3.595 ns |   715.83 ns |   722.73 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   134.79 ns |   3.523 ns |  0.193 ns |   134.63 ns |   135.00 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   444.86 ns |  57.243 ns |  3.138 ns |   441.42 ns |   447.57 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    90.55 ns |   5.804 ns |  0.318 ns |    90.22 ns |    90.85 ns | 0.0315 |     528 B |
