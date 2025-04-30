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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **512.62 ns** |  **61.061 ns** |  **3.347 ns** |   **508.87 ns** |   **515.30 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   117.42 ns |   3.305 ns |  0.181 ns |   117.24 ns |   117.60 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   243.05 ns |  36.513 ns |  2.001 ns |   240.81 ns |   244.64 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    40.65 ns |   7.511 ns |  0.412 ns |    40.23 ns |    41.05 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   140.39 ns |  16.234 ns |  0.890 ns |   139.46 ns |   141.23 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    39.38 ns |  19.628 ns |  1.076 ns |    38.19 ns |    40.28 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   461.28 ns |  72.165 ns |  3.956 ns |   456.84 ns |   464.42 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |   102.70 ns |   9.961 ns |  0.546 ns |   102.35 ns |   103.33 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   249.97 ns |  16.412 ns |  0.900 ns |   249.02 ns |   250.80 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    44.59 ns |  20.861 ns |  1.143 ns |    43.30 ns |    45.48 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   146.24 ns |   7.988 ns |  0.438 ns |   145.79 ns |   146.67 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    35.12 ns |  12.255 ns |  0.672 ns |    34.35 ns |    35.58 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,609.63 ns** | **234.389 ns** | **12.848 ns** | **1,597.30 ns** | **1,622.94 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   343.92 ns | 111.357 ns |  6.104 ns |   336.88 ns |   347.72 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   713.56 ns | 116.741 ns |  6.399 ns |   706.79 ns |   719.51 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   123.73 ns |  19.972 ns |  1.095 ns |   122.49 ns |   124.57 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   442.03 ns |  18.143 ns |  0.994 ns |   440.89 ns |   442.72 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   108.52 ns |  45.987 ns |  2.521 ns |   106.26 ns |   111.24 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,426.88 ns | 173.204 ns |  9.494 ns | 1,417.27 ns | 1,436.25 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   287.83 ns |  28.322 ns |  1.552 ns |   286.66 ns |   289.59 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   752.51 ns | 216.522 ns | 11.868 ns |   741.57 ns |   765.13 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   150.31 ns |  61.172 ns |  3.353 ns |   146.52 ns |   152.90 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   445.32 ns |  24.791 ns |  1.359 ns |   444.45 ns |   446.88 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |   105.05 ns |  16.624 ns |  0.911 ns |   104.04 ns |   105.83 ns | 0.0315 |     528 B |
