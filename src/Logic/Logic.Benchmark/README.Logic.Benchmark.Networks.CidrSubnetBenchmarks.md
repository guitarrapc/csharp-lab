```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **520.20 ns** |  **30.315 ns** | **1.662 ns** |   **519.19 ns** |   **522.11 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.57 ns |   9.507 ns | 0.521 ns |   114.03 ns |   115.06 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.36 ns |   4.818 ns | 0.264 ns |   242.15 ns |   242.66 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.16 ns |   3.369 ns | 0.185 ns |    41.95 ns |    42.31 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   149.34 ns |  29.716 ns | 1.629 ns |   148.19 ns |   151.20 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.75 ns |   5.672 ns | 0.311 ns |    39.44 ns |    40.07 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,545.07 ns** | **100.974 ns** | **5.535 ns** | **1,541.30 ns** | **1,551.42 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.75 ns |   6.336 ns | 0.347 ns |   345.45 ns |   346.13 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   744.79 ns |  33.375 ns | 1.829 ns |   743.12 ns |   746.74 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   137.40 ns |  47.809 ns | 2.621 ns |   135.74 ns |   140.42 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   441.82 ns |  40.562 ns | 2.223 ns |   440.29 ns |   444.37 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.37 ns |  15.771 ns | 0.864 ns |   119.50 ns |   121.23 ns | 0.0062 |     528 B |
