```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **507.93 ns** |  **57.856 ns** |  **3.171 ns** |   **504.31 ns** |   **510.22 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   121.50 ns |   4.295 ns |  0.235 ns |   121.24 ns |   121.70 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   247.67 ns |   3.348 ns |  0.184 ns |   247.54 ns |   247.88 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.26 ns |   1.931 ns |  0.106 ns |    42.15 ns |    42.36 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.84 ns |  20.942 ns |  1.148 ns |   139.91 ns |   142.12 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.26 ns |   4.011 ns |  0.220 ns |    39.01 ns |    39.44 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,712.13 ns** | **236.999 ns** | **12.991 ns** | **1,697.44 ns** | **1,722.09 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   352.48 ns |  18.520 ns |  1.015 ns |   351.55 ns |   353.56 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   733.12 ns |  15.050 ns |  0.825 ns |   732.64 ns |   734.08 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.68 ns |  15.952 ns |  0.874 ns |   124.87 ns |   126.61 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   428.49 ns |   6.885 ns |  0.377 ns |   428.09 ns |   428.84 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   134.08 ns |  14.973 ns |  0.821 ns |   133.38 ns |   134.98 ns | 0.0062 |     528 B |
