```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.24 ns** | **15.107 ns** | **0.828 ns** |   **504.41 ns** |   **506.07 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.17 ns |  4.172 ns | 0.229 ns |   113.01 ns |   113.43 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.42 ns |  8.992 ns | 0.493 ns |   231.85 ns |   232.76 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.77 ns |  1.788 ns | 0.098 ns |    41.68 ns |    41.88 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.71 ns |  3.684 ns | 0.202 ns |   145.49 ns |   145.88 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.95 ns |  5.510 ns | 0.302 ns |    39.62 ns |    40.21 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,636.19 ns** | **34.368 ns** | **1.884 ns** | **1,634.32 ns** | **1,638.09 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.16 ns |  8.165 ns | 0.448 ns |   347.64 ns |   348.44 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   728.00 ns | 13.871 ns | 0.760 ns |   727.13 ns |   728.50 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.64 ns |  2.642 ns | 0.145 ns |   125.53 ns |   125.81 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   440.12 ns | 18.954 ns | 1.039 ns |   439.22 ns |   441.26 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.48 ns | 11.342 ns | 0.622 ns |   115.76 ns |   116.87 ns | 0.0062 |     528 B |
