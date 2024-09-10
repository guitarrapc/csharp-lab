```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **489.54 ns** | **23.036 ns** | **1.263 ns** |   **488.64 ns** |   **490.98 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.17 ns |  3.207 ns | 0.176 ns |   116.06 ns |   116.38 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.71 ns | 88.592 ns | 4.856 ns |   237.87 ns |   246.32 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.32 ns |  5.029 ns | 0.276 ns |    41.01 ns |    41.52 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.03 ns | 22.058 ns | 1.209 ns |   140.21 ns |   142.42 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.94 ns |  2.474 ns | 0.136 ns |    38.81 ns |    39.08 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,601.13 ns** | **25.085 ns** | **1.375 ns** | **1,600.05 ns** | **1,602.68 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   344.30 ns |  0.036 ns | 0.002 ns |   344.30 ns |   344.30 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   732.59 ns | 15.895 ns | 0.871 ns |   732.05 ns |   733.59 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.46 ns | 16.355 ns | 0.896 ns |   123.43 ns |   125.05 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   419.95 ns | 11.808 ns | 0.647 ns |   419.29 ns |   420.58 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.26 ns |  4.123 ns | 0.226 ns |   116.03 ns |   116.48 ns | 0.0062 |     528 B |
