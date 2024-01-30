```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.04 ns** |  **20.690 ns** |  **1.134 ns** |   **504.03 ns** |   **506.27 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.13 ns |   6.262 ns |  0.343 ns |   111.74 ns |   112.38 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.99 ns |  52.165 ns |  2.859 ns |   236.25 ns |   241.29 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.43 ns |   4.093 ns |  0.224 ns |    41.26 ns |    41.68 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.55 ns |   3.460 ns |  0.190 ns |   141.41 ns |   141.77 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.88 ns |   2.236 ns |  0.123 ns |    38.78 ns |    39.02 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,291.17 ns** | **344.351 ns** | **18.875 ns** | **5,269.73 ns** | **5,305.26 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,169.69 ns |  53.148 ns |  2.913 ns | 1,166.57 ns | 1,172.33 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,380.73 ns | 765.775 ns | 41.975 ns | 2,354.71 ns | 2,429.15 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   428.86 ns | 112.544 ns |  6.169 ns |   421.95 ns |   433.81 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,477.30 ns | 347.468 ns | 19.046 ns | 1,463.65 ns | 1,499.06 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   395.71 ns | 136.595 ns |  7.487 ns |   391.21 ns |   404.35 ns | 0.0210 |    1760 B |
