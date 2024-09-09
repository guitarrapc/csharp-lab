```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **509.23 ns** | **21.160 ns** | **1.160 ns** |   **508.23 ns** |   **510.50 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.53 ns |  2.142 ns | 0.117 ns |   114.40 ns |   114.62 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   253.60 ns | 13.216 ns | 0.724 ns |   252.78 ns |   254.17 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.46 ns |  1.746 ns | 0.096 ns |    42.40 ns |    42.57 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   151.28 ns |  2.111 ns | 0.116 ns |   151.18 ns |   151.41 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.47 ns |  9.067 ns | 0.497 ns |    39.96 ns |    40.96 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,817.94 ns** | **34.790 ns** | **1.907 ns** | **1,815.91 ns** | **1,819.69 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.63 ns | 12.491 ns | 0.685 ns |   344.85 ns |   346.11 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   704.15 ns | 37.216 ns | 2.040 ns |   702.95 ns |   706.51 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.08 ns | 12.314 ns | 0.675 ns |   124.68 ns |   125.86 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.27 ns | 27.523 ns | 1.509 ns |   423.85 ns |   426.85 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.44 ns | 37.705 ns | 2.067 ns |   116.11 ns |   119.82 ns | 0.0062 |     528 B |
