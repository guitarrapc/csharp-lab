```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.42 ns** |  **24.214 ns** | **1.327 ns** |   **504.14 ns** |   **506.79 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.45 ns |   6.730 ns | 0.369 ns |   116.19 ns |   116.87 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.57 ns |   7.298 ns | 0.400 ns |   236.25 ns |   237.02 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.37 ns |   3.614 ns | 0.198 ns |    42.22 ns |    42.59 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.33 ns |  21.880 ns | 1.199 ns |   140.19 ns |   142.58 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.93 ns |   3.921 ns | 0.215 ns |    39.68 ns |    40.09 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,592.49 ns** | **105.538 ns** | **5.785 ns** | **1,588.02 ns** | **1,599.03 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   350.59 ns |  15.781 ns | 0.865 ns |   349.92 ns |   351.56 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   726.58 ns |  25.623 ns | 1.404 ns |   725.16 ns |   727.97 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   138.34 ns | 114.194 ns | 6.259 ns |   134.40 ns |   145.56 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   426.03 ns |  56.509 ns | 3.097 ns |   423.83 ns |   429.57 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.15 ns |  17.707 ns | 0.971 ns |   117.06 ns |   118.91 ns | 0.0062 |     528 B |
