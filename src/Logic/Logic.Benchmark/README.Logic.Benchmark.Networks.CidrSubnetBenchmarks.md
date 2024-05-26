```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **506.59 ns** | **189.430 ns** | **10.383 ns** |   **499.89 ns** |   **518.55 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.06 ns |   5.860 ns |  0.321 ns |   116.72 ns |   117.36 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   248.56 ns | 109.058 ns |  5.978 ns |   244.81 ns |   255.45 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.79 ns |   6.513 ns |  0.357 ns |    42.42 ns |    43.13 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   152.25 ns |   2.720 ns |  0.149 ns |   152.12 ns |   152.41 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    50.81 ns |   8.151 ns |  0.447 ns |    50.30 ns |    51.13 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,606.38 ns** |  **93.257 ns** |  **5.112 ns** | **1,600.57 ns** | **1,610.21 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   351.10 ns | 123.685 ns |  6.780 ns |   344.51 ns |   358.05 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   736.85 ns |  13.145 ns |  0.721 ns |   736.42 ns |   737.68 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.46 ns |   7.260 ns |  0.398 ns |   125.06 ns |   125.85 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   442.51 ns |  62.240 ns |  3.412 ns |   439.27 ns |   446.07 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   170.37 ns |   9.400 ns |  0.515 ns |   169.92 ns |   170.93 ns | 0.0062 |     528 B |
