```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **450.92 ns** | **25.756 ns** | **1.412 ns** |   **449.34 ns** |   **452.05 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    94.04 ns |  6.549 ns | 0.359 ns |    93.63 ns |    94.30 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   230.85 ns |  4.690 ns | 0.257 ns |   230.64 ns |   231.14 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    39.82 ns |  4.188 ns | 0.230 ns |    39.62 ns |    40.07 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.66 ns | 22.177 ns | 1.216 ns |   138.32 ns |   140.69 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    29.52 ns |  3.080 ns | 0.169 ns |    29.33 ns |    29.66 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,384.88 ns** | **29.231 ns** | **1.602 ns** | **1,383.40 ns** | **1,386.58 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   283.83 ns | 35.372 ns | 1.939 ns |   282.52 ns |   286.06 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   702.30 ns | 62.957 ns | 3.451 ns |   698.39 ns |   704.92 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   117.15 ns |  5.814 ns | 0.319 ns |   116.94 ns |   117.51 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   452.78 ns | 91.771 ns | 5.030 ns |   449.85 ns |   458.59 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    91.58 ns | 21.359 ns | 1.171 ns |    90.23 ns |    92.29 ns | 0.0315 |     528 B |
