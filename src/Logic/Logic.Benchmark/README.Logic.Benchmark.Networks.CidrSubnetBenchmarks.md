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
| **GetNthSubnetIPv6**             | **1**      |   **500.99 ns** | **23.120 ns** | **1.267 ns** |   **499.59 ns** |   **502.06 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.34 ns |  2.807 ns | 0.154 ns |   112.16 ns |   112.44 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   231.28 ns |  6.085 ns | 0.334 ns |   230.92 ns |   231.56 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.61 ns |  0.578 ns | 0.032 ns |    41.58 ns |    41.64 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.72 ns | 25.043 ns | 1.373 ns |   143.71 ns |   146.28 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.93 ns |  1.343 ns | 0.074 ns |    39.84 ns |    39.98 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,520.32 ns** | **35.538 ns** | **1.948 ns** | **1,518.32 ns** | **1,522.21 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   340.56 ns | 24.745 ns | 1.356 ns |   339.29 ns |   341.99 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   712.26 ns | 32.931 ns | 1.805 ns |   710.19 ns |   713.48 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.03 ns | 18.054 ns | 0.990 ns |   124.11 ns |   126.07 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   424.00 ns | 17.404 ns | 0.954 ns |   422.91 ns |   424.64 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   129.95 ns | 15.714 ns | 0.861 ns |   128.98 ns |   130.64 ns | 0.0062 |     528 B |
