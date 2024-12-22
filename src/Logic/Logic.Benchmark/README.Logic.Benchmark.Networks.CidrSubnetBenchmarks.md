```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **442.18 ns** | **50.489 ns** | **2.767 ns** |   **440.49 ns** |   **445.37 ns** | **0.0076** |     **640 B** |
| GetNthSubnetIPv4             | 1      |   101.17 ns |  3.362 ns | 0.184 ns |   101.06 ns |   101.38 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   245.93 ns | 25.790 ns | 1.414 ns |   244.51 ns |   247.34 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.83 ns |  1.887 ns | 0.103 ns |    42.72 ns |    42.92 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.83 ns |  7.001 ns | 0.384 ns |   140.49 ns |   141.24 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    34.85 ns |  3.311 ns | 0.182 ns |    34.68 ns |    35.04 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,421.49 ns** | **68.325 ns** | **3.745 ns** | **1,419.05 ns** | **1,425.81 ns** | **0.0229** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   292.37 ns | 14.713 ns | 0.806 ns |   291.75 ns |   293.28 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   737.22 ns | 36.117 ns | 1.980 ns |   736.00 ns |   739.50 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.98 ns |  6.226 ns | 0.341 ns |   127.69 ns |   128.35 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   480.60 ns | 43.218 ns | 2.369 ns |   477.87 ns |   482.10 ns | 0.0067 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   100.92 ns | 16.972 ns | 0.930 ns |   100.35 ns |   102.00 ns | 0.0062 |     528 B |
