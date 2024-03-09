```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **508.66 ns** |  **45.994 ns** |  **2.521 ns** |   **506.79 ns** |   **511.53 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.61 ns |  13.764 ns |  0.754 ns |   112.02 ns |   113.46 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.20 ns |   5.370 ns |  0.294 ns |   239.86 ns |   240.42 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.15 ns |   3.845 ns |  0.211 ns |    40.97 ns |    41.38 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.75 ns |   9.362 ns |  0.513 ns |   146.16 ns |   147.06 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.35 ns |   1.555 ns |  0.085 ns |    38.27 ns |    38.44 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,650.11 ns** | **626.611 ns** | **34.347 ns** | **1,628.96 ns** | **1,689.74 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.29 ns |  79.285 ns |  4.346 ns |   342.40 ns |   350.29 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   735.92 ns |  27.130 ns |  1.487 ns |   734.26 ns |   737.12 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   122.43 ns |   3.900 ns |  0.214 ns |   122.22 ns |   122.65 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   417.06 ns |   8.250 ns |  0.452 ns |   416.60 ns |   417.50 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.74 ns |  13.570 ns |  0.744 ns |   115.15 ns |   116.57 ns | 0.0062 |     528 B |
