```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **523.36 ns** |  **19.414 ns** |  **1.064 ns** |   **522.26 ns** |   **524.39 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.48 ns |   7.313 ns |  0.401 ns |   115.05 ns |   115.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   251.21 ns |  50.792 ns |  2.784 ns |   248.64 ns |   254.17 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.47 ns |   3.322 ns |  0.182 ns |    42.27 ns |    42.63 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   154.36 ns |   6.312 ns |  0.346 ns |   153.96 ns |   154.62 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.23 ns |   5.479 ns |  0.300 ns |    40.01 ns |    40.57 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,607.21 ns** | **372.964 ns** | **20.443 ns** | **1,589.58 ns** | **1,629.62 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   342.00 ns |   5.668 ns |  0.311 ns |   341.66 ns |   342.26 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   721.85 ns |   5.014 ns |  0.275 ns |   721.58 ns |   722.13 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.10 ns |  13.329 ns |  0.731 ns |   125.43 ns |   126.88 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   438.05 ns |  19.450 ns |  1.066 ns |   436.98 ns |   439.11 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.24 ns |   5.686 ns |  0.312 ns |   119.97 ns |   120.58 ns | 0.0062 |     528 B |
