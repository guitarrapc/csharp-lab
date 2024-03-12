```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **503.09 ns** |  **52.899 ns** | **2.900 ns** |   **500.56 ns** |   **506.25 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.20 ns |   7.703 ns | 0.422 ns |   115.72 ns |   116.52 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   246.63 ns | 167.025 ns | 9.155 ns |   241.17 ns |   257.20 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.81 ns |   5.147 ns | 0.282 ns |    41.54 ns |    42.10 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   152.64 ns |  24.314 ns | 1.333 ns |   151.13 ns |   153.63 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    62.01 ns |   2.892 ns | 0.159 ns |    61.88 ns |    62.19 ns | 0.0020 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,564.51 ns** |  **53.267 ns** | **2.920 ns** | **1,561.19 ns** | **1,566.66 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   350.47 ns |  63.376 ns | 3.474 ns |   347.87 ns |   354.41 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   721.23 ns |  29.410 ns | 1.612 ns |   719.37 ns |   722.20 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.10 ns |   5.379 ns | 0.295 ns |   126.80 ns |   127.39 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   423.92 ns |  19.750 ns | 1.083 ns |   422.71 ns |   424.79 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.87 ns |  46.999 ns | 2.576 ns |   116.38 ns |   120.84 ns | 0.0062 |     528 B |
