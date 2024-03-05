```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **510.03 ns** |  **24.131 ns** |  **1.323 ns** |   **508.74 ns** |   **511.38 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.63 ns |   4.506 ns |  0.247 ns |   112.38 ns |   112.87 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.87 ns |  10.002 ns |  0.548 ns |   232.24 ns |   233.21 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.91 ns |   1.602 ns |  0.088 ns |    41.85 ns |    42.01 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   154.77 ns |  46.588 ns |  2.554 ns |   152.19 ns |   157.30 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.72 ns |   2.991 ns |  0.164 ns |    39.56 ns |    39.89 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,367.94 ns** | **786.839 ns** | **43.129 ns** | **5,338.76 ns** | **5,417.48 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,156.27 ns |  56.801 ns |  3.113 ns | 1,154.20 ns | 1,159.85 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,344.63 ns | 213.468 ns | 11.701 ns | 2,332.01 ns | 2,355.11 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   453.46 ns | 109.126 ns |  5.982 ns |   446.90 ns |   458.61 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,413.91 ns | 117.725 ns |  6.453 ns | 1,409.79 ns | 1,421.34 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   408.14 ns | 452.666 ns | 24.812 ns |   393.72 ns |   436.79 ns | 0.0210 |    1760 B |
