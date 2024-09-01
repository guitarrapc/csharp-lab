```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **504.76 ns** |  **36.259 ns** |  **1.987 ns** |   **502.70 ns** |   **506.67 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.94 ns |   2.977 ns |  0.163 ns |   114.75 ns |   115.04 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.91 ns |   9.405 ns |  0.516 ns |   232.40 ns |   233.43 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.72 ns |   8.587 ns |  0.471 ns |    41.27 ns |    42.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.41 ns |   4.137 ns |  0.227 ns |   146.17 ns |   146.62 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    41.17 ns |   1.353 ns |  0.074 ns |    41.11 ns |    41.25 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,748.19 ns** |  **87.124 ns** |  **4.776 ns** | **1,745.15 ns** | **1,753.70 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.91 ns |  29.444 ns |  1.614 ns |   347.22 ns |   350.44 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   746.75 ns | 321.043 ns | 17.597 ns |   734.15 ns |   766.85 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.06 ns |  34.589 ns |  1.896 ns |   125.91 ns |   129.25 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   439.05 ns | 132.470 ns |  7.261 ns |   434.84 ns |   447.43 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   121.46 ns |  42.869 ns |  2.350 ns |   118.85 ns |   123.42 ns | 0.0062 |     528 B |
