```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **520.16 ns** |  **58.779 ns** | **3.222 ns** |   **518.23 ns** |   **523.88 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.30 ns |   2.163 ns | 0.119 ns |   114.20 ns |   114.43 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.54 ns |   4.754 ns | 0.261 ns |   235.30 ns |   235.81 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.04 ns |  10.556 ns | 0.579 ns |    41.39 ns |    42.49 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.53 ns |   2.003 ns | 0.110 ns |   143.42 ns |   143.64 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.65 ns |   8.411 ns | 0.461 ns |    39.28 ns |    40.17 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,613.75 ns** | **158.145 ns** | **8.668 ns** | **1,603.75 ns** | **1,618.88 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.05 ns |   7.884 ns | 0.432 ns |   345.55 ns |   346.30 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   757.94 ns |  63.239 ns | 3.466 ns |   755.25 ns |   761.85 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.06 ns |  51.283 ns | 2.811 ns |   122.30 ns |   127.92 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   452.26 ns |  29.924 ns | 1.640 ns |   450.41 ns |   453.54 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.21 ns |   9.517 ns | 0.522 ns |   117.82 ns |   118.80 ns | 0.0062 |     528 B |
