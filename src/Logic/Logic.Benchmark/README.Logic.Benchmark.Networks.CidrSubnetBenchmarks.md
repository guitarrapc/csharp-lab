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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **585.84 ns** |  **60.752 ns** |  **3.330 ns** |   **583.47 ns** |   **589.65 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   109.86 ns |   8.046 ns |  0.441 ns |   109.48 ns |   110.34 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   229.75 ns |  58.360 ns |  3.199 ns |   227.76 ns |   233.44 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    42.29 ns |   7.389 ns |  0.405 ns |    41.82 ns |    42.53 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   145.09 ns |   9.596 ns |  0.526 ns |   144.51 ns |   145.55 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    35.06 ns |   4.062 ns |  0.223 ns |    34.82 ns |    35.26 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   431.94 ns |  15.456 ns |  0.847 ns |   431.23 ns |   432.88 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    97.43 ns |  35.318 ns |  1.936 ns |    96.15 ns |    99.65 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   243.75 ns |  58.372 ns |  3.200 ns |   241.71 ns |   247.43 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    42.61 ns |  13.484 ns |  0.739 ns |    42.03 ns |    43.44 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   143.54 ns |  32.718 ns |  1.793 ns |   142.40 ns |   145.61 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    34.85 ns |  15.048 ns |  0.825 ns |    34.28 ns |    35.80 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,609.53 ns** | **179.515 ns** |  **9.840 ns** | **1,599.36 ns** | **1,619.00 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   338.07 ns |  23.088 ns |  1.266 ns |   336.70 ns |   339.20 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   736.52 ns | 114.071 ns |  6.253 ns |   729.35 ns |   740.82 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   127.04 ns |  75.577 ns |  4.143 ns |   122.27 ns |   129.73 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   418.15 ns |  45.824 ns |  2.512 ns |   416.33 ns |   421.02 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.60 ns |   8.663 ns |  0.475 ns |   102.09 ns |   103.03 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,369.56 ns | 313.865 ns | 17.204 ns | 1,355.64 ns | 1,388.79 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   293.21 ns |  84.538 ns |  4.634 ns |   289.26 ns |   298.31 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   719.58 ns |  57.374 ns |  3.145 ns |   715.94 ns |   721.41 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   140.42 ns |  87.924 ns |  4.819 ns |   134.90 ns |   143.74 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   438.52 ns |  30.208 ns |  1.656 ns |   436.62 ns |   439.68 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    88.78 ns |  21.857 ns |  1.198 ns |    87.64 ns |    90.02 ns | 0.0315 |     528 B |
