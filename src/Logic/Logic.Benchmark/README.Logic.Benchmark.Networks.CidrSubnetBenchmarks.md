```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **503.11 ns** |  **48.003 ns** | **2.631 ns** |   **501.18 ns** |   **506.11 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.54 ns |   9.622 ns | 0.527 ns |   113.13 ns |   114.14 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.97 ns |  43.945 ns | 2.409 ns |   238.78 ns |   243.55 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.91 ns |   2.482 ns | 0.136 ns |    42.75 ns |    42.99 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   150.76 ns |   5.612 ns | 0.308 ns |   150.44 ns |   151.05 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.49 ns |   1.892 ns | 0.104 ns |    40.40 ns |    40.61 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,592.49 ns** |  **89.511 ns** | **4.906 ns** | **1,588.66 ns** | **1,598.02 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.40 ns |   1.210 ns | 0.066 ns |   348.36 ns |   348.48 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   753.76 ns |  29.548 ns | 1.620 ns |   752.48 ns |   755.58 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   130.23 ns |  14.796 ns | 0.811 ns |   129.34 ns |   130.93 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   431.29 ns | 120.293 ns | 6.594 ns |   427.34 ns |   438.91 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.63 ns |  82.385 ns | 4.516 ns |   119.63 ns |   127.83 ns | 0.0062 |     528 B |
