```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|--------------------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **1**      |   **238.19 ns** |  **33.709 ns** | **1.848 ns** |   **236.98 ns** |   **240.31 ns** | **0.0050** |     **432 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 1      |    41.87 ns |   4.264 ns | 0.234 ns |    41.60 ns |    42.04 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 1      |   148.85 ns |  84.495 ns | 4.631 ns |   144.73 ns |   153.86 ns | 0.0024 |     208 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 1      |    40.13 ns |  33.777 ns | 1.851 ns |    38.93 ns |    42.27 ns | 0.0021 |     176 B |
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **10**     | **2,348.51 ns** | **114.847 ns** | **6.295 ns** | **2,343.52 ns** | **2,355.58 ns** | **0.0496** |    **4320 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 10     |   428.03 ns |  53.019 ns | 2.906 ns |   426.01 ns |   431.36 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 10     | 1,482.47 ns | 123.651 ns | 6.778 ns | 1,475.60 ns | 1,489.15 ns | 0.0248 |    2080 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 10     |   386.63 ns |  54.238 ns | 2.973 ns |   383.81 ns |   389.74 ns | 0.0210 |    1760 B |
