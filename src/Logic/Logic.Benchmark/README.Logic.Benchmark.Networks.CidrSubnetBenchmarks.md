```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **524.63 ns** | **10.862 ns** | **0.595 ns** |   **523.97 ns** |   **525.12 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.43 ns |  0.428 ns | 0.023 ns |   116.41 ns |   116.46 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.43 ns |  2.953 ns | 0.162 ns |   237.24 ns |   237.52 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.59 ns |  1.353 ns | 0.074 ns |    42.50 ns |    42.64 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.94 ns |  3.339 ns | 0.183 ns |   146.76 ns |   147.12 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.80 ns |  1.319 ns | 0.072 ns |    39.72 ns |    39.86 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,600.23 ns** | **57.769 ns** | **3.166 ns** | **1,597.22 ns** | **1,603.53 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   341.21 ns | 10.081 ns | 0.553 ns |   340.83 ns |   341.85 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   734.25 ns | 25.422 ns | 1.393 ns |   733.35 ns |   735.86 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   157.34 ns | 13.500 ns | 0.740 ns |   156.63 ns |   158.11 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   461.97 ns | 17.905 ns | 0.981 ns |   461.27 ns |   463.09 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   121.69 ns | 10.974 ns | 0.602 ns |   121.02 ns |   122.17 ns | 0.0062 |     528 B |
