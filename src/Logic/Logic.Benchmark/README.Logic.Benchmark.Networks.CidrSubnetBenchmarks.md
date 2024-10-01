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
| **GetNthSubnetIPv6**             | **1**      |   **494.88 ns** |  **25.282 ns** | **1.386 ns** |   **493.92 ns** |   **496.47 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   121.05 ns |   7.294 ns | 0.400 ns |   120.59 ns |   121.32 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   238.25 ns |   5.382 ns | 0.295 ns |   237.98 ns |   238.57 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.30 ns |   2.044 ns | 0.112 ns |    42.20 ns |    42.42 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   147.18 ns |  17.274 ns | 0.947 ns |   146.47 ns |   148.25 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.92 ns |   8.426 ns | 0.462 ns |    39.58 ns |    40.45 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,604.64 ns** | **156.215 ns** | **8.563 ns** | **1,594.76 ns** | **1,609.83 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   344.38 ns |  18.190 ns | 0.997 ns |   343.52 ns |   345.47 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   726.94 ns |  26.207 ns | 1.436 ns |   725.28 ns |   727.89 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.26 ns |   9.629 ns | 0.528 ns |   125.65 ns |   126.57 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   426.17 ns |  34.639 ns | 1.899 ns |   424.39 ns |   428.17 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   119.65 ns |  11.781 ns | 0.646 ns |   119.17 ns |   120.39 ns | 0.0062 |     528 B |
