```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **513.75 ns** |  **66.799 ns** |  **3.661 ns** |   **511.56 ns** |   **517.97 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   126.30 ns |  89.246 ns |  4.892 ns |   123.42 ns |   131.95 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   244.47 ns |  12.864 ns |  0.705 ns |   243.71 ns |   245.10 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.09 ns |   6.397 ns |  0.351 ns |    41.71 ns |    42.40 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   152.30 ns |  23.802 ns |  1.305 ns |   151.52 ns |   153.80 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.64 ns |   4.722 ns |  0.259 ns |    39.36 ns |    39.88 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,600.23 ns** | **436.486 ns** | **23.925 ns** | **1,585.38 ns** | **1,627.83 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   367.15 ns |  79.687 ns |  4.368 ns |   362.35 ns |   370.88 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   750.68 ns | 404.950 ns | 22.197 ns |   730.97 ns |   774.73 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.28 ns |  35.189 ns |  1.929 ns |   126.06 ns |   129.51 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   428.81 ns |  13.713 ns |  0.752 ns |   428.06 ns |   429.57 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.32 ns |   9.291 ns |  0.509 ns |   122.00 ns |   122.91 ns | 0.0062 |     528 B |
