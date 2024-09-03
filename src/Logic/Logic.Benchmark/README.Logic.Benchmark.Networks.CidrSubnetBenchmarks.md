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
| **GetNthSubnetIPv6**             | **1**      |   **500.22 ns** | **16.392 ns** | **0.899 ns** |   **499.48 ns** |   **501.22 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   121.35 ns | 20.159 ns | 1.105 ns |   120.24 ns |   122.45 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.47 ns |  1.293 ns | 0.071 ns |   234.39 ns |   234.54 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.70 ns |  5.264 ns | 0.289 ns |    40.37 ns |    40.89 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   150.78 ns |  8.213 ns | 0.450 ns |   150.30 ns |   151.19 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.66 ns |  9.926 ns | 0.544 ns |    38.11 ns |    39.20 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,571.34 ns** | **68.595 ns** | **3.760 ns** | **1,567.02 ns** | **1,573.87 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   362.53 ns |  3.960 ns | 0.217 ns |   362.29 ns |   362.72 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   731.18 ns | 36.776 ns | 2.016 ns |   729.29 ns |   733.30 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.95 ns |  4.758 ns | 0.261 ns |   123.65 ns |   124.13 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   439.58 ns | 33.115 ns | 1.815 ns |   437.86 ns |   441.48 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.47 ns | 14.523 ns | 0.796 ns |   115.89 ns |   117.38 ns | 0.0062 |     528 B |
