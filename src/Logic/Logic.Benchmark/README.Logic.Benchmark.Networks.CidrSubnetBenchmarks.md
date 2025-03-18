```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **497.33 ns** |  **60.492 ns** |  **3.316 ns** |   **493.63 ns** |   **500.02 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   109.25 ns |   5.194 ns |  0.285 ns |   108.97 ns |   109.54 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   224.75 ns |   6.408 ns |  0.351 ns |   224.35 ns |   225.00 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.89 ns |  12.098 ns |  0.663 ns |    38.44 ns |    39.65 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   137.68 ns |   7.382 ns |  0.405 ns |   137.23 ns |   138.03 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.94 ns |   2.792 ns |  0.153 ns |    34.81 ns |    35.11 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   435.26 ns |  64.454 ns |  3.533 ns |   431.27 ns |   437.99 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    98.20 ns |   7.630 ns |  0.418 ns |    97.74 ns |    98.56 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   241.39 ns |  40.969 ns |  2.246 ns |   239.55 ns |   243.89 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.59 ns |  10.188 ns |  0.558 ns |    40.94 ns |    41.93 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   141.11 ns |  10.380 ns |  0.569 ns |   140.47 ns |   141.57 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.35 ns |  11.703 ns |  0.641 ns |    30.71 ns |    31.99 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,556.36 ns** |  **99.793 ns** |  **5.470 ns** | **1,552.70 ns** | **1,562.64 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   341.95 ns |  27.118 ns |  1.486 ns |   340.24 ns |   342.92 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   708.43 ns | 374.968 ns | 20.553 ns |   694.78 ns |   732.07 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   119.67 ns |  24.191 ns |  1.326 ns |   118.76 ns |   121.19 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   418.77 ns |  39.361 ns |  2.157 ns |   416.78 ns |   421.06 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.79 ns |  18.411 ns |  1.009 ns |   101.77 ns |   103.79 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,414.11 ns |  31.907 ns |  1.749 ns | 1,412.71 ns | 1,416.07 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   288.30 ns |  17.304 ns |  0.949 ns |   287.23 ns |   289.01 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   729.42 ns | 111.186 ns |  6.095 ns |   724.47 ns |   736.23 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   120.99 ns |  16.960 ns |  0.930 ns |   120.36 ns |   122.06 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   441.25 ns |  25.117 ns |  1.377 ns |   439.75 ns |   442.45 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    91.33 ns |  14.338 ns |  0.786 ns |    90.78 ns |    92.23 ns | 0.0315 |     528 B |
