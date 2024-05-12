```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **525.40 ns** |   **7.967 ns** | **0.437 ns** |   **525.05 ns** |   **525.89 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.93 ns |  54.309 ns | 2.977 ns |   113.50 ns |   118.67 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.43 ns | 136.156 ns | 7.463 ns |   233.12 ns |   246.05 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    60.55 ns |   1.748 ns | 0.096 ns |    60.46 ns |    60.65 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.24 ns |  56.111 ns | 3.076 ns |   138.29 ns |   143.79 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.98 ns |   3.171 ns | 0.174 ns |    38.78 ns |    39.09 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,556.66 ns** | **101.779 ns** | **5.579 ns** | **1,553.15 ns** | **1,563.09 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.98 ns |   5.645 ns | 0.309 ns |   345.65 ns |   346.26 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   729.61 ns |  32.754 ns | 1.795 ns |   727.64 ns |   731.15 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.06 ns |   7.588 ns | 0.416 ns |   125.58 ns |   126.34 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   614.22 ns |  70.781 ns | 3.880 ns |   611.65 ns |   618.68 ns | 0.0067 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   133.01 ns |  16.439 ns | 0.901 ns |   132.40 ns |   134.05 ns | 0.0062 |     528 B |
