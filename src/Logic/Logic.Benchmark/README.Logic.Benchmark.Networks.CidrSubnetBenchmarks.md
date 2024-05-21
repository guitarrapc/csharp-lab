```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.13 ns** | **13.687 ns** | **0.750 ns** |   **504.33 ns** |   **505.81 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.74 ns | 11.553 ns | 0.633 ns |   115.12 ns |   116.38 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.36 ns |  8.390 ns | 0.460 ns |   235.09 ns |   235.89 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.06 ns |  3.722 ns | 0.204 ns |    41.85 ns |    42.26 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.86 ns |  7.203 ns | 0.395 ns |   143.44 ns |   144.22 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.60 ns |  2.932 ns | 0.161 ns |    39.46 ns |    39.77 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,611.32 ns** | **58.942 ns** | **3.231 ns** | **1,607.96 ns** | **1,614.40 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   341.28 ns | 24.949 ns | 1.368 ns |   340.13 ns |   342.79 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   736.87 ns | 31.373 ns | 1.720 ns |   735.33 ns |   738.72 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.71 ns | 24.683 ns | 1.353 ns |   122.63 ns |   125.22 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   428.94 ns | 15.904 ns | 0.872 ns |   428.11 ns |   429.85 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.76 ns | 10.807 ns | 0.592 ns |   117.26 ns |   118.41 ns | 0.0062 |     528 B |
