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
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **482.17 ns** |  **26.056 ns** |  **1.428 ns** |   **481.26 ns** |   **483.82 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   117.17 ns |   2.067 ns |  0.113 ns |   117.07 ns |   117.29 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   221.84 ns |  14.122 ns |  0.774 ns |   221.16 ns |   222.69 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    44.21 ns |  14.821 ns |  0.812 ns |    43.28 ns |    44.72 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   139.26 ns |  13.782 ns |  0.755 ns |   138.80 ns |   140.13 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    34.88 ns |   6.806 ns |  0.373 ns |    34.45 ns |    35.10 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   428.33 ns |  13.374 ns |  0.733 ns |   427.48 ns |   428.80 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    96.18 ns |   2.779 ns |  0.152 ns |    96.02 ns |    96.33 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   226.60 ns |   8.763 ns |  0.480 ns |   226.20 ns |   227.13 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.12 ns |   6.710 ns |  0.368 ns |    40.72 ns |    41.44 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   143.84 ns |   6.392 ns |  0.350 ns |   143.45 ns |   144.13 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.93 ns |   5.983 ns |  0.328 ns |    31.57 ns |    32.22 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,521.48 ns** | **261.716 ns** | **14.346 ns** | **1,511.78 ns** | **1,537.96 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   343.52 ns |  14.947 ns |  0.819 ns |   342.59 ns |   344.13 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   681.93 ns |  43.142 ns |  2.365 ns |   679.56 ns |   684.29 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   114.18 ns |  14.879 ns |  0.816 ns |   113.26 ns |   114.81 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   406.13 ns |  49.118 ns |  2.692 ns |   403.89 ns |   409.12 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   102.94 ns |   8.949 ns |  0.491 ns |   102.39 ns |   103.34 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,344.99 ns |  49.919 ns |  2.736 ns | 1,343.13 ns | 1,348.13 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   283.52 ns |  37.422 ns |  2.051 ns |   281.20 ns |   285.08 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   713.94 ns |  59.522 ns |  3.263 ns |   710.24 ns |   716.39 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   135.52 ns |   5.178 ns |  0.284 ns |   135.28 ns |   135.83 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   429.36 ns |  26.193 ns |  1.436 ns |   428.06 ns |   430.90 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    87.19 ns |   9.068 ns |  0.497 ns |    86.63 ns |    87.58 ns | 0.0315 |     528 B |
