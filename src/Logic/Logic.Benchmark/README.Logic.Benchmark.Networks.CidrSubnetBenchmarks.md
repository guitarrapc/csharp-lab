```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **529.26 ns** |  **82.453 ns** | **4.520 ns** |   **524.05 ns** |   **532.08 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   110.77 ns |   9.772 ns | 0.536 ns |   110.15 ns |   111.11 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   236.76 ns |  29.363 ns | 1.609 ns |   234.90 ns |   237.70 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    40.42 ns |   5.260 ns | 0.288 ns |    40.08 ns |    40.61 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   144.09 ns |  26.143 ns | 1.433 ns |   143.18 ns |   145.74 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    40.72 ns |   6.136 ns | 0.336 ns |    40.38 ns |    41.06 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   426.54 ns |  16.866 ns | 0.924 ns |   425.83 ns |   427.58 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    97.42 ns |   4.967 ns | 0.272 ns |    97.11 ns |    97.62 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   243.96 ns |  33.830 ns | 1.854 ns |   241.82 ns |   245.16 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    42.03 ns |   9.893 ns | 0.542 ns |    41.66 ns |    42.65 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   144.07 ns |   5.150 ns | 0.282 ns |   143.89 ns |   144.39 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.07 ns |  10.184 ns | 0.558 ns |    30.44 ns |    31.48 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,591.60 ns** |  **59.812 ns** | **3.278 ns** | **1,589.61 ns** | **1,595.38 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   337.68 ns |  35.960 ns | 1.971 ns |   336.01 ns |   339.86 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   713.22 ns |  50.255 ns | 2.755 ns |   710.05 ns |   715.06 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   121.50 ns |  14.516 ns | 0.796 ns |   120.60 ns |   122.11 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   415.87 ns |  52.081 ns | 2.855 ns |   414.18 ns |   419.16 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   108.00 ns |  14.747 ns | 0.808 ns |   107.08 ns |   108.60 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,427.66 ns | 111.710 ns | 6.123 ns | 1,422.69 ns | 1,434.50 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   316.59 ns | 149.161 ns | 8.176 ns |   307.14 ns |   321.35 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   758.93 ns |  97.358 ns | 5.337 ns |   752.77 ns |   762.09 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   126.98 ns |   8.237 ns | 0.451 ns |   126.61 ns |   127.49 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   449.37 ns |  99.869 ns | 5.474 ns |   444.64 ns |   455.37 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    92.04 ns |  24.708 ns | 1.354 ns |    90.48 ns |    92.88 ns | 0.0315 |     528 B |
