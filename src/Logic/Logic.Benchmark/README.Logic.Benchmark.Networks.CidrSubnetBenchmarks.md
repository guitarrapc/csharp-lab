```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **446.69 ns** |  **21.878 ns** |  **1.199 ns** |   **445.82 ns** |   **448.06 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    94.72 ns |  13.178 ns |  0.722 ns |    93.88 ns |    95.14 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.78 ns |  63.334 ns |  3.472 ns |   230.56 ns |   236.78 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.76 ns |   7.013 ns |  0.384 ns |    40.47 ns |    41.20 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.07 ns |  19.597 ns |  1.074 ns |   141.90 ns |   144.00 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    31.33 ns |  22.695 ns |  1.244 ns |    30.14 ns |    32.62 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,372.82 ns** | **284.998 ns** | **15.622 ns** | **1,358.05 ns** | **1,389.18 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   287.53 ns |  37.149 ns |  2.036 ns |   285.18 ns |   288.73 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   742.18 ns | 135.122 ns |  7.406 ns |   735.46 ns |   750.12 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   122.21 ns |  29.408 ns |  1.612 ns |   120.92 ns |   124.02 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   443.30 ns |  46.374 ns |  2.542 ns |   441.51 ns |   446.21 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    91.58 ns |  26.590 ns |  1.458 ns |    89.92 ns |    92.67 ns | 0.0315 |     528 B |
