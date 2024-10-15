```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **517.14 ns** |  **30.817 ns** |  **1.689 ns** |   **515.62 ns** |   **518.96 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.80 ns |   2.539 ns |  0.139 ns |   112.64 ns |   112.89 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.42 ns | 138.963 ns |  7.617 ns |   232.99 ns |   246.22 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.85 ns |   4.569 ns |  0.250 ns |    42.56 ns |    43.00 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.48 ns |   4.636 ns |  0.254 ns |   144.21 ns |   144.70 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.80 ns |   1.105 ns |  0.061 ns |    39.74 ns |    39.86 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,573.42 ns** |  **76.584 ns** |  **4.198 ns** | **1,570.61 ns** | **1,578.24 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   402.61 ns |   7.673 ns |  0.421 ns |   402.14 ns |   402.93 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   724.92 ns | 323.395 ns | 17.726 ns |   714.58 ns |   745.38 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.92 ns |  17.693 ns |  0.970 ns |   127.85 ns |   129.73 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   419.66 ns |   4.718 ns |  0.259 ns |   419.49 ns |   419.96 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.42 ns |  17.341 ns |  0.951 ns |   116.56 ns |   118.44 ns | 0.0062 |     528 B |
