```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **502.92 ns** |  **40.880 ns** |  **2.241 ns** |   **500.62 ns** |   **505.10 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.29 ns |   2.999 ns |  0.164 ns |   114.14 ns |   114.46 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.21 ns |  16.593 ns |  0.910 ns |   232.17 ns |   233.86 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.12 ns |   9.937 ns |  0.545 ns |    41.70 ns |    42.74 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.93 ns |  24.888 ns |  1.364 ns |   144.39 ns |   146.98 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.16 ns |   8.731 ns |  0.479 ns |    38.88 ns |    39.71 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,191.23 ns** | **223.445 ns** | **12.248 ns** | **5,179.06 ns** | **5,203.55 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,169.17 ns | 116.319 ns |  6.376 ns | 1,162.74 ns | 1,175.49 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,455.42 ns | 160.053 ns |  8.773 ns | 2,447.93 ns | 2,465.07 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   429.26 ns | 105.620 ns |  5.789 ns |   425.89 ns |   435.95 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,495.19 ns | 140.496 ns |  7.701 ns | 1,490.58 ns | 1,504.08 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   393.61 ns |  38.110 ns |  2.089 ns |   392.15 ns |   396.01 ns | 0.0210 |    1760 B |
