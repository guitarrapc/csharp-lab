```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **486.23 ns** |  **15.706 ns** | **0.861 ns** |   **485.45 ns** |   **487.15 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   173.41 ns |   2.935 ns | 0.161 ns |   173.28 ns |   173.59 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   235.17 ns |  30.180 ns | 1.654 ns |   234.04 ns |   237.07 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.78 ns |   3.056 ns | 0.168 ns |    37.63 ns |    37.96 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   134.62 ns |  12.417 ns | 0.681 ns |   133.86 ns |   135.16 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.32 ns |   1.464 ns | 0.080 ns |    34.22 ns |    34.37 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   434.49 ns |  51.665 ns | 2.832 ns |   431.94 ns |   437.54 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.00 ns |   5.329 ns | 0.292 ns |    93.66 ns |    94.20 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   233.61 ns |  46.944 ns | 2.573 ns |   230.84 ns |   235.93 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    39.93 ns |   3.588 ns | 0.197 ns |    39.75 ns |    40.14 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   139.10 ns |   7.923 ns | 0.434 ns |   138.78 ns |   139.60 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.79 ns |   0.407 ns | 0.022 ns |    29.77 ns |    29.81 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,608.01 ns** | **122.130 ns** | **6.694 ns** | **1,600.37 ns** | **1,612.85 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   334.61 ns |  40.618 ns | 2.226 ns |   332.14 ns |   336.46 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   678.43 ns |  43.497 ns | 2.384 ns |   676.72 ns |   681.15 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   116.33 ns |   8.898 ns | 0.488 ns |   115.77 ns |   116.64 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   435.38 ns |  24.408 ns | 1.338 ns |   434.25 ns |   436.86 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   101.26 ns |   9.132 ns | 0.501 ns |   100.70 ns |   101.68 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,412.86 ns | 181.979 ns | 9.975 ns | 1,401.40 ns | 1,419.53 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   284.29 ns |  16.027 ns | 0.879 ns |   283.44 ns |   285.20 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   711.67 ns |  83.724 ns | 4.589 ns |   706.53 ns |   715.34 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   119.08 ns |  15.709 ns | 0.861 ns |   118.09 ns |   119.69 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   432.99 ns |  35.314 ns | 1.936 ns |   431.12 ns |   434.98 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    88.78 ns |  27.105 ns | 1.486 ns |    87.25 ns |    90.22 ns | 0.0315 |     528 B |
