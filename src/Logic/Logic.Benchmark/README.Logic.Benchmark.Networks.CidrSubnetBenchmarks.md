```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **503.86 ns** |  **26.591 ns** |  **1.458 ns** |   **502.60 ns** |   **505.45 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   120.66 ns |  13.918 ns |  0.763 ns |   120.05 ns |   121.51 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.99 ns |  26.346 ns |  1.444 ns |   233.52 ns |   236.40 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.71 ns |   0.888 ns |  0.049 ns |    41.65 ns |    41.74 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   151.56 ns |   3.740 ns |  0.205 ns |   151.35 ns |   151.76 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.39 ns |   3.962 ns |  0.217 ns |    39.25 ns |    39.64 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,547.69 ns** | **376.177 ns** | **20.620 ns** | **1,530.21 ns** | **1,570.43 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   349.07 ns |  22.150 ns |  1.214 ns |   348.30 ns |   350.47 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   732.39 ns |  27.027 ns |  1.481 ns |   730.68 ns |   733.27 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.82 ns |   2.757 ns |  0.151 ns |   124.65 ns |   124.93 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   424.43 ns |   2.084 ns |  0.114 ns |   424.31 ns |   424.54 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   119.73 ns |  48.647 ns |  2.667 ns |   117.90 ns |   122.79 ns | 0.0062 |     528 B |
