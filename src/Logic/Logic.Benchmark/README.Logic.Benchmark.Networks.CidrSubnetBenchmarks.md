```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **513.16 ns** |  **22.011 ns** | **1.207 ns** |   **512.09 ns** |   **514.47 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   112.85 ns |   1.794 ns | 0.098 ns |   112.75 ns |   112.94 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   222.95 ns |  25.082 ns | 1.375 ns |   221.38 ns |   223.90 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.28 ns |   2.975 ns | 0.163 ns |    38.15 ns |    38.46 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   136.33 ns |  11.861 ns | 0.650 ns |   135.74 ns |   137.03 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.94 ns |   7.708 ns | 0.422 ns |    34.56 ns |    35.40 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   455.11 ns |  28.083 ns | 1.539 ns |   453.56 ns |   456.64 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    95.31 ns |  32.003 ns | 1.754 ns |    93.72 ns |    97.19 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   245.10 ns | 102.301 ns | 5.607 ns |   238.85 ns |   249.69 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.21 ns |   9.715 ns | 0.532 ns |    40.86 ns |    41.82 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   143.87 ns |  19.447 ns | 1.066 ns |   142.66 ns |   144.68 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.87 ns |   1.217 ns | 0.067 ns |    31.79 ns |    31.91 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,561.08 ns** | **160.322 ns** | **8.788 ns** | **1,553.43 ns** | **1,570.68 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   329.00 ns |  11.787 ns | 0.646 ns |   328.33 ns |   329.62 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   710.21 ns | 172.241 ns | 9.441 ns |   699.38 ns |   716.70 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   118.59 ns |   4.059 ns | 0.222 ns |   118.33 ns |   118.73 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   414.40 ns |  16.493 ns | 0.904 ns |   413.47 ns |   415.27 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   103.56 ns |  17.579 ns | 0.964 ns |   102.44 ns |   104.12 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,361.24 ns | 171.232 ns | 9.386 ns | 1,355.30 ns | 1,372.06 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   288.74 ns |  24.389 ns | 1.337 ns |   287.24 ns |   289.81 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   691.44 ns |  21.853 ns | 1.198 ns |   690.06 ns |   692.21 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   118.94 ns |  32.654 ns | 1.790 ns |   117.23 ns |   120.80 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   434.37 ns |  18.058 ns | 0.990 ns |   433.47 ns |   435.43 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    90.65 ns |  26.690 ns | 1.463 ns |    88.96 ns |    91.51 ns | 0.0315 |     528 B |
