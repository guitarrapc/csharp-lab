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
| **GetNthSubnetIPv6**             | **1**      |   **521.75 ns** | **16.210 ns** | **0.889 ns** |   **520.81 ns** |   **522.58 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.66 ns |  6.631 ns | 0.363 ns |   112.40 ns |   113.08 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.35 ns |  2.254 ns | 0.124 ns |   236.23 ns |   236.47 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.58 ns |  3.331 ns | 0.183 ns |    41.42 ns |    41.78 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   150.43 ns | 27.979 ns | 1.534 ns |   149.21 ns |   152.15 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.31 ns | 10.240 ns | 0.561 ns |    38.90 ns |    39.95 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,525.19 ns** | **74.750 ns** | **4.097 ns** | **1,520.77 ns** | **1,528.86 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   340.50 ns | 17.162 ns | 0.941 ns |   339.72 ns |   341.54 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   709.56 ns | 44.124 ns | 2.419 ns |   706.79 ns |   711.23 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.32 ns |  9.067 ns | 0.497 ns |   123.93 ns |   124.88 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   437.30 ns |  5.170 ns | 0.283 ns |   437.01 ns |   437.58 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.33 ns | 10.170 ns | 0.557 ns |   116.84 ns |   117.94 ns | 0.0062 |     528 B |
