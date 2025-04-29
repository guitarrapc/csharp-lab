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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **509.46 ns** | **103.628 ns** |  **5.680 ns** |   **504.11 ns** |   **515.43 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   114.09 ns |  35.070 ns |  1.922 ns |   111.89 ns |   115.47 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   222.66 ns |  62.651 ns |  3.434 ns |   219.32 ns |   226.19 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    39.23 ns |  14.822 ns |  0.812 ns |    38.29 ns |    39.72 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   146.94 ns |   7.996 ns |  0.438 ns |   146.45 ns |   147.29 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    36.00 ns |  19.527 ns |  1.070 ns |    34.78 ns |    36.78 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   458.53 ns |  17.165 ns |  0.941 ns |   457.45 ns |   459.17 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    97.44 ns |   6.486 ns |  0.355 ns |    97.03 ns |    97.68 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   240.03 ns |  39.208 ns |  2.149 ns |   237.66 ns |   241.86 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    44.44 ns |  13.157 ns |  0.721 ns |    43.84 ns |    45.24 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   149.27 ns |  15.200 ns |  0.833 ns |   148.38 ns |   150.02 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    33.93 ns |   2.751 ns |  0.151 ns |    33.80 ns |    34.10 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,595.05 ns** | **119.685 ns** |  **6.560 ns** | **1,588.49 ns** | **1,601.61 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   345.28 ns |  63.188 ns |  3.464 ns |   343.11 ns |   349.28 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   747.17 ns |  81.450 ns |  4.465 ns |   744.19 ns |   752.31 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   124.23 ns |  27.581 ns |  1.512 ns |   122.66 ns |   125.67 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   434.51 ns |   6.589 ns |  0.361 ns |   434.17 ns |   434.89 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   110.62 ns |  29.366 ns |  1.610 ns |   108.76 ns |   111.59 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,386.66 ns | 239.511 ns | 13.128 ns | 1,371.58 ns | 1,395.57 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   292.13 ns |  17.310 ns |  0.949 ns |   291.50 ns |   293.22 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      | 1,208.58 ns |  67.242 ns |  3.686 ns | 1,205.07 ns | 1,212.42 ns | 0.0763 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   144.97 ns |  41.462 ns |  2.273 ns |   143.54 ns |   147.59 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   432.89 ns |  26.079 ns |  1.429 ns |   431.77 ns |   434.50 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    96.33 ns |  24.621 ns |  1.350 ns |    94.95 ns |    97.65 ns | 0.0315 |     528 B |
