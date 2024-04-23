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
| **GetNthSubnetIPv6**             | **1**      |   **507.97 ns** |  **17.820 ns** |  **0.977 ns** |   **506.91 ns** |   **508.83 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.22 ns |   5.555 ns |  0.304 ns |   115.98 ns |   116.56 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   230.58 ns |   5.736 ns |  0.314 ns |   230.31 ns |   230.93 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.14 ns |   4.592 ns |  0.252 ns |    41.97 ns |    42.43 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.35 ns |   5.334 ns |  0.292 ns |   143.06 ns |   143.65 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.98 ns |   2.204 ns |  0.121 ns |    39.90 ns |    40.12 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,608.89 ns** | **364.474 ns** | **19.978 ns** | **1,594.73 ns** | **1,631.74 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   354.43 ns |  24.396 ns |  1.337 ns |   352.90 ns |   355.38 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   720.33 ns |  24.920 ns |  1.366 ns |   719.37 ns |   721.89 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.62 ns |   4.794 ns |  0.263 ns |   126.33 ns |   126.84 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   438.85 ns |  16.261 ns |  0.891 ns |   437.83 ns |   439.38 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.34 ns |  14.345 ns |  0.786 ns |   116.44 ns |   117.85 ns | 0.0062 |     528 B |
