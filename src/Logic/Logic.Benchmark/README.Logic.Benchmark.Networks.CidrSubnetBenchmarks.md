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
| **GetNthSubnetIPv6**             | **1**      |   **502.08 ns** | **126.085 ns** | **6.911 ns** |   **498.00 ns** |   **510.06 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.85 ns |   4.997 ns | 0.274 ns |   113.53 ns |   114.02 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.18 ns |  12.924 ns | 0.708 ns |   233.52 ns |   234.93 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.99 ns |   6.725 ns | 0.369 ns |    41.74 ns |    42.41 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.60 ns |   2.375 ns | 0.130 ns |   139.48 ns |   139.74 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.89 ns |   5.862 ns | 0.321 ns |    38.64 ns |    39.25 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,521.52 ns** |  **10.314 ns** | **0.565 ns** | **1,520.87 ns** | **1,521.91 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   352.49 ns |  78.680 ns | 4.313 ns |   347.78 ns |   356.25 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   706.20 ns |  26.564 ns | 1.456 ns |   704.72 ns |   707.63 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.08 ns |  25.572 ns | 1.402 ns |   124.11 ns |   126.69 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   414.95 ns |   7.019 ns | 0.385 ns |   414.51 ns |   415.25 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.82 ns |  14.140 ns | 0.775 ns |   118.27 ns |   119.71 ns | 0.0062 |     528 B |
