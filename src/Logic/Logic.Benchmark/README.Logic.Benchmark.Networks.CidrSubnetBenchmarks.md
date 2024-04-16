```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **508.66 ns** |  **26.106 ns** | **1.431 ns** |   **507.80 ns** |   **510.31 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.28 ns |   2.183 ns | 0.120 ns |   116.15 ns |   116.39 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.95 ns |   4.973 ns | 0.273 ns |   234.66 ns |   235.20 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.63 ns |   3.840 ns | 0.210 ns |    42.41 ns |    42.83 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.39 ns |   9.889 ns | 0.542 ns |   140.97 ns |   142.00 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.13 ns |  19.761 ns | 1.083 ns |    39.34 ns |    41.37 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,642.28 ns** |  **32.880 ns** | **1.802 ns** | **1,640.58 ns** | **1,644.17 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   353.82 ns |  86.768 ns | 4.756 ns |   348.35 ns |   356.93 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   714.17 ns |  15.518 ns | 0.851 ns |   713.49 ns |   715.12 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.68 ns |   2.400 ns | 0.132 ns |   125.54 ns |   125.79 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   453.61 ns | 110.018 ns | 6.030 ns |   449.51 ns |   460.54 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.15 ns |  34.392 ns | 1.885 ns |   120.82 ns |   124.31 ns | 0.0062 |     528 B |
