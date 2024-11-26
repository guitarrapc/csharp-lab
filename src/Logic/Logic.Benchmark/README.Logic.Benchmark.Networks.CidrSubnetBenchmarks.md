```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **497.94 ns** |  **8.900 ns** | **0.488 ns** |   **497.50 ns** |   **498.46 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.80 ns |  1.572 ns | 0.086 ns |   113.71 ns |   113.87 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   231.87 ns |  1.898 ns | 0.104 ns |   231.79 ns |   231.99 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.84 ns |  4.762 ns | 0.261 ns |    41.57 ns |    42.09 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   138.20 ns | 11.109 ns | 0.609 ns |   137.58 ns |   138.80 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.09 ns |  1.836 ns | 0.101 ns |    39.01 ns |    39.20 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,554.09 ns** | **45.441 ns** | **2.491 ns** | **1,551.44 ns** | **1,556.38 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.47 ns | 40.213 ns | 2.204 ns |   345.22 ns |   349.62 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   719.82 ns | 29.910 ns | 1.639 ns |   717.93 ns |   720.83 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   135.36 ns |  8.234 ns | 0.451 ns |   134.90 ns |   135.80 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   446.06 ns | 16.054 ns | 0.880 ns |   445.22 ns |   446.98 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.80 ns | 11.717 ns | 0.642 ns |   115.06 ns |   116.18 ns | 0.0062 |     528 B |
