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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **524.40 ns** |  **57.143 ns** |  **3.132 ns** |   **521.36 ns** |   **527.62 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   116.64 ns |  21.190 ns |  1.161 ns |   115.55 ns |   117.86 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   248.04 ns |  22.161 ns |  1.215 ns |   246.75 ns |   249.17 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    46.08 ns |   7.595 ns |  0.416 ns |    45.62 ns |    46.42 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   150.48 ns |   1.712 ns |  0.094 ns |   150.38 ns |   150.56 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    41.37 ns |  17.293 ns |  0.948 ns |    40.79 ns |    42.46 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   469.58 ns |  60.667 ns |  3.325 ns |   466.53 ns |   473.12 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |   105.01 ns |  20.427 ns |  1.120 ns |   104.03 ns |   106.23 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   269.27 ns |  57.692 ns |  3.162 ns |   266.57 ns |   272.75 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    47.32 ns |  14.467 ns |  0.793 ns |    46.49 ns |    48.07 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   159.28 ns |  71.791 ns |  3.935 ns |   155.07 ns |   162.86 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    39.88 ns |  21.237 ns |  1.164 ns |    38.92 ns |    41.17 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,894.20 ns** | **283.648 ns** | **15.548 ns** | **1,878.87 ns** | **1,909.96 ns** | **0.1259** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   355.28 ns |  34.612 ns |  1.897 ns |   353.20 ns |   356.92 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   784.16 ns | 181.457 ns |  9.946 ns |   775.31 ns |   794.92 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   140.46 ns |  35.139 ns |  1.926 ns |   138.97 ns |   142.63 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   460.70 ns |  32.564 ns |  1.785 ns |   459.11 ns |   462.63 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   128.88 ns |  39.622 ns |  2.172 ns |   126.90 ns |   131.21 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,460.28 ns | 192.517 ns | 10.553 ns | 1,449.96 ns | 1,471.05 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   316.33 ns |  34.197 ns |  1.874 ns |   314.19 ns |   317.69 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   812.30 ns | 166.835 ns |  9.145 ns |   805.30 ns |   822.65 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   145.27 ns |  25.701 ns |  1.409 ns |   144.03 ns |   146.80 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   458.35 ns |  35.067 ns |  1.922 ns |   456.60 ns |   460.41 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |   113.36 ns |  48.780 ns |  2.674 ns |   110.48 ns |   115.75 ns | 0.0315 |     528 B |
