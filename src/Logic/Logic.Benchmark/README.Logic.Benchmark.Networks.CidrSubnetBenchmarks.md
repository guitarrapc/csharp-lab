```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.91 ns** |  **14.763 ns** | **0.809 ns** |   **505.42 ns** |   **506.84 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.77 ns |  15.015 ns | 0.823 ns |   113.24 ns |   114.72 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.74 ns |  21.021 ns | 1.152 ns |   238.55 ns |   240.85 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.95 ns |  10.684 ns | 0.586 ns |    41.39 ns |    42.56 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.43 ns |  17.759 ns | 0.973 ns |   139.66 ns |   141.53 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.26 ns |   2.628 ns | 0.144 ns |    39.13 ns |    39.41 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,564.06 ns** | **121.864 ns** | **6.680 ns** | **1,556.58 ns** | **1,569.42 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   349.29 ns |  17.831 ns | 0.977 ns |   348.58 ns |   350.41 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   708.55 ns |  29.804 ns | 1.634 ns |   707.52 ns |   710.43 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.22 ns |   6.548 ns | 0.359 ns |   124.84 ns |   125.55 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   462.06 ns |  20.040 ns | 1.098 ns |   460.81 ns |   462.87 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.77 ns |  32.921 ns | 1.805 ns |   115.16 ns |   118.72 ns | 0.0062 |     528 B |
