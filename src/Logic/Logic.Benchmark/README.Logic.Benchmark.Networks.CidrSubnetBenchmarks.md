```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **544.25 ns** |  **19.620 ns** |  **1.075 ns** |   **543.49 ns** |   **545.48 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.16 ns |   5.613 ns |  0.308 ns |   115.97 ns |   116.51 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.08 ns |  15.716 ns |  0.861 ns |   234.10 ns |   235.68 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.56 ns |   2.925 ns |  0.160 ns |    42.38 ns |    42.66 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   185.14 ns | 578.320 ns | 31.700 ns |   148.54 ns |   203.88 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.64 ns |   1.489 ns |  0.082 ns |    40.55 ns |    40.70 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,621.00 ns** | **471.467 ns** | **25.843 ns** | **1,591.63 ns** | **1,640.26 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.06 ns |  40.566 ns |  2.224 ns |   345.52 ns |   349.66 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   753.72 ns |  12.246 ns |  0.671 ns |   752.96 ns |   754.22 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.36 ns |  30.487 ns |  1.671 ns |   126.78 ns |   130.11 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   467.13 ns | 102.136 ns |  5.598 ns |   462.39 ns |   473.31 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.29 ns |  27.261 ns |  1.494 ns |   121.33 ns |   124.02 ns | 0.0062 |     528 B |
