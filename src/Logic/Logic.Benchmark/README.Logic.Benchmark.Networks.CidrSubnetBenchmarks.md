```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|--------------------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **CidrSubnetGetNthSubnetIPv6**             | **1**      |   **514.46 ns** |    **15.315 ns** |  **0.839 ns** |   **513.52 ns** |   **515.13 ns** | **0.0076** |     **696 B** |
| CidrSubnetGetNthSubnetIPv4             | 1      |   112.95 ns |     2.381 ns |  0.131 ns |   112.85 ns |   113.10 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv6BigInteger | 1      |   243.05 ns |    76.646 ns |  4.201 ns |   240.20 ns |   247.88 ns | 0.0048 |     432 B |
| CidrSubnetGetSubnetRangeIPv6Shift      | 1      |    41.80 ns |     4.349 ns |  0.238 ns |    41.53 ns |    41.99 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 1      |   142.33 ns |     3.155 ns |  0.173 ns |   142.13 ns |   142.46 ns | 0.0024 |     208 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 1      |    39.26 ns |     5.831 ns |  0.320 ns |    38.92 ns |    39.56 ns | 0.0021 |     176 B |
| **CidrSubnetGetNthSubnetIPv6**             | **10**     | **5,233.71 ns** | **1,573.168 ns** | **86.231 ns** | **5,183.72 ns** | **5,333.28 ns** | **0.0839** |    **7336 B** |
| CidrSubnetGetNthSubnetIPv4             | 10     | 1,151.50 ns |    46.241 ns |  2.535 ns | 1,149.54 ns | 1,154.36 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv6BigInteger | 10     | 2,355.20 ns |   179.689 ns |  9.849 ns | 2,343.88 ns | 2,361.82 ns | 0.0496 |    4320 B |
| CidrSubnetGetSubnetRangeIPv6Shift      | 10     |   494.23 ns |    84.574 ns |  4.636 ns |   490.50 ns |   499.42 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 10     | 1,431.45 ns |    64.068 ns |  3.512 ns | 1,428.03 ns | 1,435.04 ns | 0.0248 |    2080 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 10     |   386.18 ns |    12.677 ns |  0.695 ns |   385.63 ns |   386.96 ns | 0.0210 |    1760 B |
