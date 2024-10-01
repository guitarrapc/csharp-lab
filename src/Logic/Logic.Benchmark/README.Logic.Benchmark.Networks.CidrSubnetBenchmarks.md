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
| **GetNthSubnetIPv6**             | **1**      |   **505.21 ns** | **14.948 ns** | **0.819 ns** |   **504.68 ns** |   **506.15 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.50 ns |  1.990 ns | 0.109 ns |   117.42 ns |   117.63 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.12 ns | 30.858 ns | 1.691 ns |   238.57 ns |   241.93 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.42 ns |  5.475 ns | 0.300 ns |    42.08 ns |    42.61 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.80 ns |  3.471 ns | 0.190 ns |   143.67 ns |   144.02 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.23 ns |  1.555 ns | 0.085 ns |    39.18 ns |    39.33 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,590.15 ns** |  **5.043 ns** | **0.276 ns** | **1,589.94 ns** | **1,590.46 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   342.01 ns | 12.373 ns | 0.678 ns |   341.35 ns |   342.70 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   731.19 ns | 55.886 ns | 3.063 ns |   727.65 ns |   732.98 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   132.79 ns |  4.009 ns | 0.220 ns |   132.55 ns |   132.98 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   449.86 ns | 49.961 ns | 2.739 ns |   448.17 ns |   453.02 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.52 ns | 16.543 ns | 0.907 ns |   115.83 ns |   117.55 ns | 0.0062 |     528 B |
