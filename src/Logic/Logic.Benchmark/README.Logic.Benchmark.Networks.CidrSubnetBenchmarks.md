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
| **GetNthSubnetIPv6**             | **1**      |   **494.00 ns** |  **14.150 ns** |  **0.776 ns** |   **493.14 ns** |   **494.65 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   111.98 ns |   2.071 ns |  0.114 ns |   111.85 ns |   112.07 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.24 ns |   6.025 ns |  0.330 ns |   231.88 ns |   232.52 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.12 ns |   1.878 ns |  0.103 ns |    42.01 ns |    42.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   151.53 ns |   9.580 ns |  0.525 ns |   151.14 ns |   152.13 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.13 ns |   5.245 ns |  0.288 ns |    38.83 ns |    39.40 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,557.97 ns** | **398.620 ns** | **21.850 ns** | **1,544.88 ns** | **1,583.20 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   350.64 ns | 200.025 ns | 10.964 ns |   343.88 ns |   363.29 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   706.70 ns |  10.798 ns |  0.592 ns |   706.02 ns |   707.08 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.96 ns |  45.932 ns |  2.518 ns |   123.46 ns |   127.87 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   483.95 ns |  35.680 ns |  1.956 ns |   482.09 ns |   485.99 ns | 0.0067 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.44 ns |   6.518 ns |  0.357 ns |   117.13 ns |   117.83 ns | 0.0062 |     528 B |
