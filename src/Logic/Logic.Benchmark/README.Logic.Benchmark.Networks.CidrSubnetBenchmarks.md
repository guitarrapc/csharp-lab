```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **506.53 ns** |  **85.154 ns** | **4.668 ns** |   **503.38 ns** |   **511.89 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.54 ns |  38.956 ns | 2.135 ns |   114.28 ns |   118.01 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   238.35 ns |   2.914 ns | 0.160 ns |   238.20 ns |   238.52 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.27 ns |   6.387 ns | 0.350 ns |    41.93 ns |    42.63 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.66 ns |  21.955 ns | 1.203 ns |   139.35 ns |   141.72 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.52 ns |   6.905 ns | 0.378 ns |    39.08 ns |    39.74 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,585.32 ns** | **102.871 ns** | **5.639 ns** | **1,581.84 ns** | **1,591.83 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.10 ns |  56.707 ns | 3.108 ns |   343.68 ns |   349.61 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   713.79 ns |  13.929 ns | 0.764 ns |   713.12 ns |   714.62 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   129.03 ns |  59.170 ns | 3.243 ns |   126.92 ns |   132.76 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   432.05 ns |  14.267 ns | 0.782 ns |   431.15 ns |   432.53 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   121.32 ns |   4.749 ns | 0.260 ns |   121.10 ns |   121.61 ns | 0.0062 |     528 B |
