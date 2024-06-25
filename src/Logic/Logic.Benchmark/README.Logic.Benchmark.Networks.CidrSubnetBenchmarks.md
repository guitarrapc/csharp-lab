```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **507.54 ns** |   **9.472 ns** |  **0.519 ns** |   **507.03 ns** |   **508.07 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.12 ns |   4.318 ns |  0.237 ns |   113.91 ns |   114.37 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.57 ns |  87.816 ns |  4.814 ns |   233.95 ns |   243.04 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.54 ns |   3.587 ns |  0.197 ns |    41.35 ns |    41.74 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.53 ns |   6.018 ns |  0.330 ns |   144.31 ns |   144.91 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.18 ns |   3.531 ns |  0.194 ns |    38.97 ns |    39.35 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,555.40 ns** | **287.008 ns** | **15.732 ns** | **1,544.32 ns** | **1,573.41 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   350.75 ns | 108.230 ns |  5.932 ns |   347.06 ns |   357.59 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   741.57 ns |  25.603 ns |  1.403 ns |   740.70 ns |   743.19 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   131.05 ns |  12.601 ns |  0.691 ns |   130.52 ns |   131.83 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   443.60 ns | 105.094 ns |  5.761 ns |   437.09 ns |   448.03 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.24 ns |  18.741 ns |  1.027 ns |   116.36 ns |   118.37 ns | 0.0062 |     528 B |
