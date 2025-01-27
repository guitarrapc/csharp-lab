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
| **GetNthSubnetIPv6**             | **1**      |   **451.53 ns** |  **27.781 ns** | **1.523 ns** |   **449.96 ns** |   **453.00 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    93.56 ns |   4.236 ns | 0.232 ns |    93.42 ns |    93.82 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   230.76 ns |  37.692 ns | 2.066 ns |   229.13 ns |   233.08 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.21 ns |   2.154 ns | 0.118 ns |    40.11 ns |    40.34 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.83 ns |  30.898 ns | 1.694 ns |   140.07 ns |   143.45 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    30.03 ns |   6.794 ns | 0.372 ns |    29.69 ns |    30.43 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,360.28 ns** | **146.738 ns** | **8.043 ns** | **1,352.90 ns** | **1,368.86 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   282.85 ns |  33.351 ns | 1.828 ns |   281.02 ns |   284.67 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   736.90 ns | 100.278 ns | 5.497 ns |   733.67 ns |   743.24 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   120.81 ns |  44.062 ns | 2.415 ns |   119.06 ns |   123.56 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   449.14 ns |  41.092 ns | 2.252 ns |   446.73 ns |   451.19 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    89.69 ns |   6.490 ns | 0.356 ns |    89.28 ns |    89.93 ns | 0.0315 |     528 B |
