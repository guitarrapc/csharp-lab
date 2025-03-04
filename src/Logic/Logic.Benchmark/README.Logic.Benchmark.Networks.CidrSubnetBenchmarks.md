```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **488.77 ns** |  **51.198 ns** |  **2.806 ns** |   **486.58 ns** |   **491.93 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   114.36 ns |   6.122 ns |  0.336 ns |   114.00 ns |   114.66 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   231.21 ns |  28.431 ns |  1.558 ns |   229.81 ns |   232.89 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    39.42 ns |   9.193 ns |  0.504 ns |    38.87 ns |    39.86 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   134.71 ns |   4.836 ns |  0.265 ns |   134.43 ns |   134.96 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.51 ns |   4.709 ns |  0.258 ns |    34.21 ns |    34.69 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   428.33 ns |  11.298 ns |  0.619 ns |   427.81 ns |   429.01 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    99.76 ns |   6.352 ns |  0.348 ns |    99.55 ns |   100.17 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   240.37 ns |  39.704 ns |  2.176 ns |   238.48 ns |   242.75 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.49 ns |   2.542 ns |  0.139 ns |    40.34 ns |    40.62 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.94 ns |   3.527 ns |  0.193 ns |   141.74 ns |   142.12 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    34.15 ns |   4.458 ns |  0.244 ns |    33.96 ns |    34.43 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,571.32 ns** |  **36.286 ns** |  **1.989 ns** | **1,569.13 ns** | **1,573.00 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   354.41 ns | 327.718 ns | 17.963 ns |   335.12 ns |   370.65 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   726.97 ns |  19.580 ns |  1.073 ns |   725.75 ns |   727.75 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   126.76 ns | 165.588 ns |  9.076 ns |   120.47 ns |   137.17 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   436.01 ns |  12.366 ns |  0.678 ns |   435.42 ns |   436.75 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   122.72 ns |   3.930 ns |  0.215 ns |   122.48 ns |   122.90 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,468.45 ns | 374.125 ns | 20.507 ns | 1,454.00 ns | 1,491.92 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   298.93 ns | 133.259 ns |  7.304 ns |   290.59 ns |   304.17 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   786.54 ns |  17.437 ns |  0.956 ns |   785.45 ns |   787.20 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   138.76 ns |  16.690 ns |  0.915 ns |   137.70 ns |   139.33 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   464.68 ns |  71.627 ns |  3.926 ns |   460.40 ns |   468.11 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |   106.27 ns |  10.848 ns |  0.595 ns |   105.61 ns |   106.77 ns | 0.0315 |     528 B |
