```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **499.31 ns** |  **24.719 ns** | **1.355 ns** |   **498.30 ns** |   **500.85 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.26 ns |   5.266 ns | 0.289 ns |   116.01 ns |   116.57 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.57 ns |   8.634 ns | 0.473 ns |   237.23 ns |   238.11 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.53 ns |   3.986 ns | 0.219 ns |    41.32 ns |    41.76 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.58 ns |  19.745 ns | 1.082 ns |   138.85 ns |   140.82 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.06 ns |   4.120 ns | 0.226 ns |    39.84 ns |    40.29 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,599.62 ns** | **163.353 ns** | **8.954 ns** | **1,592.74 ns** | **1,609.74 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.51 ns |  16.076 ns | 0.881 ns |   347.76 ns |   349.48 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   730.55 ns |  23.923 ns | 1.311 ns |   729.16 ns |   731.76 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.59 ns |  25.780 ns | 1.413 ns |   123.63 ns |   126.21 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   436.76 ns | 142.378 ns | 7.804 ns |   431.69 ns |   445.75 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.02 ns |  22.879 ns | 1.254 ns |   117.06 ns |   119.44 ns | 0.0062 |     528 B |
