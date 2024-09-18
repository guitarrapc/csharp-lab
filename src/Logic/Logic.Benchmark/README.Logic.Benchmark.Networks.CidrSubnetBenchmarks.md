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
| **GetNthSubnetIPv6**             | **1**      |   **498.90 ns** | **31.783 ns** | **1.742 ns** |   **497.49 ns** |   **500.85 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.83 ns |  3.933 ns | 0.216 ns |   114.60 ns |   115.03 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.24 ns |  7.760 ns | 0.425 ns |   231.86 ns |   232.70 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.63 ns |  1.549 ns | 0.085 ns |    41.53 ns |    41.68 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.15 ns |  4.015 ns | 0.220 ns |   140.02 ns |   140.41 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.01 ns |  2.539 ns | 0.139 ns |    38.88 ns |    39.16 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,727.55 ns** | **49.487 ns** | **2.713 ns** | **1,724.71 ns** | **1,730.12 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   341.77 ns | 33.892 ns | 1.858 ns |   340.03 ns |   343.73 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   723.01 ns | 30.308 ns | 1.661 ns |   721.28 ns |   724.60 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.97 ns |  7.108 ns | 0.390 ns |   123.65 ns |   124.41 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   426.69 ns | 80.972 ns | 4.438 ns |   424.00 ns |   431.82 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.46 ns |  6.433 ns | 0.353 ns |   116.06 ns |   116.70 ns | 0.0062 |     528 B |
