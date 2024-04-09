```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **507.53 ns** | **57.732 ns** | **3.164 ns** |   **504.43 ns** |   **510.76 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.98 ns |  5.108 ns | 0.280 ns |   114.68 ns |   115.23 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.31 ns |  5.220 ns | 0.286 ns |   235.03 ns |   235.60 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.66 ns |  3.847 ns | 0.211 ns |    40.46 ns |    40.88 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   138.86 ns |  9.500 ns | 0.521 ns |   138.42 ns |   139.44 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.51 ns |  9.273 ns | 0.508 ns |    38.13 ns |    39.09 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,568.36 ns** | **26.672 ns** | **1.462 ns** | **1,567.37 ns** | **1,570.04 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   347.82 ns | 37.932 ns | 2.079 ns |   345.64 ns |   349.79 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   712.33 ns | 15.818 ns | 0.867 ns |   711.36 ns |   713.04 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.04 ns |  9.049 ns | 0.496 ns |   123.46 ns |   124.33 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   445.80 ns | 66.247 ns | 3.631 ns |   442.84 ns |   449.85 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   114.37 ns | 17.570 ns | 0.963 ns |   113.32 ns |   115.22 ns | 0.0062 |     528 B |
