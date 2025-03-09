```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **485.33 ns** |   **0.946 ns** | **0.052 ns** |   **485.28 ns** |   **485.38 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   110.71 ns |   3.773 ns | 0.207 ns |   110.48 ns |   110.87 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   222.93 ns |   2.076 ns | 0.114 ns |   222.84 ns |   223.06 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    42.13 ns |  13.131 ns | 0.720 ns |    41.71 ns |    42.96 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   157.92 ns |  19.230 ns | 1.054 ns |   157.08 ns |   159.10 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    36.42 ns |  11.358 ns | 0.623 ns |    35.90 ns |    37.11 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   419.29 ns |  83.233 ns | 4.562 ns |   414.96 ns |   424.05 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.13 ns |  29.172 ns | 1.599 ns |    94.41 ns |    97.58 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   235.81 ns |  77.509 ns | 4.249 ns |   233.34 ns |   240.72 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.45 ns |   8.239 ns | 0.452 ns |    40.07 ns |    40.95 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   142.74 ns |  10.418 ns | 0.571 ns |   142.09 ns |   143.14 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.47 ns |   4.029 ns | 0.221 ns |    30.29 ns |    30.72 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,658.46 ns** | **174.154 ns** | **9.546 ns** | **1,647.82 ns** | **1,666.28 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   335.04 ns |  40.735 ns | 2.233 ns |   332.55 ns |   336.85 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   678.11 ns | 155.804 ns | 8.540 ns |   668.62 ns |   685.18 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   116.14 ns |   7.104 ns | 0.389 ns |   115.82 ns |   116.57 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   422.28 ns |  83.435 ns | 4.573 ns |   417.01 ns |   425.21 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   103.64 ns |  11.847 ns | 0.649 ns |   102.99 ns |   104.29 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,337.14 ns | 175.472 ns | 9.618 ns | 1,326.09 ns | 1,343.68 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   288.96 ns |  11.488 ns | 0.630 ns |   288.29 ns |   289.53 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   731.81 ns |  81.245 ns | 4.453 ns |   727.87 ns |   736.65 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   123.54 ns |  16.110 ns | 0.883 ns |   122.54 ns |   124.21 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   448.09 ns | 120.984 ns | 6.632 ns |   440.53 ns |   452.94 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    92.19 ns |  58.826 ns | 3.224 ns |    90.11 ns |    95.90 ns | 0.0315 |     528 B |
