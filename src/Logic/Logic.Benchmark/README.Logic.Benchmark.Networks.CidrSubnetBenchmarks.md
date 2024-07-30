```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **518.30 ns** |  **23.296 ns** | **1.277 ns** |   **517.54 ns** |   **519.77 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.41 ns |   3.308 ns | 0.181 ns |   117.23 ns |   117.59 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.28 ns |   7.060 ns | 0.387 ns |   236.89 ns |   237.66 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.25 ns |   3.071 ns | 0.168 ns |    42.06 ns |    42.37 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.96 ns |  36.560 ns | 2.004 ns |   142.72 ns |   146.28 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.41 ns |   6.693 ns | 0.367 ns |    40.00 ns |    40.70 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,597.30 ns** | **124.462 ns** | **6.822 ns** | **1,590.64 ns** | **1,604.28 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.34 ns |  49.758 ns | 2.727 ns |   345.03 ns |   350.35 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   720.04 ns |  35.473 ns | 1.944 ns |   718.00 ns |   721.87 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.12 ns |  19.575 ns | 1.073 ns |   127.04 ns |   129.18 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   427.92 ns |  30.072 ns | 1.648 ns |   426.41 ns |   429.68 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.64 ns |  35.994 ns | 1.973 ns |   121.46 ns |   124.92 ns | 0.0062 |     528 B |
