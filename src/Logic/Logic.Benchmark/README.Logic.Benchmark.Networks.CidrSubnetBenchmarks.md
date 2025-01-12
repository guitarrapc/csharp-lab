```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **400.69 ns** | **85.065 ns** | **4.663 ns** |   **396.21 ns** |   **405.52 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    87.12 ns |  6.534 ns | 0.358 ns |    86.77 ns |    87.48 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   228.51 ns | 52.731 ns | 2.890 ns |   226.76 ns |   231.85 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    37.81 ns |  1.833 ns | 0.100 ns |    37.74 ns |    37.92 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   128.91 ns |  3.310 ns | 0.181 ns |   128.70 ns |   129.02 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    27.58 ns |  0.570 ns | 0.031 ns |    27.55 ns |    27.61 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,247.93 ns** | **38.693 ns** | **2.121 ns** | **1,246.06 ns** | **1,250.23 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   266.13 ns | 35.395 ns | 1.940 ns |   265.00 ns |   268.37 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   650.86 ns | 13.802 ns | 0.757 ns |   650.17 ns |   651.67 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   120.81 ns | 55.587 ns | 3.047 ns |   118.83 ns |   124.32 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   397.48 ns | 22.302 ns | 1.222 ns |   396.12 ns |   398.49 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    81.04 ns |  4.585 ns | 0.251 ns |    80.84 ns |    81.32 ns | 0.0315 |     528 B |
