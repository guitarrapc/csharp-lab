```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.55 ns** | **28.579 ns** | **1.567 ns** |   **504.64 ns** |   **507.36 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.33 ns |  1.635 ns | 0.090 ns |   114.24 ns |   114.42 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   246.48 ns |  3.846 ns | 0.211 ns |   246.24 ns |   246.61 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    51.69 ns |  2.388 ns | 0.131 ns |    51.60 ns |    51.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.26 ns | 19.644 ns | 1.077 ns |   143.64 ns |   145.51 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.94 ns | 18.752 ns | 1.028 ns |    40.33 ns |    42.13 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,638.65 ns** | **31.299 ns** | **1.716 ns** | **1,637.19 ns** | **1,640.54 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   357.79 ns | 12.113 ns | 0.664 ns |   357.35 ns |   358.55 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   777.41 ns | 16.541 ns | 0.907 ns |   776.48 ns |   778.29 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.00 ns | 54.994 ns | 3.014 ns |   125.50 ns |   131.35 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   438.87 ns | 20.760 ns | 1.138 ns |   437.79 ns |   440.05 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.91 ns | 24.255 ns | 1.330 ns |   116.85 ns |   119.41 ns | 0.0062 |     528 B |
