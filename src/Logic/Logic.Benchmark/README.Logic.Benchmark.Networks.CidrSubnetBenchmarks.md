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
| **GetNthSubnetIPv6**             | **1**      |   **512.57 ns** | **50.409 ns** | **2.763 ns** |   **509.62 ns** |   **515.10 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.70 ns |  2.562 ns | 0.140 ns |   113.57 ns |   113.85 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   229.37 ns |  5.928 ns | 0.325 ns |   229.03 ns |   229.68 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.95 ns | 15.053 ns | 0.825 ns |    41.21 ns |    42.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   149.06 ns |  8.933 ns | 0.490 ns |   148.60 ns |   149.58 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    43.44 ns |  4.953 ns | 0.271 ns |    43.15 ns |    43.69 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,577.90 ns** | **73.026 ns** | **4.003 ns** | **1,574.73 ns** | **1,582.39 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   339.83 ns | 18.043 ns | 0.989 ns |   339.20 ns |   340.97 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   722.47 ns |  9.029 ns | 0.495 ns |   722.14 ns |   723.04 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   122.47 ns |  4.878 ns | 0.267 ns |   122.24 ns |   122.76 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   420.96 ns | 15.536 ns | 0.852 ns |   420.42 ns |   421.95 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   113.39 ns | 10.348 ns | 0.567 ns |   112.75 ns |   113.83 ns | 0.0062 |     528 B |
