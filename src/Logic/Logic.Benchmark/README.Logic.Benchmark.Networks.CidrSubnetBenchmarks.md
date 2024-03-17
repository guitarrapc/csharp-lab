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
| **GetNthSubnetIPv6**             | **1**      |   **472.28 ns** | **175.745 ns** | **9.633 ns** |   **465.93 ns** |   **483.37 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   106.65 ns |  16.226 ns | 0.889 ns |   106.07 ns |   107.67 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   217.80 ns |  46.959 ns | 2.574 ns |   215.81 ns |   220.70 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    39.22 ns |   4.384 ns | 0.240 ns |    38.96 ns |    39.44 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   135.90 ns |  13.120 ns | 0.719 ns |   135.07 ns |   136.32 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    36.84 ns |   9.037 ns | 0.495 ns |    36.42 ns |    37.39 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,509.08 ns** |  **35.734 ns** | **1.959 ns** | **1,507.83 ns** | **1,511.34 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   330.39 ns |  27.221 ns | 1.492 ns |   329.20 ns |   332.06 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   682.03 ns | 177.986 ns | 9.756 ns |   673.41 ns |   692.62 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   116.38 ns |  23.072 ns | 1.265 ns |   115.45 ns |   117.82 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   414.31 ns | 110.702 ns | 6.068 ns |   408.09 ns |   420.21 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   110.51 ns |  13.041 ns | 0.715 ns |   109.78 ns |   111.21 ns | 0.0062 |     528 B |
