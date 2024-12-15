```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **504.84 ns** | **85.681 ns** | **4.696 ns** |   **501.24 ns** |   **510.15 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.46 ns |  2.723 ns | 0.149 ns |   114.30 ns |   114.60 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   241.17 ns |  4.089 ns | 0.224 ns |   240.92 ns |   241.32 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.43 ns |  1.414 ns | 0.077 ns |    41.38 ns |    41.52 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.12 ns |  5.941 ns | 0.326 ns |   140.87 ns |   141.49 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.12 ns |  0.583 ns | 0.032 ns |    39.09 ns |    39.15 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,581.58 ns** | **27.365 ns** | **1.500 ns** | **1,580.31 ns** | **1,583.24 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   392.26 ns |  5.670 ns | 0.311 ns |   391.93 ns |   392.55 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   718.76 ns | 17.933 ns | 0.983 ns |   717.67 ns |   719.59 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.17 ns |  8.602 ns | 0.472 ns |   122.74 ns |   123.67 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   448.48 ns | 26.433 ns | 1.449 ns |   447.41 ns |   450.13 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.08 ns | 18.666 ns | 1.023 ns |   116.46 ns |   118.26 ns | 0.0062 |     528 B |
