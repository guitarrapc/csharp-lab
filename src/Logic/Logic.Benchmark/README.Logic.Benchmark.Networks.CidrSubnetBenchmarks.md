```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **518.94 ns** | **37.766 ns** | **2.070 ns** |   **517.30 ns** |   **521.26 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.94 ns |  1.157 ns | 0.063 ns |   116.87 ns |   117.00 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.41 ns |  7.612 ns | 0.417 ns |   238.93 ns |   239.66 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.02 ns |  3.929 ns | 0.215 ns |    41.78 ns |    42.20 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.53 ns |  7.221 ns | 0.396 ns |   140.17 ns |   140.95 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.24 ns |  2.868 ns | 0.157 ns |    39.08 ns |    39.39 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,571.49 ns** | **62.816 ns** | **3.443 ns** | **1,567.54 ns** | **1,573.85 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.07 ns | 29.462 ns | 1.615 ns |   345.61 ns |   348.80 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   731.92 ns | 21.243 ns | 1.164 ns |   730.93 ns |   733.20 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.69 ns | 16.427 ns | 0.900 ns |   123.93 ns |   125.69 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   422.15 ns | 30.858 ns | 1.691 ns |   420.23 ns |   423.40 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.19 ns |  5.256 ns | 0.288 ns |   115.86 ns |   116.41 ns | 0.0062 |     528 B |
