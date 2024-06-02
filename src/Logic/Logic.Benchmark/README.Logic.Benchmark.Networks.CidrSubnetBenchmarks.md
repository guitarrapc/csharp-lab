```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **509.57 ns** | **24.877 ns** | **1.364 ns** |   **508.16 ns** |   **510.88 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   111.86 ns |  5.021 ns | 0.275 ns |   111.56 ns |   112.10 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   248.78 ns | 86.394 ns | 4.736 ns |   245.71 ns |   254.23 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.60 ns |  2.295 ns | 0.126 ns |    43.46 ns |    43.69 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   138.66 ns |  5.261 ns | 0.288 ns |   138.34 ns |   138.89 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.73 ns |  1.046 ns | 0.057 ns |    38.68 ns |    38.79 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,557.73 ns** | **56.327 ns** | **3.087 ns** | **1,555.23 ns** | **1,561.18 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   358.13 ns | 12.160 ns | 0.667 ns |   357.37 ns |   358.61 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   721.32 ns | 26.385 ns | 1.446 ns |   719.65 ns |   722.16 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.23 ns | 49.684 ns | 2.723 ns |   123.86 ns |   129.21 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   423.10 ns | 36.573 ns | 2.005 ns |   421.12 ns |   425.13 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.44 ns | 11.592 ns | 0.635 ns |   117.80 ns |   119.08 ns | 0.0062 |     528 B |
