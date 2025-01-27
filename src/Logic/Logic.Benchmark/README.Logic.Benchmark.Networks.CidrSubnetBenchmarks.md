```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **468.25 ns** | **110.385 ns** |  **6.051 ns** |   **461.27 ns** |   **471.76 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    97.91 ns |  31.034 ns |  1.701 ns |    96.48 ns |    99.79 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.98 ns |  21.235 ns |  1.164 ns |   239.86 ns |   242.18 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.42 ns |  12.406 ns |  0.680 ns |    41.92 ns |    43.20 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   150.02 ns |   2.567 ns |  0.141 ns |   149.91 ns |   150.18 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    33.23 ns |  11.658 ns |  0.639 ns |    32.81 ns |    33.96 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,439.87 ns** | **226.849 ns** | **12.434 ns** | **1,429.60 ns** | **1,453.69 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   298.59 ns |  48.907 ns |  2.681 ns |   295.97 ns |   301.33 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   771.58 ns | 155.509 ns |  8.524 ns |   766.46 ns |   781.42 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.54 ns |  76.629 ns |  4.200 ns |   121.73 ns |   129.47 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   458.13 ns |  79.473 ns |  4.356 ns |   453.13 ns |   461.06 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   100.16 ns |  63.892 ns |  3.502 ns |    96.89 ns |   103.85 ns | 0.0315 |     528 B |
