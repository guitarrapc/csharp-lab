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
| **GetNthSubnetIPv6**             | **1**      |   **506.50 ns** | **25.391 ns** | **1.392 ns** |   **505.33 ns** |   **508.04 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.59 ns |  6.793 ns | 0.372 ns |   112.20 ns |   112.94 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   238.51 ns |  8.659 ns | 0.475 ns |   238.07 ns |   239.01 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.97 ns |  6.698 ns | 0.367 ns |    41.65 ns |    42.37 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.08 ns |  7.999 ns | 0.438 ns |   144.65 ns |   145.53 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.60 ns |  5.851 ns | 0.321 ns |    38.27 ns |    38.91 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,569.05 ns** | **56.284 ns** | **3.085 ns** | **1,566.85 ns** | **1,572.58 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.48 ns |  3.202 ns | 0.176 ns |   347.30 ns |   347.65 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   738.05 ns | 18.433 ns | 1.010 ns |   736.96 ns |   738.96 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.39 ns | 17.395 ns | 0.953 ns |   123.70 ns |   125.48 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   421.61 ns | 17.242 ns | 0.945 ns |   421.00 ns |   422.69 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   113.86 ns | 23.731 ns | 1.301 ns |   112.74 ns |   115.29 ns | 0.0062 |     528 B |
