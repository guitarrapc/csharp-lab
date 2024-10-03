```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **494.41 ns** | **17.437 ns** | **0.956 ns** |   **493.84 ns** |   **495.52 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.76 ns |  7.800 ns | 0.428 ns |   114.34 ns |   115.19 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.69 ns |  6.574 ns | 0.360 ns |   240.34 ns |   241.06 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.00 ns |  2.378 ns | 0.130 ns |    41.85 ns |    42.07 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.66 ns |  9.513 ns | 0.521 ns |   142.21 ns |   143.23 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.39 ns |  1.999 ns | 0.110 ns |    40.27 ns |    40.49 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,846.04 ns** | **27.006 ns** | **1.480 ns** | **1,845.17 ns** | **1,847.75 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   343.22 ns |  2.274 ns | 0.125 ns |   343.14 ns |   343.37 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   732.30 ns | 15.802 ns | 0.866 ns |   731.39 ns |   733.11 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.92 ns |  4.875 ns | 0.267 ns |   126.66 ns |   127.19 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   438.84 ns | 18.336 ns | 1.005 ns |   437.91 ns |   439.91 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.73 ns |  3.848 ns | 0.211 ns |   118.56 ns |   118.97 ns | 0.0062 |     528 B |
