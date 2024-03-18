```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.53 ns** | **30.872 ns** | **1.692 ns** |   **504.27 ns** |   **507.45 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.10 ns |  3.127 ns | 0.171 ns |   114.90 ns |   115.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.71 ns | 10.302 ns | 0.565 ns |   239.10 ns |   240.21 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.52 ns |  1.875 ns | 0.103 ns |    42.44 ns |    42.64 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.99 ns |  5.787 ns | 0.317 ns |   142.64 ns |   143.25 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.95 ns |  1.211 ns | 0.066 ns |    40.89 ns |    41.02 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,646.97 ns** | **84.150 ns** | **4.613 ns** | **1,641.68 ns** | **1,650.14 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.09 ns | 79.157 ns | 4.339 ns |   343.12 ns |   351.12 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   750.18 ns | 40.716 ns | 2.232 ns |   747.77 ns |   752.18 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.80 ns |  7.967 ns | 0.437 ns |   126.30 ns |   127.13 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   440.48 ns | 33.350 ns | 1.828 ns |   438.75 ns |   442.39 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.22 ns | 48.168 ns | 2.640 ns |   118.57 ns |   123.27 ns | 0.0062 |     528 B |
