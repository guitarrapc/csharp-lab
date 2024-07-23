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
| **GetNthSubnetIPv6**             | **1**      |   **523.16 ns** |  **13.678 ns** | **0.750 ns** |   **522.73 ns** |   **524.03 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.56 ns |   7.199 ns | 0.395 ns |   113.15 ns |   113.93 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.87 ns |  16.445 ns | 0.901 ns |   231.91 ns |   233.70 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.42 ns |   4.178 ns | 0.229 ns |    42.20 ns |    42.66 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.19 ns |   8.029 ns | 0.440 ns |   143.71 ns |   144.57 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.64 ns |   4.794 ns | 0.263 ns |    39.42 ns |    39.93 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,611.17 ns** | **109.684 ns** | **6.012 ns** | **1,604.30 ns** | **1,615.49 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   351.89 ns |  89.285 ns | 4.894 ns |   348.57 ns |   357.51 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   718.33 ns |  34.464 ns | 1.889 ns |   716.87 ns |   720.47 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.01 ns |  15.416 ns | 0.845 ns |   124.28 ns |   125.94 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   435.63 ns |  84.024 ns | 4.606 ns |   431.66 ns |   440.68 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   315.22 ns |   3.958 ns | 0.217 ns |   315.07 ns |   315.47 ns | 0.0062 |     528 B |
