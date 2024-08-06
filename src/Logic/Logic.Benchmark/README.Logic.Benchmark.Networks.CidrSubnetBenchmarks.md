```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **534.07 ns** |  **17.980 ns** | **0.986 ns** |   **532.93 ns** |   **534.67 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.30 ns |   1.556 ns | 0.085 ns |   115.23 ns |   115.40 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   247.86 ns |  11.129 ns | 0.610 ns |   247.28 ns |   248.50 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.05 ns |   0.794 ns | 0.043 ns |    44.02 ns |    44.10 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.74 ns |   0.857 ns | 0.047 ns |   140.69 ns |   140.79 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.41 ns |   1.733 ns | 0.095 ns |    40.30 ns |    40.48 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,636.58 ns** |  **39.371 ns** | **2.158 ns** | **1,634.78 ns** | **1,638.97 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.08 ns |  71.529 ns | 3.921 ns |   343.29 ns |   350.56 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   730.26 ns |  15.231 ns | 0.835 ns |   729.70 ns |   731.22 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.95 ns |  10.441 ns | 0.572 ns |   125.29 ns |   126.33 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   441.08 ns | 120.473 ns | 6.604 ns |   437.12 ns |   448.70 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.17 ns |  38.350 ns | 2.102 ns |   118.45 ns |   122.51 ns | 0.0062 |     528 B |
