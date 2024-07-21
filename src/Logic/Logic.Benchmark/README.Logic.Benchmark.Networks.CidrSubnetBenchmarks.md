```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **497.12 ns** |  **46.828 ns** |  **2.567 ns** |   **495.59 ns** |   **500.08 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.14 ns |   3.488 ns |  0.191 ns |   112.92 ns |   113.26 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.11 ns |  15.606 ns |  0.855 ns |   232.36 ns |   234.04 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.52 ns |   2.451 ns |  0.134 ns |    41.37 ns |    41.63 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.18 ns |   9.100 ns |  0.499 ns |   139.61 ns |   140.55 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.18 ns |  25.719 ns |  1.410 ns |    39.07 ns |    41.77 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,620.30 ns** | **771.405 ns** | **42.283 ns** | **1,594.62 ns** | **1,669.10 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   391.96 ns | 259.306 ns | 14.213 ns |   375.55 ns |   400.35 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   724.90 ns |  61.368 ns |  3.364 ns |   722.54 ns |   728.76 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.21 ns |  15.514 ns |  0.850 ns |   123.57 ns |   125.17 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   419.50 ns |  36.565 ns |  2.004 ns |   417.55 ns |   421.56 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.32 ns |  36.008 ns |  1.974 ns |   115.14 ns |   118.99 ns | 0.0062 |     528 B |
