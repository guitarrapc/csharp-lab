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
| **GetNthSubnetIPv6**             | **1**      |   **511.66 ns** |   **8.843 ns** | **0.485 ns** |   **511.30 ns** |   **512.21 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.28 ns |   3.521 ns | 0.193 ns |   115.09 ns |   115.48 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   241.15 ns |  99.901 ns | 5.476 ns |   237.84 ns |   247.47 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    48.72 ns |   1.627 ns | 0.089 ns |    48.62 ns |    48.78 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.51 ns |   5.243 ns | 0.287 ns |   144.31 ns |   144.84 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    45.45 ns |   0.115 ns | 0.006 ns |    45.45 ns |    45.46 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,564.58 ns** | **153.381 ns** | **8.407 ns** | **1,557.15 ns** | **1,573.71 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.69 ns |  69.285 ns | 3.798 ns |   346.38 ns |   353.07 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   718.18 ns |  19.769 ns | 1.084 ns |   717.04 ns |   719.19 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   129.20 ns |   5.112 ns | 0.280 ns |   128.92 ns |   129.48 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   433.67 ns |   3.278 ns | 0.180 ns |   433.49 ns |   433.85 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.12 ns |  11.640 ns | 0.638 ns |   117.42 ns |   118.66 ns | 0.0062 |     528 B |
