```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **533.86 ns** |  **12.978 ns** | **0.711 ns** |   **533.15 ns** |   **534.57 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.79 ns |   3.223 ns | 0.177 ns |   113.66 ns |   113.99 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.42 ns |  14.580 ns | 0.799 ns |   238.62 ns |   240.22 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.32 ns |   5.240 ns | 0.287 ns |    41.98 ns |    42.49 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.82 ns |   6.433 ns | 0.353 ns |   143.44 ns |   144.14 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.89 ns |   2.578 ns | 0.141 ns |    39.81 ns |    40.05 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,055.79 ns** | **120.817 ns** | **6.622 ns** | **5,051.50 ns** | **5,063.42 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,151.87 ns |  24.674 ns | 1.352 ns | 1,151.00 ns | 1,153.43 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,362.15 ns |  48.231 ns | 2.644 ns | 2,359.21 ns | 2,364.32 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   422.95 ns |  46.623 ns | 2.556 ns |   420.12 ns |   425.09 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,408.56 ns |  23.666 ns | 1.297 ns | 1,407.07 ns | 1,409.34 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   401.14 ns |  79.765 ns | 4.372 ns |   396.23 ns |   404.63 ns | 0.0210 |    1760 B |
