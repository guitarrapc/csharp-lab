```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **485.45 ns** |  **5.689 ns** | **0.312 ns** |   **485.19 ns** |   **485.80 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   107.98 ns |  5.304 ns | 0.291 ns |   107.72 ns |   108.29 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   225.16 ns |  8.029 ns | 0.440 ns |   224.72 ns |   225.60 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.53 ns |  1.324 ns | 0.073 ns |    37.45 ns |    37.60 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   138.56 ns |  6.915 ns | 0.379 ns |   138.26 ns |   138.98 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.02 ns |  2.873 ns | 0.157 ns |    33.85 ns |    34.16 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   417.75 ns | 14.962 ns | 0.820 ns |   416.93 ns |   418.57 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    93.83 ns |  8.327 ns | 0.456 ns |    93.50 ns |    94.35 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   239.26 ns |  7.549 ns | 0.414 ns |   238.97 ns |   239.73 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    39.34 ns |  0.819 ns | 0.045 ns |    39.30 ns |    39.39 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   142.47 ns |  5.182 ns | 0.284 ns |   142.16 ns |   142.72 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.65 ns |  0.715 ns | 0.039 ns |    29.61 ns |    29.69 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,561.94 ns** | **12.275 ns** | **0.673 ns** | **1,561.33 ns** | **1,562.66 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   323.54 ns |  6.144 ns | 0.337 ns |   323.27 ns |   323.91 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   698.20 ns | 14.261 ns | 0.782 ns |   697.31 ns |   698.78 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   115.31 ns | 10.882 ns | 0.596 ns |   114.82 ns |   115.97 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   405.10 ns | 19.784 ns | 1.084 ns |   403.85 ns |   405.78 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.76 ns | 10.017 ns | 0.549 ns |   102.19 ns |   103.29 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,331.75 ns | 33.672 ns | 1.846 ns | 1,330.32 ns | 1,333.84 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   281.04 ns |  2.404 ns | 0.132 ns |   280.93 ns |   281.18 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   703.13 ns | 44.085 ns | 2.416 ns |   700.52 ns |   705.30 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   120.55 ns | 18.030 ns | 0.988 ns |   119.42 ns |   121.27 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   437.97 ns | 28.765 ns | 1.577 ns |   436.15 ns |   438.97 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    87.09 ns |  8.847 ns | 0.485 ns |    86.67 ns |    87.62 ns | 0.0315 |     528 B |
