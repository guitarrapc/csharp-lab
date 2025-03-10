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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **501.13 ns** | **117.331 ns** |  **6.431 ns** |   **496.44 ns** |   **508.46 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   112.27 ns |  14.793 ns |  0.811 ns |   111.38 ns |   112.97 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   241.84 ns |  15.639 ns |  0.857 ns |   240.98 ns |   242.70 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    40.16 ns |   8.464 ns |  0.464 ns |    39.69 ns |    40.61 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   155.60 ns |  28.626 ns |  1.569 ns |   153.80 ns |   156.68 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    35.72 ns |   3.633 ns |  0.199 ns |    35.55 ns |    35.94 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   435.09 ns |  57.507 ns |  3.152 ns |   431.77 ns |   438.04 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.37 ns |  21.975 ns |  1.205 ns |    95.30 ns |    97.67 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   247.56 ns |  11.617 ns |  0.637 ns |   246.95 ns |   248.22 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.41 ns |   6.634 ns |  0.364 ns |    40.01 ns |    40.73 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   145.48 ns |   9.928 ns |  0.544 ns |   144.87 ns |   145.92 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.76 ns |   3.862 ns |  0.212 ns |    31.61 ns |    32.00 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,568.58 ns** |  **30.712 ns** |  **1.683 ns** | **1,566.64 ns** | **1,569.68 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   336.33 ns |  25.630 ns |  1.405 ns |   334.71 ns |   337.18 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   702.55 ns | 124.146 ns |  6.805 ns |   697.07 ns |   710.17 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   121.58 ns |  24.548 ns |  1.346 ns |   120.25 ns |   122.94 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   422.78 ns |  68.361 ns |  3.747 ns |   420.08 ns |   427.06 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   104.09 ns |   2.832 ns |  0.155 ns |   103.98 ns |   104.27 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,383.82 ns | 214.759 ns | 11.772 ns | 1,374.12 ns | 1,396.92 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   291.67 ns |  26.764 ns |  1.467 ns |   290.06 ns |   292.93 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   718.85 ns |  26.090 ns |  1.430 ns |   717.91 ns |   720.50 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   121.12 ns |   5.960 ns |  0.327 ns |   120.87 ns |   121.49 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   442.72 ns |  29.115 ns |  1.596 ns |   441.04 ns |   444.21 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    89.86 ns |  23.474 ns |  1.287 ns |    88.38 ns |    90.76 ns | 0.0315 |     528 B |
