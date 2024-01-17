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
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **1**      |   **245.18 ns** | **18.619 ns** | **1.021 ns** |   **244.13 ns** |   **246.16 ns** | **0.0048** |     **432 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 1      |    41.41 ns |  1.114 ns | 0.061 ns |    41.37 ns |    41.48 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 1      |   157.55 ns |  1.589 ns | 0.087 ns |   157.45 ns |   157.62 ns | 0.0024 |     208 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 1      |    39.61 ns |  5.477 ns | 0.300 ns |    39.27 ns |    39.83 ns | 0.0021 |     176 B |
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **10**     | **2,430.13 ns** | **72.859 ns** | **3.994 ns** | **2,425.60 ns** | **2,433.13 ns** | **0.0496** |    **4320 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 10     |   421.50 ns | 23.465 ns | 1.286 ns |   420.39 ns |   422.91 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 10     | 1,546.85 ns | 32.080 ns | 1.758 ns | 1,544.87 ns | 1,548.22 ns | 0.0248 |    2080 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 10     |   396.15 ns | 28.571 ns | 1.566 ns |   394.41 ns |   397.45 ns | 0.0210 |    1760 B |
