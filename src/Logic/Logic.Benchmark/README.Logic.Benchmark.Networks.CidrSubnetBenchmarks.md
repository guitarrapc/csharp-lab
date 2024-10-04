```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **493.54 ns** |  **19.955 ns** |  **1.094 ns** |   **492.74 ns** |   **494.79 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.48 ns |   5.425 ns |  0.297 ns |   112.26 ns |   112.82 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.51 ns |   6.315 ns |  0.346 ns |   233.23 ns |   233.90 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.72 ns |   5.765 ns |  0.316 ns |    41.42 ns |    42.05 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.75 ns |  10.449 ns |  0.573 ns |   142.38 ns |   143.41 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.71 ns |   5.114 ns |  0.280 ns |    38.43 ns |    38.99 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,591.64 ns** | **139.114 ns** |  **7.625 ns** | **1,582.87 ns** | **1,596.77 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.31 ns |  25.080 ns |  1.375 ns |   346.96 ns |   349.71 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   726.90 ns |   6.875 ns |  0.377 ns |   726.59 ns |   727.32 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.61 ns |  22.760 ns |  1.248 ns |   123.36 ns |   125.85 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   457.75 ns | 296.288 ns | 16.241 ns |   447.22 ns |   476.45 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.41 ns |  18.638 ns |  1.022 ns |   116.68 ns |   118.58 ns | 0.0062 |     528 B |
