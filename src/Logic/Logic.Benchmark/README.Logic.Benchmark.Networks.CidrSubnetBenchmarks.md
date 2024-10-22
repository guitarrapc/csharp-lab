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
| **GetNthSubnetIPv6**             | **1**      |   **507.30 ns** |  **5.988 ns** | **0.328 ns** |   **507.09 ns** |   **507.68 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.57 ns |  5.765 ns | 0.316 ns |   113.21 ns |   113.77 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.95 ns | 14.022 ns | 0.769 ns |   233.08 ns |   234.53 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.57 ns |  7.076 ns | 0.388 ns |    41.22 ns |    41.98 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.48 ns |  6.894 ns | 0.378 ns |   141.09 ns |   141.84 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.16 ns |  5.492 ns | 0.301 ns |    38.97 ns |    39.51 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,608.91 ns** | **77.802 ns** | **4.265 ns** | **1,604.08 ns** | **1,612.18 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.77 ns | 33.070 ns | 1.813 ns |   345.70 ns |   348.87 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   720.61 ns | 44.674 ns | 2.449 ns |   718.50 ns |   723.30 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.15 ns | 28.611 ns | 1.568 ns |   125.68 ns |   128.80 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   447.59 ns | 13.638 ns | 0.748 ns |   446.73 ns |   448.04 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.71 ns | 28.378 ns | 1.555 ns |   115.42 ns |   118.44 ns | 0.0062 |     528 B |
