```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **494.70 ns** | **15.396 ns** | **0.844 ns** |   **494.15 ns** |   **495.67 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.05 ns |  4.600 ns | 0.252 ns |   113.85 ns |   114.33 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.13 ns |  4.955 ns | 0.272 ns |   233.89 ns |   234.42 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.14 ns |  3.391 ns | 0.186 ns |    41.93 ns |    42.27 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   152.13 ns | 53.913 ns | 2.955 ns |   149.99 ns |   155.50 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.36 ns |  1.211 ns | 0.066 ns |    39.28 ns |    39.41 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,615.20 ns** | **61.863 ns** | **3.391 ns** | **1,611.73 ns** | **1,618.51 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   340.25 ns |  5.335 ns | 0.292 ns |   339.92 ns |   340.46 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   733.10 ns | 38.899 ns | 2.132 ns |   731.43 ns |   735.50 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   130.63 ns | 10.725 ns | 0.588 ns |   130.00 ns |   131.17 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   424.61 ns |  6.692 ns | 0.367 ns |   424.33 ns |   425.02 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.46 ns |  8.729 ns | 0.478 ns |   117.91 ns |   118.80 ns | 0.0062 |     528 B |
