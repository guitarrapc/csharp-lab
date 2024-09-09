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
| **GetNthSubnetIPv6**             | **1**      |   **506.83 ns** |  **51.893 ns** | **2.844 ns** |   **504.41 ns** |   **509.96 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.67 ns |   1.287 ns | 0.071 ns |   113.60 ns |   113.74 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.45 ns |  14.715 ns | 0.807 ns |   236.78 ns |   238.34 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.69 ns |   2.437 ns | 0.134 ns |    41.57 ns |    41.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.50 ns |  24.276 ns | 1.331 ns |   138.54 ns |   141.02 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.91 ns |   4.962 ns | 0.272 ns |    38.75 ns |    39.23 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,536.70 ns** | **119.273 ns** | **6.538 ns** | **1,529.17 ns** | **1,541.00 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   338.82 ns |  10.037 ns | 0.550 ns |   338.26 ns |   339.36 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   732.66 ns |  41.495 ns | 2.275 ns |   730.39 ns |   734.94 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.07 ns |  16.052 ns | 0.880 ns |   123.08 ns |   124.77 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   423.68 ns |   9.632 ns | 0.528 ns |   423.31 ns |   424.29 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.32 ns |  16.104 ns | 0.883 ns |   115.49 ns |   117.25 ns | 0.0062 |     528 B |
