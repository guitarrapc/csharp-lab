```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **523.37 ns** | **385.382 ns** | **21.124 ns** |   **510.02 ns** |   **547.72 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.55 ns |   7.878 ns |  0.432 ns |   114.06 ns |   114.85 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.87 ns |  10.400 ns |  0.570 ns |   232.27 ns |   233.40 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.58 ns |  14.887 ns |  0.816 ns |    40.99 ns |    42.51 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.57 ns |  18.725 ns |  1.026 ns |   139.96 ns |   141.76 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.18 ns |   8.814 ns |  0.483 ns |    38.86 ns |    39.74 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,539.86 ns** |  **43.117 ns** |  **2.363 ns** | **1,537.27 ns** | **1,541.90 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   449.22 ns |  32.056 ns |  1.757 ns |   447.21 ns |   450.47 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   705.69 ns |  31.243 ns |  1.713 ns |   704.52 ns |   707.65 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.07 ns |  44.821 ns |  2.457 ns |   123.58 ns |   128.49 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   445.43 ns | 198.938 ns | 10.904 ns |   434.50 ns |   456.31 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   114.76 ns |   4.136 ns |  0.227 ns |   114.51 ns |   114.94 ns | 0.0062 |     528 B |
