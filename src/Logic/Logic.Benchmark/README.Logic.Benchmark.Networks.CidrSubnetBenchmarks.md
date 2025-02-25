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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **486.57 ns** |  **26.259 ns** | **1.439 ns** |   **485.31 ns** |   **488.14 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   111.16 ns |  13.771 ns | 0.755 ns |   110.57 ns |   112.01 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   228.90 ns |  34.438 ns | 1.888 ns |   226.87 ns |   230.60 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    39.03 ns |   7.164 ns | 0.393 ns |    38.73 ns |    39.47 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   140.50 ns |   3.857 ns | 0.211 ns |   140.36 ns |   140.74 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    50.35 ns |  10.445 ns | 0.573 ns |    49.70 ns |    50.76 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   418.64 ns |  21.487 ns | 1.178 ns |   417.74 ns |   419.97 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.71 ns |   7.289 ns | 0.400 ns |    94.31 ns |    95.11 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   236.18 ns |  31.493 ns | 1.726 ns |   234.86 ns |   238.14 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.63 ns |   4.382 ns | 0.240 ns |    40.44 ns |    40.90 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.13 ns |   3.763 ns | 0.206 ns |   141.01 ns |   141.37 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.50 ns |   5.173 ns | 0.284 ns |    30.30 ns |    30.82 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,613.68 ns** | **166.506 ns** | **9.127 ns** | **1,607.90 ns** | **1,624.20 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   349.81 ns |  25.965 ns | 1.423 ns |   348.47 ns |   351.31 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   735.63 ns | 147.025 ns | 8.059 ns |   727.02 ns |   743.00 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   116.45 ns |  15.793 ns | 0.866 ns |   115.88 ns |   117.45 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   439.54 ns |  33.162 ns | 1.818 ns |   437.50 ns |   440.99 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   154.04 ns |  14.761 ns | 0.809 ns |   153.14 ns |   154.69 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,411.55 ns | 135.233 ns | 7.413 ns | 1,405.19 ns | 1,419.69 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   289.64 ns |  23.999 ns | 1.315 ns |   288.22 ns |   290.83 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   736.54 ns |  69.829 ns | 3.828 ns |   732.60 ns |   740.25 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   123.61 ns |  39.477 ns | 2.164 ns |   121.72 ns |   125.97 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   437.96 ns |  55.664 ns | 3.051 ns |   434.58 ns |   440.49 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    89.95 ns |   4.768 ns | 0.261 ns |    89.67 ns |    90.20 ns | 0.0315 |     528 B |
