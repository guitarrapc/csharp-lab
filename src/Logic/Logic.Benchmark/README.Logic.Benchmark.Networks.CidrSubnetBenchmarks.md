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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **518.22 ns** |  **28.273 ns** |  **1.550 ns** |   **516.69 ns** |   **519.79 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   115.00 ns |  12.385 ns |  0.679 ns |   114.23 ns |   115.51 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   233.70 ns |  18.791 ns |  1.030 ns |   232.63 ns |   234.69 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.98 ns |  10.856 ns |  0.595 ns |    37.55 ns |    38.66 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   162.12 ns |  29.150 ns |  1.598 ns |   160.40 ns |   163.56 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    37.56 ns |   9.828 ns |  0.539 ns |    37.00 ns |    38.08 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   444.32 ns |  34.736 ns |  1.904 ns |   442.49 ns |   446.29 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    97.17 ns |  31.523 ns |  1.728 ns |    95.18 ns |    98.27 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   234.22 ns |  15.214 ns |  0.834 ns |   233.56 ns |   235.16 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.88 ns |   6.246 ns |  0.342 ns |    41.48 ns |    42.09 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   144.57 ns |  14.833 ns |  0.813 ns |   144.03 ns |   145.51 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    32.95 ns |   5.485 ns |  0.301 ns |    32.73 ns |    33.29 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,537.04 ns** | **182.308 ns** |  **9.993 ns** | **1,529.54 ns** | **1,548.38 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   353.52 ns | 303.978 ns | 16.662 ns |   339.07 ns |   371.75 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   727.93 ns | 234.623 ns | 12.860 ns |   716.70 ns |   741.96 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   124.00 ns |  71.346 ns |  3.911 ns |   119.52 ns |   126.69 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   429.96 ns |  52.902 ns |  2.900 ns |   427.27 ns |   433.03 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   107.98 ns |  37.047 ns |  2.031 ns |   105.93 ns |   109.99 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,342.53 ns | 102.915 ns |  5.641 ns | 1,336.13 ns | 1,346.79 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   288.26 ns |   6.133 ns |  0.336 ns |   287.87 ns |   288.48 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   706.69 ns |  84.678 ns |  4.641 ns |   701.70 ns |   710.89 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   136.46 ns |  22.039 ns |  1.208 ns |   135.15 ns |   137.52 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   434.83 ns |   9.470 ns |  0.519 ns |   434.24 ns |   435.15 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    89.13 ns |  39.240 ns |  2.151 ns |    87.67 ns |    91.60 ns | 0.0315 |     528 B |
