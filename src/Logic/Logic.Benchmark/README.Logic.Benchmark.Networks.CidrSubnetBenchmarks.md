```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **500.77 ns** | **60.808 ns** | **3.333 ns** |   **497.42 ns** |   **504.09 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.19 ns | 19.827 ns | 1.087 ns |   113.05 ns |   115.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.36 ns | 14.223 ns | 0.780 ns |   232.66 ns |   234.20 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.99 ns |  2.273 ns | 0.125 ns |    41.86 ns |    42.11 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   148.96 ns |  1.621 ns | 0.089 ns |   148.90 ns |   149.07 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.81 ns |  4.010 ns | 0.220 ns |    39.56 ns |    39.98 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,621.04 ns** | **54.438 ns** | **2.984 ns** | **1,619.30 ns** | **1,624.49 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.02 ns | 11.344 ns | 0.622 ns |   347.32 ns |   348.51 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   718.92 ns | 20.494 ns | 1.123 ns |   717.66 ns |   719.82 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.11 ns | 19.319 ns | 1.059 ns |   123.93 ns |   125.98 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   440.96 ns | 27.176 ns | 1.490 ns |   439.31 ns |   442.20 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.38 ns |  8.502 ns | 0.466 ns |   114.94 ns |   115.87 ns | 0.0062 |     528 B |
