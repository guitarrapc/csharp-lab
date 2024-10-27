```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **542.76 ns** | **603.538 ns** | **33.082 ns** |   **521.67 ns** |   **580.89 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.42 ns |   3.901 ns |  0.214 ns |   115.18 ns |   115.57 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   243.47 ns |  13.767 ns |  0.755 ns |   242.63 ns |   244.07 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.66 ns |   2.039 ns |  0.112 ns |    42.55 ns |    42.77 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.39 ns |   7.842 ns |  0.430 ns |   142.06 ns |   142.88 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.82 ns |   2.580 ns |  0.141 ns |    39.66 ns |    39.93 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,595.14 ns** |  **92.526 ns** |  **5.072 ns** | **1,591.12 ns** | **1,600.83 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.39 ns |   3.932 ns |  0.216 ns |   345.16 ns |   345.57 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   721.58 ns | 303.317 ns | 16.626 ns |   710.44 ns |   740.69 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   129.09 ns |  10.136 ns |  0.556 ns |   128.45 ns |   129.44 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   446.45 ns |  11.334 ns |  0.621 ns |   445.78 ns |   447.01 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   121.14 ns |   4.326 ns |  0.237 ns |   120.91 ns |   121.38 ns | 0.0062 |     528 B |
