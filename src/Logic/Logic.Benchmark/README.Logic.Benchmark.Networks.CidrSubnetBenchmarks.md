```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **522.87 ns** |  **15.256 ns** |  **0.836 ns** |   **522.39 ns** |   **523.84 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.59 ns |   3.594 ns |  0.197 ns |   112.39 ns |   112.78 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   241.08 ns |   9.935 ns |  0.545 ns |   240.54 ns |   241.63 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.66 ns |   2.253 ns |  0.123 ns |    41.53 ns |    41.77 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   156.95 ns | 256.576 ns | 14.064 ns |   145.18 ns |   172.52 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.18 ns |   4.403 ns |  0.241 ns |    39.91 ns |    40.33 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,548.18 ns** | **169.021 ns** |  **9.265 ns** | **1,541.92 ns** | **1,558.82 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.63 ns |  67.493 ns |  3.700 ns |   343.32 ns |   349.90 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   717.15 ns |  11.478 ns |  0.629 ns |   716.47 ns |   717.71 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.74 ns |  12.437 ns |  0.682 ns |   123.15 ns |   124.48 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   424.91 ns |   6.322 ns |  0.347 ns |   424.51 ns |   425.15 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.55 ns |   9.089 ns |  0.498 ns |   117.19 ns |   118.12 ns | 0.0062 |     528 B |
