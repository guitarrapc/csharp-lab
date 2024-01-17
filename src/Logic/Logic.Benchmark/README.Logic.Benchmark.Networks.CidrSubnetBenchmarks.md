```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|--------------------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **1**      |   **236.36 ns** |  **9.559 ns** | **0.524 ns** |   **235.79 ns** |   **236.83 ns** | **0.0048** |     **432 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 1      |    42.55 ns |  1.569 ns | 0.086 ns |    42.46 ns |    42.63 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 1      |   140.27 ns |  5.577 ns | 0.306 ns |   140.00 ns |   140.60 ns | 0.0024 |     208 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 1      |    39.94 ns |  2.904 ns | 0.159 ns |    39.76 ns |    40.07 ns | 0.0021 |     176 B |
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **10**     | **2,361.40 ns** | **44.514 ns** | **2.440 ns** | **2,359.80 ns** | **2,364.21 ns** | **0.0496** |    **4320 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 10     |   425.16 ns | 10.150 ns | 0.556 ns |   424.60 ns |   425.71 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 10     | 1,406.54 ns | 48.372 ns | 2.651 ns | 1,403.97 ns | 1,409.26 ns | 0.0248 |    2080 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 10     |   395.66 ns | 21.896 ns | 1.200 ns |   394.91 ns |   397.04 ns | 0.0210 |    1760 B |
