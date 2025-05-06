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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **513.69 ns** |  **12.385 ns** |  **0.679 ns** |   **512.90 ns** |   **514.10 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   114.86 ns |  12.493 ns |  0.685 ns |   114.29 ns |   115.62 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   244.70 ns |  88.123 ns |  4.830 ns |   241.86 ns |   250.27 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    43.62 ns |   9.653 ns |  0.529 ns |    43.28 ns |    44.23 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   144.56 ns |   3.248 ns |  0.178 ns |   144.43 ns |   144.76 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    39.82 ns |   6.772 ns |  0.371 ns |    39.52 ns |    40.23 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   464.36 ns |  42.948 ns |  2.354 ns |   462.24 ns |   466.89 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    99.90 ns |   4.176 ns |  0.229 ns |    99.66 ns |   100.11 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   250.73 ns |  32.448 ns |  1.779 ns |   249.06 ns |   252.60 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    46.57 ns |  17.646 ns |  0.967 ns |    45.45 ns |    47.13 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   147.10 ns |  44.087 ns |  2.417 ns |   145.56 ns |   149.89 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    35.39 ns |   5.116 ns |  0.280 ns |    35.08 ns |    35.63 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,608.89 ns** | **518.187 ns** | **28.404 ns** | **1,590.54 ns** | **1,641.61 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   368.67 ns |  13.567 ns |  0.744 ns |   367.82 ns |   369.18 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   735.55 ns |  36.241 ns |  1.986 ns |   733.26 ns |   736.79 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   133.65 ns |  61.397 ns |  3.365 ns |   129.78 ns |   135.92 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   461.87 ns |  15.935 ns |  0.873 ns |   461.31 ns |   462.88 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   120.10 ns |  34.117 ns |  1.870 ns |   118.07 ns |   121.75 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,415.18 ns |  74.333 ns |  4.074 ns | 1,410.87 ns | 1,418.97 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   300.46 ns |  14.137 ns |  0.775 ns |   299.85 ns |   301.34 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   769.93 ns |  61.059 ns |  3.347 ns |   767.55 ns |   773.76 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   150.84 ns |  29.690 ns |  1.627 ns |   149.07 ns |   152.26 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   457.71 ns |  22.559 ns |  1.237 ns |   456.40 ns |   458.86 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |   102.38 ns |  35.228 ns |  1.931 ns |   100.29 ns |   104.11 ns | 0.0315 |     528 B |
