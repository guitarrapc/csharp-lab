```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **488.43 ns** |   **7.476 ns** | **0.410 ns** |   **487.98 ns** |   **488.77 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.99 ns |   8.037 ns | 0.441 ns |   116.58 ns |   117.46 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.52 ns |  20.227 ns | 1.109 ns |   233.47 ns |   235.68 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.82 ns |   5.104 ns | 0.280 ns |    43.56 ns |    44.12 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   138.03 ns |   3.208 ns | 0.176 ns |   137.82 ns |   138.13 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.48 ns |   4.848 ns | 0.266 ns |    39.31 ns |    39.78 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,593.43 ns** |  **85.970 ns** | **4.712 ns** | **1,590.09 ns** | **1,598.82 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   341.13 ns |  42.676 ns | 2.339 ns |   339.13 ns |   343.70 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   738.01 ns |  36.004 ns | 1.973 ns |   736.26 ns |   740.15 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.10 ns |   7.252 ns | 0.398 ns |   126.70 ns |   127.49 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   427.36 ns |  24.608 ns | 1.349 ns |   426.14 ns |   428.81 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.31 ns | 119.424 ns | 6.546 ns |   118.46 ns |   129.87 ns | 0.0062 |     528 B |
