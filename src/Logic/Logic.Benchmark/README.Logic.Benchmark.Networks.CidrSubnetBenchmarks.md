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
| **GetNthSubnetIPv6**             | **1**      |   **549.58 ns** | **721.259 ns** | **39.535 ns** |   **526.46 ns** |   **595.23 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.55 ns |   5.611 ns |  0.308 ns |   115.36 ns |   115.90 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.78 ns |  20.792 ns |  1.140 ns |   235.08 ns |   237.10 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.83 ns |   3.477 ns |  0.191 ns |    41.66 ns |    42.03 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.44 ns |   3.123 ns |  0.171 ns |   139.27 ns |   139.61 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.26 ns |   2.751 ns |  0.151 ns |    39.10 ns |    39.40 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,650.07 ns** | **386.541 ns** | **21.188 ns** | **1,636.17 ns** | **1,674.46 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   354.49 ns | 136.516 ns |  7.483 ns |   346.51 ns |   361.36 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   708.15 ns |  29.162 ns |  1.598 ns |   706.56 ns |   709.75 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.07 ns |  32.421 ns |  1.777 ns |   126.79 ns |   130.10 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   425.92 ns |   3.691 ns |  0.202 ns |   425.69 ns |   426.07 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.46 ns |  15.347 ns |  0.841 ns |   117.63 ns |   119.31 ns | 0.0062 |     528 B |
