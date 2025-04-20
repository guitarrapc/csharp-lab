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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **502.45 ns** |  **84.983 ns** |  **4.658 ns** |   **497.46 ns** |   **506.69 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   110.94 ns |  11.747 ns |  0.644 ns |   110.25 ns |   111.52 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   245.58 ns |  68.668 ns |  3.764 ns |   241.29 ns |   248.30 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    40.14 ns |  14.114 ns |  0.774 ns |    39.28 ns |    40.78 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   151.26 ns |   8.589 ns |  0.471 ns |   150.74 ns |   151.64 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    36.35 ns |   1.467 ns |  0.080 ns |    36.29 ns |    36.44 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   462.99 ns |  23.359 ns |  1.280 ns |   461.52 ns |   463.90 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.99 ns |  16.883 ns |  0.925 ns |    95.99 ns |    97.82 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   232.14 ns |  23.313 ns |  1.278 ns |   230.88 ns |   233.43 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.79 ns |   7.732 ns |  0.424 ns |    40.36 ns |    41.21 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   143.97 ns |  27.039 ns |  1.482 ns |   142.90 ns |   145.66 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.28 ns |   3.914 ns |  0.215 ns |    31.05 ns |    31.47 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,515.85 ns** |  **29.860 ns** |  **1.637 ns** | **1,514.11 ns** | **1,517.36 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   332.83 ns |   4.248 ns |  0.233 ns |   332.57 ns |   333.01 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   678.13 ns |  10.358 ns |  0.568 ns |   677.48 ns |   678.51 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   114.44 ns |   8.165 ns |  0.448 ns |   114.05 ns |   114.93 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   429.60 ns |  10.131 ns |  0.555 ns |   428.96 ns |   429.96 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   103.92 ns |  17.837 ns |  0.978 ns |   103.08 ns |   105.00 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,401.88 ns | 280.285 ns | 15.363 ns | 1,388.77 ns | 1,418.78 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   284.45 ns |  39.032 ns |  2.139 ns |   283.16 ns |   286.92 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   713.45 ns |  82.731 ns |  4.535 ns |   710.16 ns |   718.62 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   125.95 ns |  14.323 ns |  0.785 ns |   125.33 ns |   126.83 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   444.60 ns |  73.099 ns |  4.007 ns |   440.15 ns |   447.92 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    91.99 ns |  36.105 ns |  1.979 ns |    89.70 ns |    93.24 ns | 0.0315 |     528 B |
