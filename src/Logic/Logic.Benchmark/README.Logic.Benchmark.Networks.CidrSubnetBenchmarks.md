```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **511.41 ns** | **37.892 ns** | **2.077 ns** |   **509.52 ns** |   **513.63 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   121.64 ns |  5.691 ns | 0.312 ns |   121.28 ns |   121.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.89 ns | 21.427 ns | 1.174 ns |   235.13 ns |   237.24 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.18 ns |  3.928 ns | 0.215 ns |    41.93 ns |    42.32 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.85 ns |  2.754 ns | 0.151 ns |   142.70 ns |   143.00 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.53 ns |  3.666 ns | 0.201 ns |    39.32 ns |    39.72 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,572.12 ns** | **67.183 ns** | **3.683 ns** | **1,568.53 ns** | **1,575.89 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.59 ns |  6.577 ns | 0.361 ns |   347.27 ns |   347.98 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   737.96 ns | 13.077 ns | 0.717 ns |   737.33 ns |   738.74 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.43 ns |  5.501 ns | 0.302 ns |   124.16 ns |   124.76 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.69 ns | 31.578 ns | 1.731 ns |   423.92 ns |   427.38 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.56 ns | 42.153 ns | 2.311 ns |   114.75 ns |   119.16 ns | 0.0062 |     528 B |
