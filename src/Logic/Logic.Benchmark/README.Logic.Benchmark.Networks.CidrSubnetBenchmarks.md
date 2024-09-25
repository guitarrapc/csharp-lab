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
| **GetNthSubnetIPv6**             | **1**      |   **496.52 ns** | **18.217 ns** | **0.999 ns** |   **495.60 ns** |   **497.58 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   132.69 ns |  6.662 ns | 0.365 ns |   132.37 ns |   133.09 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   244.34 ns |  9.826 ns | 0.539 ns |   243.89 ns |   244.94 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    45.56 ns |  1.907 ns | 0.105 ns |    45.44 ns |    45.64 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.08 ns |  5.849 ns | 0.321 ns |   140.74 ns |   141.38 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.46 ns |  4.540 ns | 0.249 ns |    40.19 ns |    40.68 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,586.93 ns** |  **3.148 ns** | **0.173 ns** | **1,586.74 ns** | **1,587.08 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   352.88 ns | 10.333 ns | 0.566 ns |   352.38 ns |   353.49 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   737.01 ns | 17.472 ns | 0.958 ns |   735.92 ns |   737.71 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   131.14 ns | 75.471 ns | 4.137 ns |   128.58 ns |   135.92 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   438.86 ns | 15.901 ns | 0.872 ns |   437.94 ns |   439.67 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.95 ns |  2.915 ns | 0.160 ns |   118.79 ns |   119.11 ns | 0.0062 |     528 B |
