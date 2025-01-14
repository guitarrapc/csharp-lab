```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **460.62 ns** |  **39.840 ns** | **2.184 ns** |   **458.59 ns** |   **462.93 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |   102.95 ns |   6.583 ns | 0.361 ns |   102.54 ns |   103.21 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.71 ns |  35.602 ns | 1.951 ns |   233.47 ns |   236.96 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.69 ns |  10.033 ns | 0.550 ns |    42.07 ns |    43.10 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.01 ns |  26.499 ns | 1.453 ns |   141.42 ns |   144.26 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    30.19 ns |   9.677 ns | 0.530 ns |    29.76 ns |    30.79 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,360.27 ns** |  **78.699 ns** | **4.314 ns** | **1,356.61 ns** | **1,365.02 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   291.27 ns |  38.984 ns | 2.137 ns |   288.99 ns |   293.22 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   734.83 ns |  46.302 ns | 2.538 ns |   732.97 ns |   737.72 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   140.54 ns |  24.372 ns | 1.336 ns |   139.20 ns |   141.87 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   444.71 ns | 115.743 ns | 6.344 ns |   441.01 ns |   452.03 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    90.51 ns |   7.571 ns | 0.415 ns |    90.06 ns |    90.88 ns | 0.0315 |     528 B |
