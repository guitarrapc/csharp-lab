```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **504.31 ns** |  **25.783 ns** |  **1.413 ns** |   **503.22 ns** |   **505.91 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.28 ns |   8.880 ns |  0.487 ns |   112.84 ns |   113.80 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.16 ns |   6.168 ns |  0.338 ns |   232.82 ns |   233.49 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.72 ns |   1.925 ns |  0.106 ns |    41.60 ns |    41.78 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.16 ns |  47.310 ns |  2.593 ns |   142.33 ns |   147.13 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.98 ns |   6.423 ns |  0.352 ns |    38.64 ns |    39.35 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,557.90 ns** | **351.884 ns** | **19.288 ns** | **1,542.28 ns** | **1,579.46 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   357.05 ns | 102.178 ns |  5.601 ns |   350.58 ns |   360.31 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   710.21 ns | 202.525 ns | 11.101 ns |   702.72 ns |   722.96 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.03 ns |  14.789 ns |  0.811 ns |   125.13 ns |   126.71 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   439.34 ns | 222.973 ns | 12.222 ns |   432.22 ns |   453.45 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.36 ns |  11.043 ns |  0.605 ns |   114.70 ns |   115.88 ns | 0.0062 |     528 B |
