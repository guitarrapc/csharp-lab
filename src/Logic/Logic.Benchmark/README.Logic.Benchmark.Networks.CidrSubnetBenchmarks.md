```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **496.53 ns** |  **70.086 ns** |  **3.842 ns** |   **494.23 ns** |   **500.97 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   110.95 ns |   7.343 ns |  0.402 ns |   110.49 ns |   111.19 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   230.08 ns |  56.879 ns |  3.118 ns |   227.66 ns |   233.59 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    39.09 ns |  12.659 ns |  0.694 ns |    38.38 ns |    39.76 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   146.99 ns |  33.680 ns |  1.846 ns |   145.49 ns |   149.05 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    58.56 ns |  22.041 ns |  1.208 ns |    57.17 ns |    59.28 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   435.81 ns |  90.065 ns |  4.937 ns |   430.84 ns |   440.71 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    98.31 ns |  42.088 ns |  2.307 ns |    96.54 ns |   100.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   238.15 ns |  57.204 ns |  3.136 ns |   234.99 ns |   241.26 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    47.86 ns |  16.373 ns |  0.897 ns |    46.83 ns |    48.48 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   149.98 ns |   3.250 ns |  0.178 ns |   149.79 ns |   150.15 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.44 ns |   5.940 ns |  0.326 ns |    31.07 ns |    31.64 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,564.98 ns** | **274.099 ns** | **15.024 ns** | **1,548.77 ns** | **1,578.43 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   343.92 ns |  38.942 ns |  2.135 ns |   342.48 ns |   346.37 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   706.28 ns |  53.342 ns |  2.924 ns |   704.58 ns |   709.66 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   122.14 ns |  25.824 ns |  1.416 ns |   120.71 ns |   123.54 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   423.30 ns |  17.392 ns |  0.953 ns |   422.22 ns |   424.05 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   153.22 ns |  46.957 ns |  2.574 ns |   150.30 ns |   155.14 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,422.04 ns | 223.186 ns | 12.234 ns | 1,414.72 ns | 1,436.16 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   288.20 ns |  39.387 ns |  2.159 ns |   285.78 ns |   289.91 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   771.50 ns | 607.348 ns | 33.291 ns |   739.21 ns |   805.71 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   120.78 ns |  67.451 ns |  3.697 ns |   118.03 ns |   124.98 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   436.74 ns |   5.319 ns |  0.292 ns |   436.56 ns |   437.08 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    93.11 ns |  11.113 ns |  0.609 ns |    92.75 ns |    93.81 ns | 0.0315 |     528 B |
