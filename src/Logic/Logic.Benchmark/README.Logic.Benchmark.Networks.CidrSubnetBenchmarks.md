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
| **GetNthSubnetIPv6**             | **1**      |   **509.36 ns** | **83.776 ns** | **4.592 ns** |   **505.87 ns** |   **514.56 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.07 ns |  1.891 ns | 0.104 ns |   113.98 ns |   114.18 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.96 ns |  6.192 ns | 0.339 ns |   232.60 ns |   233.27 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.74 ns |  5.965 ns | 0.327 ns |    41.51 ns |    42.11 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.84 ns |  2.517 ns | 0.138 ns |   140.68 ns |   140.92 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.00 ns |  4.496 ns | 0.246 ns |    38.73 ns |    39.21 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,526.76 ns** | **13.007 ns** | **0.713 ns** | **1,526.17 ns** | **1,527.55 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   365.33 ns |  2.454 ns | 0.135 ns |   365.18 ns |   365.45 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   704.59 ns | 27.703 ns | 1.519 ns |   703.69 ns |   706.34 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.09 ns | 15.604 ns | 0.855 ns |   124.54 ns |   126.08 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   447.63 ns | 61.179 ns | 3.353 ns |   445.36 ns |   451.48 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.28 ns |  2.279 ns | 0.125 ns |   117.14 ns |   117.37 ns | 0.0062 |     528 B |
