```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **507.19 ns** | **21.790 ns** | **1.194 ns** |   **506.04 ns** |   **508.43 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.33 ns |  4.074 ns | 0.223 ns |   117.13 ns |   117.57 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.40 ns |  4.664 ns | 0.256 ns |   235.25 ns |   235.70 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.73 ns |  3.047 ns | 0.167 ns |    43.57 ns |    43.90 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   158.20 ns |  9.236 ns | 0.506 ns |   157.83 ns |   158.77 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.19 ns |  1.776 ns | 0.097 ns |    39.10 ns |    39.29 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,568.93 ns** | **77.309 ns** | **4.238 ns** | **1,565.62 ns** | **1,573.70 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   340.44 ns | 14.365 ns | 0.787 ns |   339.59 ns |   341.16 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   711.52 ns | 30.129 ns | 1.651 ns |   709.65 ns |   712.79 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.48 ns |  6.438 ns | 0.353 ns |   126.11 ns |   126.82 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.70 ns | 10.715 ns | 0.587 ns |   425.26 ns |   426.37 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.76 ns | 10.671 ns | 0.585 ns |   116.23 ns |   117.39 ns | 0.0062 |     528 B |
