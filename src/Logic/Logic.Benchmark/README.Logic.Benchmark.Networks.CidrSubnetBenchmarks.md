```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **520.29 ns** |  **37.432 ns** |  **2.052 ns** |   **519.09 ns** |   **522.66 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.17 ns |   2.211 ns |  0.121 ns |   116.04 ns |   116.28 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   246.63 ns |  15.505 ns |  0.850 ns |   245.70 ns |   247.37 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.15 ns |   3.047 ns |  0.167 ns |    42.00 ns |    42.33 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.72 ns |   5.437 ns |  0.298 ns |   142.39 ns |   142.95 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.87 ns |   5.026 ns |  0.275 ns |    39.57 ns |    40.11 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,592.00 ns** | **370.894 ns** | **20.330 ns** | **1,575.08 ns** | **1,614.56 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   342.87 ns |   5.367 ns |  0.294 ns |   342.56 ns |   343.14 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   722.68 ns |  28.248 ns |  1.548 ns |   721.32 ns |   724.36 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.77 ns |  13.590 ns |  0.745 ns |   124.09 ns |   125.57 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   430.04 ns |  12.342 ns |  0.676 ns |   429.27 ns |   430.52 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.74 ns |   5.245 ns |  0.288 ns |   117.48 ns |   118.05 ns | 0.0062 |     528 B |
