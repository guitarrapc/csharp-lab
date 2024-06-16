```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **513.91 ns** |  **4.184 ns** | **0.229 ns** |   **513.65 ns** |   **514.10 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.03 ns |  1.820 ns | 0.100 ns |   114.92 ns |   115.11 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.32 ns | 27.265 ns | 1.494 ns |   233.71 ns |   236.65 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.86 ns |  1.518 ns | 0.083 ns |    41.77 ns |    41.94 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.49 ns |  2.275 ns | 0.125 ns |   142.35 ns |   142.57 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.38 ns |  3.037 ns | 0.166 ns |    39.27 ns |    39.57 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,551.14 ns** | **56.793 ns** | **3.113 ns** | **1,547.74 ns** | **1,553.85 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   342.97 ns | 69.200 ns | 3.793 ns |   340.39 ns |   347.32 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   719.16 ns | 15.865 ns | 0.870 ns |   718.46 ns |   720.13 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.45 ns | 32.278 ns | 1.769 ns |   124.28 ns |   127.49 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.15 ns |  6.125 ns | 0.336 ns |   424.81 ns |   425.48 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.99 ns | 14.390 ns | 0.789 ns |   118.44 ns |   119.89 ns | 0.0062 |     528 B |
