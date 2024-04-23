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
| **GetNthSubnetIPv6**             | **1**      |   **514.66 ns** |  **33.543 ns** | **1.839 ns** |   **512.99 ns** |   **516.63 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.62 ns |   1.841 ns | 0.101 ns |   115.51 ns |   115.70 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.65 ns |  23.069 ns | 1.264 ns |   234.76 ns |   237.10 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.50 ns |   2.467 ns | 0.135 ns |    43.34 ns |    43.58 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.08 ns |   4.948 ns | 0.271 ns |   141.84 ns |   142.37 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.10 ns |   0.997 ns | 0.055 ns |    39.04 ns |    39.14 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,560.30 ns** |  **67.601 ns** | **3.705 ns** | **1,557.80 ns** | **1,564.56 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   351.15 ns | 121.951 ns | 6.685 ns |   344.23 ns |   357.57 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   729.36 ns |  47.267 ns | 2.591 ns |   726.49 ns |   731.52 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.48 ns |   6.075 ns | 0.333 ns |   125.11 ns |   125.74 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.15 ns |  27.030 ns | 1.482 ns |   424.18 ns |   426.85 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   119.43 ns |  34.424 ns | 1.887 ns |   117.91 ns |   121.54 ns | 0.0062 |     528 B |
