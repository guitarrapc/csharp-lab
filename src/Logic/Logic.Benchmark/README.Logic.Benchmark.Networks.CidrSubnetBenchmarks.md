```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **503.64 ns** |    **47.632 ns** |  **2.611 ns** |   **500.78 ns** |   **505.89 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.22 ns |     1.617 ns |  0.089 ns |   114.13 ns |   114.30 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   247.21 ns |    13.496 ns |  0.740 ns |   246.43 ns |   247.90 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.77 ns |     5.348 ns |  0.293 ns |    44.43 ns |    44.96 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.30 ns |     8.797 ns |  0.482 ns |   141.99 ns |   142.85 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.40 ns |     7.808 ns |  0.428 ns |    40.02 ns |    40.86 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,316.02 ns** | **1,535.703 ns** | **84.177 ns** | **5,265.27 ns** | **5,413.19 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,203.04 ns |    18.740 ns |  1.027 ns | 1,201.86 ns | 1,203.70 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,394.17 ns |   659.151 ns | 36.130 ns | 2,368.82 ns | 2,435.54 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   453.14 ns |   272.037 ns | 14.911 ns |   437.70 ns |   467.46 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,602.29 ns |   285.778 ns | 15.664 ns | 1,590.82 ns | 1,620.14 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   402.64 ns |   139.888 ns |  7.668 ns |   396.80 ns |   411.32 ns | 0.0210 |    1760 B |
