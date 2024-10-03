```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **515.65 ns** | **45.062 ns** | **2.470 ns** |   **513.30 ns** |   **518.23 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.87 ns |  2.548 ns | 0.140 ns |   113.73 ns |   114.01 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.19 ns |  5.360 ns | 0.294 ns |   238.95 ns |   239.52 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    47.42 ns |  2.780 ns | 0.152 ns |    47.28 ns |    47.58 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.18 ns |  2.142 ns | 0.117 ns |   139.05 ns |   139.25 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.28 ns | 13.994 ns | 0.767 ns |    38.65 ns |    40.13 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,604.29 ns** | **58.241 ns** | **3.192 ns** | **1,600.61 ns** | **1,606.19 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   383.73 ns | 74.513 ns | 4.084 ns |   381.23 ns |   388.44 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   728.01 ns | 19.247 ns | 1.055 ns |   726.85 ns |   728.92 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.80 ns | 16.912 ns | 0.927 ns |   125.11 ns |   126.85 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   427.12 ns |  2.517 ns | 0.138 ns |   427.00 ns |   427.27 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.12 ns |  5.967 ns | 0.327 ns |   117.89 ns |   118.50 ns | 0.0062 |     528 B |
