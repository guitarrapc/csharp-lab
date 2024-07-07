```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **498.97 ns** |  **21.081 ns** |  **1.156 ns** |   **498.27 ns** |   **500.30 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.32 ns |   8.328 ns |  0.457 ns |   111.91 ns |   112.81 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.00 ns |   8.093 ns |  0.444 ns |   232.71 ns |   233.51 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    45.30 ns |   4.006 ns |  0.220 ns |    45.07 ns |    45.51 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.37 ns |  12.716 ns |  0.697 ns |   139.77 ns |   141.13 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.74 ns |   3.403 ns |  0.187 ns |    39.54 ns |    39.91 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,569.68 ns** | **141.523 ns** |  **7.757 ns** | **1,564.25 ns** | **1,578.57 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.07 ns | 101.900 ns |  5.585 ns |   342.79 ns |   353.92 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   718.83 ns |  33.704 ns |  1.847 ns |   717.15 ns |   720.81 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   129.64 ns |  71.444 ns |  3.916 ns |   126.27 ns |   133.94 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.60 ns | 188.663 ns | 10.341 ns |   419.01 ns |   437.52 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.28 ns |  14.868 ns |  0.815 ns |   117.50 ns |   119.12 ns | 0.0062 |     528 B |
