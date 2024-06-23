```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **511.61 ns** | **17.051 ns** | **0.935 ns** |   **510.83 ns** |   **512.65 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.88 ns |  5.030 ns | 0.276 ns |   113.65 ns |   114.19 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.21 ns | 11.793 ns | 0.646 ns |   239.71 ns |   240.94 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    51.28 ns |  4.058 ns | 0.222 ns |    51.14 ns |    51.54 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.16 ns |  1.255 ns | 0.069 ns |   142.11 ns |   142.24 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    44.96 ns | 24.703 ns | 1.354 ns |    43.94 ns |    46.50 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,600.66 ns** | **49.674 ns** | **2.723 ns** | **1,598.18 ns** | **1,603.58 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.46 ns | 22.443 ns | 1.230 ns |   346.08 ns |   348.43 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   727.67 ns | 13.332 ns | 0.731 ns |   726.96 ns |   728.42 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   132.22 ns | 13.068 ns | 0.716 ns |   131.47 ns |   132.90 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   424.80 ns | 12.840 ns | 0.704 ns |   424.23 ns |   425.59 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.60 ns | 20.027 ns | 1.098 ns |   119.55 ns |   121.74 ns | 0.0062 |     528 B |
