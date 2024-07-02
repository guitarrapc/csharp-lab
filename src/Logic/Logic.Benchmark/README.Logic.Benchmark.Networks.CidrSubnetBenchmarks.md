```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **522.40 ns** | **16.695 ns** | **0.915 ns** |   **521.40 ns** |   **523.19 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.43 ns | 26.161 ns | 1.434 ns |   114.51 ns |   117.08 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.24 ns | 11.167 ns | 0.612 ns |   231.54 ns |   232.68 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.60 ns |  5.111 ns | 0.280 ns |    44.37 ns |    44.91 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.08 ns | 44.188 ns | 2.422 ns |   141.62 ns |   145.87 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.94 ns |  6.072 ns | 0.333 ns |    39.61 ns |    40.28 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,557.92 ns** | **72.264 ns** | **3.961 ns** | **1,554.61 ns** | **1,562.31 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   350.38 ns | 84.384 ns | 4.625 ns |   345.06 ns |   353.44 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   715.55 ns | 44.731 ns | 2.452 ns |   713.51 ns |   718.27 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.07 ns |  6.009 ns | 0.329 ns |   125.72 ns |   126.37 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   441.96 ns | 47.987 ns | 2.630 ns |   439.31 ns |   444.57 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.69 ns | 14.833 ns | 0.813 ns |   115.76 ns |   117.22 ns | 0.0062 |     528 B |
