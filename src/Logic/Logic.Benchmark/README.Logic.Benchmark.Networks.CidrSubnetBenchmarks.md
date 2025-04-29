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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **515.12 ns** | **519.952 ns** | **28.500 ns** |   **497.02 ns** |   **547.97 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   111.68 ns |   4.220 ns |  0.231 ns |   111.46 ns |   111.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   230.37 ns |  36.749 ns |  2.014 ns |   228.75 ns |   232.62 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    39.85 ns |  17.028 ns |  0.933 ns |    38.84 ns |    40.68 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   141.10 ns |   8.905 ns |  0.488 ns |   140.55 ns |   141.47 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    44.51 ns |   5.042 ns |  0.276 ns |    44.25 ns |    44.80 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   433.26 ns |  30.123 ns |  1.651 ns |   432.24 ns |   435.17 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.49 ns |  13.526 ns |  0.741 ns |    95.76 ns |    97.24 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   251.38 ns |   6.454 ns |  0.354 ns |   251.11 ns |   251.78 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.76 ns |   2.913 ns |  0.160 ns |    41.60 ns |    41.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   146.52 ns |  13.523 ns |  0.741 ns |   145.66 ns |   146.99 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    32.49 ns |  25.141 ns |  1.378 ns |    31.38 ns |    34.03 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,515.89 ns** |  **67.889 ns** |  **3.721 ns** | **1,511.69 ns** | **1,518.76 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   340.91 ns |  40.646 ns |  2.228 ns |   338.45 ns |   342.79 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   713.67 ns | 191.263 ns | 10.484 ns |   704.26 ns |   724.97 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   116.48 ns |  14.456 ns |  0.792 ns |   115.67 ns |   117.26 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   410.48 ns |  32.148 ns |  1.762 ns |   408.77 ns |   412.29 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.83 ns |  27.946 ns |  1.532 ns |   101.20 ns |   104.25 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,370.30 ns |  45.096 ns |  2.472 ns | 1,367.82 ns | 1,372.76 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   293.78 ns |  44.883 ns |  2.460 ns |   291.50 ns |   296.39 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   711.27 ns |  17.673 ns |  0.969 ns |   710.49 ns |   712.35 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   138.68 ns |  19.452 ns |  1.066 ns |   137.92 ns |   139.90 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   429.98 ns |  34.901 ns |  1.913 ns |   427.85 ns |   431.56 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    93.08 ns |  26.829 ns |  1.471 ns |    91.71 ns |    94.64 ns | 0.0315 |     528 B |
