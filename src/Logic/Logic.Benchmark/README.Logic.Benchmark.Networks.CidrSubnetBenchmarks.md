```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **435.44 ns** |  **56.75 ns** | **3.111 ns** |   **432.24 ns** |   **438.45 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    96.99 ns |  10.77 ns | 0.590 ns |    96.52 ns |    97.65 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   244.16 ns |  43.10 ns | 2.362 ns |   242.13 ns |   246.75 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.89 ns |  30.50 ns | 1.672 ns |    41.10 ns |    44.41 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.70 ns |  14.52 ns | 0.796 ns |   145.78 ns |   147.17 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    33.13 ns |  12.19 ns | 0.668 ns |    32.44 ns |    33.77 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,401.52 ns** | **119.52 ns** | **6.551 ns** | **1,395.33 ns** | **1,408.38 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   288.78 ns |  60.57 ns | 3.320 ns |   286.45 ns |   292.58 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   766.21 ns | 134.22 ns | 7.357 ns |   758.67 ns |   773.36 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   122.86 ns |  26.95 ns | 1.477 ns |   121.87 ns |   124.56 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   447.40 ns |  70.74 ns | 3.878 ns |   444.57 ns |   451.82 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    91.93 ns |  27.80 ns | 1.524 ns |    90.36 ns |    93.40 ns | 0.0315 |     528 B |
