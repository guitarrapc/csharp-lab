```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **500.35 ns** |  **43.305 ns** |  **2.374 ns** |   **498.50 ns** |   **503.03 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.89 ns |   6.727 ns |  0.369 ns |   116.52 ns |   117.26 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.08 ns |  18.668 ns |  1.023 ns |   238.23 ns |   240.22 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.66 ns |   7.501 ns |  0.411 ns |    44.27 ns |    45.09 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.30 ns |  12.482 ns |  0.684 ns |   141.57 ns |   142.93 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.07 ns |   3.601 ns |  0.197 ns |    39.91 ns |    40.29 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,646.06 ns** | **275.877 ns** | **15.122 ns** | **1,636.13 ns** | **1,663.46 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.03 ns |  93.209 ns |  5.109 ns |   342.61 ns |   351.90 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   725.34 ns |  58.630 ns |  3.214 ns |   722.03 ns |   728.45 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.70 ns |   5.725 ns |  0.314 ns |   124.43 ns |   125.04 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   429.97 ns |   5.274 ns |  0.289 ns |   429.71 ns |   430.28 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.34 ns |  19.607 ns |  1.075 ns |   116.64 ns |   118.57 ns | 0.0062 |     528 B |
