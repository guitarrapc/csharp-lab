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
| **GetNthSubnetIPv6**             | **1**      |   **496.91 ns** | **71.984 ns** | **3.946 ns** |   **492.98 ns** |   **500.87 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.53 ns |  1.119 ns | 0.061 ns |   113.47 ns |   113.59 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   226.76 ns | 19.986 ns | 1.095 ns |   226.10 ns |   228.03 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.76 ns |  7.130 ns | 0.391 ns |    40.46 ns |    41.20 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   138.79 ns |  6.778 ns | 0.372 ns |   138.50 ns |   139.21 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.66 ns | 15.678 ns | 0.859 ns |    38.04 ns |    39.64 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,566.20 ns** | **84.073 ns** | **4.608 ns** | **1,561.53 ns** | **1,570.75 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.99 ns | 18.160 ns | 0.995 ns |   345.07 ns |   347.04 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   720.51 ns | 90.262 ns | 4.948 ns |   715.05 ns |   724.69 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   121.71 ns | 20.168 ns | 1.106 ns |   120.81 ns |   122.94 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   420.53 ns | 51.080 ns | 2.800 ns |   418.36 ns |   423.69 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   114.19 ns | 10.818 ns | 0.593 ns |   113.53 ns |   114.66 ns | 0.0062 |     528 B |
