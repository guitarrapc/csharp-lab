```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **492.40 ns** |  **31.173 ns** |  **1.709 ns** |   **490.60 ns** |   **494.00 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   110.72 ns |   8.686 ns |  0.476 ns |   110.17 ns |   111.06 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   220.07 ns |   4.365 ns |  0.239 ns |   219.89 ns |   220.34 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.07 ns |   4.319 ns |  0.237 ns |    37.81 ns |    38.27 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   133.62 ns |   2.831 ns |  0.155 ns |   133.47 ns |   133.78 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    35.26 ns |   3.015 ns |  0.165 ns |    35.08 ns |    35.41 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   418.50 ns |   0.835 ns |  0.046 ns |   418.46 ns |   418.55 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    95.29 ns |  18.507 ns |  1.014 ns |    94.46 ns |    96.42 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   235.94 ns |  10.728 ns |  0.588 ns |   235.26 ns |   236.36 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    39.40 ns |   3.776 ns |  0.207 ns |    39.27 ns |    39.64 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   142.42 ns |  16.839 ns |  0.923 ns |   141.79 ns |   143.48 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.62 ns |   1.427 ns |  0.078 ns |    29.56 ns |    29.71 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,491.86 ns** |  **90.116 ns** |  **4.940 ns** | **1,488.15 ns** | **1,497.47 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   326.62 ns |  23.733 ns |  1.301 ns |   325.85 ns |   328.12 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   676.10 ns |  39.983 ns |  2.192 ns |   673.81 ns |   678.17 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   113.43 ns |   7.834 ns |  0.429 ns |   112.94 ns |   113.73 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   406.71 ns |  27.118 ns |  1.486 ns |   404.99 ns |   407.60 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   100.65 ns |   6.491 ns |  0.356 ns |   100.37 ns |   101.05 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,475.79 ns | 226.766 ns | 12.430 ns | 1,468.11 ns | 1,490.13 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   282.52 ns |   9.768 ns |  0.535 ns |   281.93 ns |   282.97 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   714.43 ns |  33.737 ns |  1.849 ns |   713.07 ns |   716.54 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   128.89 ns |   6.321 ns |  0.346 ns |   128.50 ns |   129.17 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   431.20 ns |  50.419 ns |  2.764 ns |   429.41 ns |   434.38 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    86.38 ns |   3.535 ns |  0.194 ns |    86.16 ns |    86.54 ns | 0.0315 |     528 B |
