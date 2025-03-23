```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **487.16 ns** |  **26.797 ns** |  **1.469 ns** |   **486.22 ns** |   **488.85 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   110.87 ns |   5.203 ns |  0.285 ns |   110.63 ns |   111.19 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   232.52 ns |  17.154 ns |  0.940 ns |   231.44 ns |   233.20 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.43 ns |   2.588 ns |  0.142 ns |    38.29 ns |    38.58 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   143.76 ns |   7.106 ns |  0.390 ns |   143.53 ns |   144.21 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.81 ns |   2.056 ns |  0.113 ns |    34.70 ns |    34.92 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   440.77 ns |  38.580 ns |  2.115 ns |   438.43 ns |   442.55 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.36 ns |   1.556 ns |  0.085 ns |    96.28 ns |    96.45 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   237.47 ns |  13.099 ns |  0.718 ns |   237.02 ns |   238.30 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.68 ns |   8.486 ns |  0.465 ns |    40.29 ns |    41.19 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.38 ns |   7.620 ns |  0.418 ns |   140.90 ns |   141.67 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.24 ns |   2.018 ns |  0.111 ns |    30.12 ns |    30.33 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,585.72 ns** | **207.431 ns** | **11.370 ns** | **1,572.66 ns** | **1,593.42 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   328.00 ns |  10.236 ns |  0.561 ns |   327.41 ns |   328.52 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   697.98 ns |  35.351 ns |  1.938 ns |   696.08 ns |   699.95 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   116.31 ns |  32.372 ns |  1.774 ns |   114.92 ns |   118.31 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   441.06 ns |  75.412 ns |  4.134 ns |   437.11 ns |   445.36 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   103.27 ns |   9.671 ns |  0.530 ns |   102.72 ns |   103.78 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,372.05 ns | 225.486 ns | 12.360 ns | 1,359.30 ns | 1,383.97 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   291.98 ns |   9.317 ns |  0.511 ns |   291.46 ns |   292.49 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   706.13 ns | 125.762 ns |  6.893 ns |   698.34 ns |   711.44 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   118.74 ns |  11.936 ns |  0.654 ns |   117.99 ns |   119.16 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   436.64 ns |  69.023 ns |  3.783 ns |   433.26 ns |   440.72 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    88.36 ns |  20.972 ns |  1.150 ns |    87.23 ns |    89.53 ns | 0.0315 |     528 B |
