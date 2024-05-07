```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **530.88 ns** | **18.858 ns** | **1.034 ns** |   **529.94 ns** |   **531.98 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   120.27 ns | 25.929 ns | 1.421 ns |   118.63 ns |   121.13 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.87 ns | 18.053 ns | 0.990 ns |   236.21 ns |   238.01 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    45.90 ns |  2.325 ns | 0.127 ns |    45.80 ns |    46.05 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.12 ns |  6.732 ns | 0.369 ns |   140.75 ns |   141.49 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.91 ns |  2.799 ns | 0.153 ns |    39.73 ns |    40.02 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,536.91 ns** | **98.720 ns** | **5.411 ns** | **1,532.99 ns** | **1,543.08 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.13 ns | 11.310 ns | 0.620 ns |   346.42 ns |   347.55 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   719.84 ns | 15.576 ns | 0.854 ns |   719.00 ns |   720.71 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.34 ns |  7.414 ns | 0.406 ns |   125.01 ns |   125.80 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   440.52 ns |  8.261 ns | 0.453 ns |   440.05 ns |   440.95 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.82 ns | 29.302 ns | 1.606 ns |   117.39 ns |   120.56 ns | 0.0062 |     528 B |
