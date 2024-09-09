```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **507.91 ns** | **18.979 ns** | **1.040 ns** |   **506.77 ns** |   **508.81 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.39 ns |  2.690 ns | 0.147 ns |   115.22 ns |   115.48 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.48 ns |  6.685 ns | 0.366 ns |   235.07 ns |   235.79 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.29 ns |  0.646 ns | 0.035 ns |    41.26 ns |    41.33 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.59 ns |  5.095 ns | 0.279 ns |   146.41 ns |   146.91 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.93 ns |  1.773 ns | 0.097 ns |    38.82 ns |    39.01 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,576.45 ns** | **50.120 ns** | **2.747 ns** | **1,574.53 ns** | **1,579.60 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   340.42 ns |  5.199 ns | 0.285 ns |   340.19 ns |   340.74 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   746.98 ns | 26.919 ns | 1.475 ns |   745.30 ns |   748.07 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.86 ns | 69.555 ns | 3.813 ns |   122.22 ns |   129.83 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   420.55 ns | 55.826 ns | 3.060 ns |   418.66 ns |   424.08 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.29 ns | 56.966 ns | 3.123 ns |   114.86 ns |   120.81 ns | 0.0062 |     528 B |
