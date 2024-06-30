```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.96 ns** |  **80.652 ns** | **4.421 ns** |   **502.95 ns** |   **511.03 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.81 ns |   5.425 ns | 0.297 ns |   113.47 ns |   114.01 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   230.68 ns |  10.530 ns | 0.577 ns |   230.26 ns |   231.34 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.09 ns |   3.812 ns | 0.209 ns |    40.85 ns |    41.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   148.55 ns |  10.847 ns | 0.595 ns |   147.95 ns |   149.13 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.60 ns |   4.837 ns | 0.265 ns |    38.42 ns |    38.91 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,689.12 ns** | **106.372 ns** | **5.831 ns** | **1,684.01 ns** | **1,695.47 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   356.26 ns |  15.445 ns | 0.847 ns |   355.51 ns |   357.18 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   696.75 ns |  34.464 ns | 1.889 ns |   694.83 ns |   698.61 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.13 ns |  10.054 ns | 0.551 ns |   123.58 ns |   124.68 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   426.55 ns |  12.852 ns | 0.704 ns |   425.76 ns |   427.09 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.79 ns |  27.406 ns | 1.502 ns |   114.69 ns |   117.50 ns | 0.0062 |     528 B |
