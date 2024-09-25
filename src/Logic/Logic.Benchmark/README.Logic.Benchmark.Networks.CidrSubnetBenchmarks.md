```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **501.42 ns** | **26.635 ns** | **1.460 ns** |   **499.82 ns** |   **502.68 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.15 ns |  3.947 ns | 0.216 ns |   112.91 ns |   113.34 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.85 ns |  4.029 ns | 0.221 ns |   232.68 ns |   233.10 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.33 ns | 17.948 ns | 0.984 ns |    42.70 ns |    44.47 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.38 ns | 10.472 ns | 0.574 ns |   144.94 ns |   146.03 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.60 ns |  1.555 ns | 0.085 ns |    39.55 ns |    39.70 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,593.23 ns** | **60.064 ns** | **3.292 ns** | **1,590.33 ns** | **1,596.81 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.24 ns | 22.026 ns | 1.207 ns |   343.97 ns |   346.38 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   716.85 ns | 25.424 ns | 1.394 ns |   715.50 ns |   718.28 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.45 ns | 15.334 ns | 0.840 ns |   126.64 ns |   128.32 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   431.27 ns | 20.510 ns | 1.124 ns |   429.98 ns |   432.07 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.00 ns | 13.234 ns | 0.725 ns |   116.42 ns |   117.81 ns | 0.0062 |     528 B |
