```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **434.19 ns** | **10.342 ns** | **0.567 ns** |   **433.84 ns** |   **434.85 ns** | **0.0076** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    96.96 ns |  2.660 ns | 0.146 ns |    96.83 ns |    97.12 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.11 ns | 33.576 ns | 1.840 ns |   240.79 ns |   244.21 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.68 ns |  2.569 ns | 0.141 ns |    42.52 ns |    42.77 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.52 ns | 11.680 ns | 0.640 ns |   141.11 ns |   142.26 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    34.43 ns |  2.582 ns | 0.142 ns |    34.31 ns |    34.59 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,402.31 ns** | **49.592 ns** | **2.718 ns** | **1,399.47 ns** | **1,404.89 ns** | **0.0229** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   292.11 ns | 18.683 ns | 1.024 ns |   291.46 ns |   293.29 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   729.26 ns | 36.492 ns | 2.000 ns |   727.04 ns |   730.94 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.51 ns | 14.770 ns | 0.810 ns |   125.70 ns |   127.32 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   458.50 ns | 40.492 ns | 2.220 ns |   456.09 ns |   460.46 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   101.24 ns | 12.296 ns | 0.674 ns |   100.60 ns |   101.94 ns | 0.0062 |     528 B |
