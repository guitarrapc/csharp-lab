```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **494.88 ns** |  **68.481 ns** | **3.754 ns** |   **491.59 ns** |   **498.97 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   108.42 ns |   8.298 ns | 0.455 ns |   107.93 ns |   108.83 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   228.65 ns |  13.769 ns | 0.755 ns |   227.91 ns |   229.42 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.86 ns |   3.088 ns | 0.169 ns |    37.67 ns |    37.99 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   136.15 ns |   4.806 ns | 0.263 ns |   135.89 ns |   136.41 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.58 ns |   4.390 ns | 0.241 ns |    34.33 ns |    34.81 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   470.23 ns |  35.575 ns | 1.950 ns |   468.19 ns |   472.07 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    94.34 ns |   8.648 ns | 0.474 ns |    93.88 ns |    94.83 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   235.27 ns |  31.783 ns | 1.742 ns |   234.20 ns |   237.28 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    39.50 ns |   2.317 ns | 0.127 ns |    39.36 ns |    39.61 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   142.70 ns |  11.955 ns | 0.655 ns |   142.01 ns |   143.31 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    30.00 ns |   2.970 ns | 0.163 ns |    29.82 ns |    30.13 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,516.36 ns** |  **17.653 ns** | **0.968 ns** | **1,515.28 ns** | **1,517.15 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   350.92 ns |  16.419 ns | 0.900 ns |   350.20 ns |   351.93 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   679.64 ns |  54.718 ns | 2.999 ns |   676.17 ns |   681.42 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   114.87 ns |  10.192 ns | 0.559 ns |   114.27 ns |   115.37 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   409.08 ns |  23.990 ns | 1.315 ns |   407.94 ns |   410.52 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.21 ns |  14.726 ns | 0.807 ns |   101.64 ns |   103.13 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,402.03 ns | 110.212 ns | 6.041 ns | 1,396.62 ns | 1,408.55 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   283.05 ns |  33.782 ns | 1.852 ns |   281.06 ns |   284.72 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   715.03 ns |  96.386 ns | 5.283 ns |   709.78 ns |   720.35 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   124.60 ns |  44.852 ns | 2.458 ns |   122.00 ns |   126.88 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   420.93 ns |  18.213 ns | 0.998 ns |   419.82 ns |   421.77 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    92.97 ns |  26.725 ns | 1.465 ns |    91.52 ns |    94.45 ns | 0.0315 |     528 B |
