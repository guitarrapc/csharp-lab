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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **510.15 ns** |  **27.471 ns** |  **1.506 ns** |   **508.46 ns** |   **511.33 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   113.79 ns |   2.690 ns |  0.147 ns |   113.65 ns |   113.94 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   239.48 ns |  47.773 ns |  2.619 ns |   237.18 ns |   242.33 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    41.56 ns |  15.126 ns |  0.829 ns |    40.70 ns |    42.35 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   146.01 ns |  12.853 ns |  0.705 ns |   145.22 ns |   146.58 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    35.10 ns |   2.189 ns |  0.120 ns |    34.97 ns |    35.19 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   466.39 ns |  60.706 ns |  3.327 ns |   462.81 ns |   469.38 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    97.65 ns |   3.525 ns |  0.193 ns |    97.43 ns |    97.76 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   241.54 ns |  10.048 ns |  0.551 ns |   241.08 ns |   242.15 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.24 ns |  13.649 ns |  0.748 ns |    40.38 ns |    41.75 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.37 ns |  28.737 ns |  1.575 ns |   139.84 ns |   142.99 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.00 ns |   3.797 ns |  0.208 ns |    30.82 ns |    31.23 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,543.42 ns** | **212.885 ns** | **11.669 ns** | **1,535.99 ns** | **1,556.87 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   338.92 ns | 125.188 ns |  6.862 ns |   334.72 ns |   346.84 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   712.44 ns |  44.504 ns |  2.439 ns |   709.63 ns |   713.91 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   118.36 ns |  21.569 ns |  1.182 ns |   117.10 ns |   119.45 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   425.39 ns |   5.860 ns |  0.321 ns |   425.05 ns |   425.68 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   111.47 ns |  48.318 ns |  2.648 ns |   108.43 ns |   113.28 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,381.54 ns | 132.167 ns |  7.245 ns | 1,373.53 ns | 1,387.62 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   286.63 ns |  17.514 ns |  0.960 ns |   286.03 ns |   287.74 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   720.17 ns | 141.849 ns |  7.775 ns |   714.90 ns |   729.10 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   121.26 ns |  29.535 ns |  1.619 ns |   119.55 ns |   122.77 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   441.87 ns |  25.014 ns |  1.371 ns |   440.34 ns |   442.99 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    92.62 ns |  56.990 ns |  3.124 ns |    89.50 ns |    95.74 ns | 0.0315 |     528 B |
