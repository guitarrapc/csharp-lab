```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.60 ns** | **28.751 ns** | **1.576 ns** |   **504.01 ns** |   **507.16 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.16 ns |  1.058 ns | 0.058 ns |   115.10 ns |   115.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   238.09 ns |  9.395 ns | 0.515 ns |   237.69 ns |   238.67 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.84 ns |  9.235 ns | 0.506 ns |    42.34 ns |    43.35 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   149.68 ns |  9.147 ns | 0.501 ns |   149.14 ns |   150.12 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.51 ns |  6.813 ns | 0.373 ns |    40.08 ns |    40.76 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,619.73 ns** | **65.974 ns** | **3.616 ns** | **1,617.64 ns** | **1,623.90 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   343.66 ns |  3.256 ns | 0.178 ns |   343.54 ns |   343.87 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   740.48 ns | 23.967 ns | 1.314 ns |   739.54 ns |   741.99 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   130.90 ns | 32.326 ns | 1.772 ns |   129.51 ns |   132.90 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   430.40 ns | 10.089 ns | 0.553 ns |   429.99 ns |   431.03 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   119.52 ns | 11.519 ns | 0.631 ns |   119.00 ns |   120.22 ns | 0.0062 |     528 B |
