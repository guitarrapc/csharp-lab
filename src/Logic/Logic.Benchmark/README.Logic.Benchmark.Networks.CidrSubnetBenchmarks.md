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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **506.34 ns** |   **4.477 ns** |  **0.245 ns** |   **506.20 ns** |   **506.63 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   119.73 ns |   5.364 ns |  0.294 ns |   119.47 ns |   120.05 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   230.45 ns |  17.786 ns |  0.975 ns |   229.38 ns |   231.29 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    40.67 ns |   9.251 ns |  0.507 ns |    40.12 ns |    41.12 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   148.20 ns |   6.730 ns |  0.369 ns |   147.80 ns |   148.52 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    54.12 ns |  14.828 ns |  0.813 ns |    53.48 ns |    55.03 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   438.49 ns |  30.392 ns |  1.666 ns |   436.63 ns |   439.84 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    99.77 ns |  14.600 ns |  0.800 ns |    98.89 ns |   100.46 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   245.86 ns |   8.779 ns |  0.481 ns |   245.53 ns |   246.41 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    42.54 ns |   3.661 ns |  0.201 ns |    42.35 ns |    42.75 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   146.57 ns |   8.808 ns |  0.483 ns |   146.23 ns |   147.12 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    32.47 ns |   8.002 ns |  0.439 ns |    31.97 ns |    32.80 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,591.37 ns** |  **90.691 ns** |  **4.971 ns** | **1,586.51 ns** | **1,596.45 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   347.21 ns |  29.488 ns |  1.616 ns |   345.63 ns |   348.86 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   723.96 ns | 206.477 ns | 11.318 ns |   711.95 ns |   734.43 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   123.21 ns |  24.991 ns |  1.370 ns |   121.70 ns |   124.38 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   440.26 ns |  53.930 ns |  2.956 ns |   436.93 ns |   442.59 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   165.03 ns |  28.016 ns |  1.536 ns |   163.36 ns |   166.39 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,400.44 ns | 107.995 ns |  5.920 ns | 1,393.61 ns | 1,404.01 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   296.97 ns |  40.331 ns |  2.211 ns |   295.10 ns |   299.41 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   765.46 ns |  50.550 ns |  2.771 ns |   763.75 ns |   768.66 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   131.56 ns |  75.139 ns |  4.119 ns |   127.23 ns |   135.44 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   437.13 ns |  35.287 ns |  1.934 ns |   435.92 ns |   439.36 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    94.48 ns |  27.321 ns |  1.498 ns |    92.78 ns |    95.60 ns | 0.0315 |     528 B |
