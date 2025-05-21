```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **491.19 ns** | **157.786 ns** |  **8.649 ns** |   **482.48 ns** |   **499.78 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   114.55 ns |   6.743 ns |  0.370 ns |   114.15 ns |   114.88 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   245.65 ns |  52.246 ns |  2.864 ns |   242.38 ns |   247.70 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    40.63 ns |  10.126 ns |  0.555 ns |    40.04 ns |    41.14 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   141.29 ns |   7.276 ns |  0.399 ns |   140.84 ns |   141.60 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    35.24 ns |  18.188 ns |  0.997 ns |    34.39 ns |    36.33 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   450.27 ns |  52.801 ns |  2.894 ns |   447.15 ns |   452.87 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    97.25 ns |  13.043 ns |  0.715 ns |    96.50 ns |    97.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   255.53 ns |  14.350 ns |  0.787 ns |   254.67 ns |   256.21 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    43.11 ns |  10.957 ns |  0.601 ns |    42.52 ns |    43.72 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   145.85 ns |  23.413 ns |  1.283 ns |   144.37 ns |   146.65 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    33.97 ns |  25.667 ns |  1.407 ns |    32.36 ns |    34.97 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,697.81 ns** | **362.651 ns** | **19.878 ns** | **1,677.74 ns** | **1,717.49 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   359.19 ns |  20.370 ns |  1.117 ns |   357.92 ns |   360.01 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   739.86 ns | 245.136 ns | 13.437 ns |   728.44 ns |   754.67 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   123.62 ns |  70.882 ns |  3.885 ns |   119.40 ns |   127.06 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   437.72 ns | 120.669 ns |  6.614 ns |   430.09 ns |   441.86 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   121.59 ns |  60.573 ns |  3.320 ns |   117.78 ns |   123.87 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,529.68 ns | 214.654 ns | 11.766 ns | 1,516.11 ns | 1,536.97 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   298.17 ns |  63.793 ns |  3.497 ns |   294.79 ns |   301.77 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   765.39 ns |  51.028 ns |  2.797 ns |   762.16 ns |   767.13 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   131.76 ns |  36.486 ns |  2.000 ns |   130.03 ns |   133.95 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   479.45 ns | 141.146 ns |  7.737 ns |   470.64 ns |   485.12 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |   109.29 ns |  30.067 ns |  1.648 ns |   107.68 ns |   110.97 ns | 0.0315 |     528 B |
