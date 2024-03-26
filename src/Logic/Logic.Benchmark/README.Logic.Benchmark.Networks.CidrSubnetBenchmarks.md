```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **499.24 ns** | **202.447 ns** | **11.097 ns** |   **492.54 ns** |   **512.05 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.58 ns |  37.788 ns |  2.071 ns |   116.18 ns |   119.96 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   250.73 ns |   3.912 ns |  0.214 ns |   250.51 ns |   250.94 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.97 ns |  10.399 ns |  0.570 ns |    41.62 ns |    42.63 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.76 ns |  10.639 ns |  0.583 ns |   141.10 ns |   142.19 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.49 ns |   9.301 ns |  0.510 ns |    39.18 ns |    40.07 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,567.49 ns** |  **61.269 ns** |  **3.358 ns** | **1,564.41 ns** | **1,571.07 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.61 ns |  98.831 ns |  5.417 ns |   343.68 ns |   353.79 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   732.29 ns | 139.371 ns |  7.639 ns |   724.65 ns |   739.93 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.26 ns |   7.015 ns |  0.385 ns |   125.89 ns |   126.66 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   427.37 ns |  33.728 ns |  1.849 ns |   425.26 ns |   428.71 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.37 ns |   5.128 ns |  0.281 ns |   116.07 ns |   116.62 ns | 0.0062 |     528 B |
