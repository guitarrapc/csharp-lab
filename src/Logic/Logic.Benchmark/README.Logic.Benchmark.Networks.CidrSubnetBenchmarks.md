```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **434.98 ns** |  **53.085 ns** |  **2.910 ns** |   **432.90 ns** |   **438.31 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    97.24 ns |  26.782 ns |  1.468 ns |    96.29 ns |    98.93 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.99 ns |   8.955 ns |  0.491 ns |   239.42 ns |   240.28 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.79 ns |   5.402 ns |  0.296 ns |    41.46 ns |    42.03 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   138.34 ns |  15.867 ns |  0.870 ns |   137.38 ns |   139.07 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    30.30 ns |   2.613 ns |  0.143 ns |    30.16 ns |    30.44 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,376.30 ns** | **235.065 ns** | **12.885 ns** | **1,368.78 ns** | **1,391.18 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   285.79 ns |  67.225 ns |  3.685 ns |   283.62 ns |   290.04 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   724.37 ns | 121.656 ns |  6.668 ns |   719.50 ns |   731.97 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   120.57 ns |  29.166 ns |  1.599 ns |   119.47 ns |   122.40 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   429.10 ns |  10.963 ns |  0.601 ns |   428.59 ns |   429.77 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    90.30 ns |  31.222 ns |  1.711 ns |    88.58 ns |    92.00 ns | 0.0315 |     528 B |
