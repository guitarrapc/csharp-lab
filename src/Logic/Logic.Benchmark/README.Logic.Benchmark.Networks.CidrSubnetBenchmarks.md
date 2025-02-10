```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **458.81 ns** |  **22.800 ns** | **1.250 ns** |   **458.03 ns** |   **460.25 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    95.83 ns |  15.259 ns | 0.836 ns |    94.97 ns |    96.64 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.75 ns |   4.279 ns | 0.235 ns |   233.53 ns |   234.00 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    39.96 ns |   3.577 ns | 0.196 ns |    39.78 ns |    40.17 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.33 ns |  11.002 ns | 0.603 ns |   138.80 ns |   139.99 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    30.06 ns |   2.247 ns | 0.123 ns |    29.94 ns |    30.19 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,376.64 ns** | **137.395 ns** | **7.531 ns** | **1,368.45 ns** | **1,383.27 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   279.11 ns |  40.053 ns | 2.195 ns |   277.73 ns |   281.64 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   702.61 ns | 155.804 ns | 8.540 ns |   696.28 ns |   712.32 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   117.60 ns |   7.471 ns | 0.409 ns |   117.16 ns |   117.96 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   443.67 ns |  37.707 ns | 2.067 ns |   441.80 ns |   445.89 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    88.22 ns |  13.071 ns | 0.716 ns |    87.50 ns |    88.93 ns | 0.0315 |     528 B |
