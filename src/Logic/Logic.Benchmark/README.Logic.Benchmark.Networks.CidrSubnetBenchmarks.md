```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **530.29 ns** |  **50.632 ns** |  **2.775 ns** |   **528.60 ns** |   **533.49 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.94 ns |   0.511 ns |  0.028 ns |   113.91 ns |   113.96 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   243.10 ns |  17.947 ns |  0.984 ns |   242.11 ns |   244.07 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.76 ns |   3.574 ns |  0.196 ns |    41.58 ns |    41.97 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.87 ns |  27.530 ns |  1.509 ns |   140.82 ns |   143.60 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.00 ns |   3.900 ns |  0.214 ns |    39.81 ns |    40.23 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,601.25 ns** | **434.582 ns** | **23.821 ns** | **1,586.53 ns** | **1,628.74 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   353.23 ns |  42.757 ns |  2.344 ns |   351.17 ns |   355.78 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   735.32 ns |  16.464 ns |  0.902 ns |   734.56 ns |   736.31 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.90 ns |  15.787 ns |  0.865 ns |   125.93 ns |   127.61 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   454.86 ns |  42.972 ns |  2.355 ns |   453.24 ns |   457.56 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.64 ns |  17.102 ns |  0.937 ns |   116.58 ns |   118.35 ns | 0.0062 |     528 B |
