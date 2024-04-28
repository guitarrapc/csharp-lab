```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **520.09 ns** |    **46.582 ns** |  **2.553 ns** |   **517.91 ns** |   **522.90 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   118.04 ns |    19.607 ns |  1.075 ns |   117.16 ns |   119.24 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.21 ns |     1.498 ns |  0.082 ns |   239.11 ns |   239.26 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.12 ns |     2.214 ns |  0.121 ns |    42.99 ns |    43.23 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.17 ns |     8.554 ns |  0.469 ns |   140.83 ns |   141.70 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.98 ns |     2.354 ns |  0.129 ns |    40.85 ns |    41.11 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,617.69 ns** | **1,024.423 ns** | **56.152 ns** | **1,582.24 ns** | **1,682.43 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   356.19 ns |     1.469 ns |  0.081 ns |   356.13 ns |   356.28 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   735.51 ns |    31.737 ns |  1.740 ns |   733.96 ns |   737.39 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.00 ns |    15.820 ns |  0.867 ns |   126.19 ns |   127.92 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.16 ns |   135.655 ns |  7.436 ns |   420.19 ns |   433.71 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.57 ns |     7.064 ns |  0.387 ns |   120.13 ns |   120.86 ns | 0.0062 |     528 B |
