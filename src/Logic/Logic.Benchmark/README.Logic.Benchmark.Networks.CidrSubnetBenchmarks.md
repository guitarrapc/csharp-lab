```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **490.82 ns** | **96.091 ns** | **5.267 ns** |   **484.74 ns** |   **494.10 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   114.42 ns | 14.843 ns | 0.814 ns |   113.92 ns |   115.36 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   236.03 ns | 30.546 ns | 1.674 ns |   234.68 ns |   237.91 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.29 ns |  9.519 ns | 0.522 ns |    37.81 ns |    38.85 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   138.51 ns |  8.812 ns | 0.483 ns |   137.97 ns |   138.90 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.72 ns |  5.477 ns | 0.300 ns |    34.38 ns |    34.95 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   454.86 ns | 23.399 ns | 1.283 ns |   453.78 ns |   456.28 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.99 ns |  8.052 ns | 0.441 ns |    94.62 ns |    95.48 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   240.05 ns | 36.242 ns | 1.987 ns |   238.60 ns |   242.31 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    42.53 ns |  1.837 ns | 0.101 ns |    42.43 ns |    42.62 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   142.09 ns | 28.055 ns | 1.538 ns |   140.76 ns |   143.77 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.59 ns |  4.997 ns | 0.274 ns |    30.34 ns |    30.88 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,532.36 ns** | **36.215 ns** | **1.985 ns** | **1,530.93 ns** | **1,534.63 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   332.41 ns | 15.512 ns | 0.850 ns |   331.46 ns |   333.10 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   712.14 ns | 46.421 ns | 2.545 ns |   709.27 ns |   714.12 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   115.22 ns | 27.067 ns | 1.484 ns |   114.13 ns |   116.91 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   411.13 ns | 66.402 ns | 3.640 ns |   407.54 ns |   414.82 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.51 ns |  0.541 ns | 0.030 ns |   102.48 ns |   102.54 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,405.20 ns | 44.126 ns | 2.419 ns | 1,402.62 ns | 1,407.41 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   282.89 ns | 15.768 ns | 0.864 ns |   282.13 ns |   283.83 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   704.97 ns | 40.914 ns | 2.243 ns |   702.38 ns |   706.29 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   120.84 ns | 19.587 ns | 1.074 ns |   119.83 ns |   121.97 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   447.17 ns |  9.072 ns | 0.497 ns |   446.61 ns |   447.58 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    89.80 ns | 15.276 ns | 0.837 ns |    89.10 ns |    90.73 ns | 0.0315 |     528 B |
