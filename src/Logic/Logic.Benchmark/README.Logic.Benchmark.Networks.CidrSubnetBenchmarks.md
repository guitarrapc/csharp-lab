```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **500.51 ns** |  **33.114 ns** |  **1.815 ns** |   **498.67 ns** |   **502.30 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.62 ns |   3.675 ns |  0.201 ns |   113.44 ns |   113.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   243.64 ns |  16.145 ns |  0.885 ns |   243.07 ns |   244.66 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.21 ns |   7.078 ns |  0.388 ns |    41.81 ns |    42.58 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.93 ns |   8.996 ns |  0.493 ns |   144.48 ns |   145.45 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.39 ns |  14.527 ns |  0.796 ns |    39.65 ns |    41.24 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,548.80 ns** |  **66.866 ns** |  **3.665 ns** | **1,545.27 ns** | **1,552.59 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.78 ns |  31.042 ns |  1.702 ns |   345.62 ns |   348.73 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   768.10 ns |  57.110 ns |  3.130 ns |   764.56 ns |   770.50 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   133.66 ns |   7.571 ns |  0.415 ns |   133.23 ns |   134.06 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   483.06 ns |  12.461 ns |  0.683 ns |   482.34 ns |   483.70 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   129.77 ns | 219.097 ns | 12.009 ns |   115.90 ns |   136.77 ns | 0.0062 |     528 B |
