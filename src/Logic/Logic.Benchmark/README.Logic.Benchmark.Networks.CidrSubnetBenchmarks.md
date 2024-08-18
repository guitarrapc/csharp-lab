```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **516.84 ns** | **49.974 ns** | **2.739 ns** |   **513.81 ns** |   **519.13 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   111.98 ns |  3.430 ns | 0.188 ns |   111.86 ns |   112.19 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.83 ns | 91.793 ns | 5.031 ns |   233.88 ns |   242.64 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.97 ns |  4.816 ns | 0.264 ns |    41.73 ns |    42.25 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   147.42 ns |  3.906 ns | 0.214 ns |   147.22 ns |   147.64 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.53 ns |  8.879 ns | 0.487 ns |    38.21 ns |    39.09 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,603.72 ns** | **28.582 ns** | **1.567 ns** | **1,602.02 ns** | **1,605.11 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.81 ns | 11.967 ns | 0.656 ns |   346.09 ns |   347.38 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   736.74 ns |  4.011 ns | 0.220 ns |   736.56 ns |   736.99 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.23 ns | 24.079 ns | 1.320 ns |   123.25 ns |   125.73 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   468.13 ns |  5.352 ns | 0.293 ns |   467.83 ns |   468.42 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.14 ns |  8.124 ns | 0.445 ns |   114.77 ns |   115.64 ns | 0.0062 |     528 B |
