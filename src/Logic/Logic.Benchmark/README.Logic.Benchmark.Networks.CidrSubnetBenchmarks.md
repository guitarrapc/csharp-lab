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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **517.84 ns** | **184.698 ns** | **10.124 ns** |   **506.92 ns** |   **526.91 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   113.33 ns |  15.674 ns |  0.859 ns |   112.61 ns |   114.28 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   231.60 ns |  46.182 ns |  2.531 ns |   228.68 ns |   233.08 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    39.70 ns |  18.226 ns |  0.999 ns |    38.55 ns |    40.33 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   150.91 ns |   3.924 ns |  0.215 ns |   150.66 ns |   151.04 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    36.41 ns |   3.606 ns |  0.198 ns |    36.24 ns |    36.63 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   457.95 ns |  55.083 ns |  3.019 ns |   455.55 ns |   461.34 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    98.85 ns |  14.734 ns |  0.808 ns |    97.93 ns |    99.40 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   252.10 ns |  16.856 ns |  0.924 ns |   251.25 ns |   253.08 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.58 ns |  15.164 ns |  0.831 ns |    40.73 ns |    42.39 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   144.85 ns |  14.954 ns |  0.820 ns |   143.91 ns |   145.44 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.91 ns |   0.877 ns |  0.048 ns |    30.86 ns |    30.95 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,610.85 ns** |  **64.599 ns** |  **3.541 ns** | **1,608.49 ns** | **1,614.92 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   337.41 ns |  15.263 ns |  0.837 ns |   336.92 ns |   338.37 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   748.80 ns |  67.795 ns |  3.716 ns |   744.95 ns |   752.37 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   120.11 ns |  29.248 ns |  1.603 ns |   118.63 ns |   121.81 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   417.22 ns |  40.242 ns |  2.206 ns |   414.79 ns |   419.10 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   105.96 ns |  25.011 ns |  1.371 ns |   104.61 ns |   107.35 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,425.74 ns | 342.114 ns | 18.752 ns | 1,406.27 ns | 1,443.68 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   289.90 ns |  21.205 ns |  1.162 ns |   288.83 ns |   291.13 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   735.25 ns |  66.257 ns |  3.632 ns |   731.11 ns |   737.90 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   122.72 ns |  52.096 ns |  2.856 ns |   120.08 ns |   125.75 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   448.51 ns |  39.370 ns |  2.158 ns |   446.23 ns |   450.52 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    94.91 ns |   7.808 ns |  0.428 ns |    94.56 ns |    95.39 ns | 0.0315 |     528 B |
