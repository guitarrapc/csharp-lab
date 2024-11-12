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
| **GetNthSubnetIPv6**             | **1**      |   **504.82 ns** | **16.077 ns** | **0.881 ns** |   **503.90 ns** |   **505.66 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   132.43 ns |  5.849 ns | 0.321 ns |   132.13 ns |   132.77 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.09 ns | 16.001 ns | 0.877 ns |   239.25 ns |   241.00 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.68 ns |  8.380 ns | 0.459 ns |    42.15 ns |    43.00 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   149.41 ns |  7.535 ns | 0.413 ns |   148.93 ns |   149.68 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.25 ns |  3.686 ns | 0.202 ns |    39.07 ns |    39.47 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,574.21 ns** | **61.190 ns** | **3.354 ns** | **1,572.20 ns** | **1,578.08 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   340.86 ns | 19.648 ns | 1.077 ns |   339.79 ns |   341.95 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   728.75 ns | 18.798 ns | 1.030 ns |   727.66 ns |   729.71 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.51 ns | 11.810 ns | 0.647 ns |   126.80 ns |   128.07 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   461.06 ns | 21.710 ns | 1.190 ns |   460.02 ns |   462.36 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.47 ns | 20.208 ns | 1.108 ns |   117.83 ns |   119.75 ns | 0.0062 |     528 B |
