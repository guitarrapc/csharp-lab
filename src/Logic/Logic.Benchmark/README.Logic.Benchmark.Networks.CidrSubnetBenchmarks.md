```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **499.71 ns** |  **84.560 ns** | **4.635 ns** |   **495.35 ns** |   **504.58 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.73 ns |   9.198 ns | 0.504 ns |   112.33 ns |   113.30 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   230.32 ns |   5.582 ns | 0.306 ns |   230.00 ns |   230.61 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.79 ns |  11.432 ns | 0.627 ns |    42.23 ns |    43.46 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.18 ns |  15.233 ns | 0.835 ns |   144.61 ns |   146.14 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.19 ns |   6.343 ns | 0.348 ns |    38.95 ns |    39.59 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,575.02 ns** | **149.688 ns** | **8.205 ns** | **1,567.74 ns** | **1,583.92 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.40 ns |   1.881 ns | 0.103 ns |   345.28 ns |   345.48 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   721.59 ns |  35.150 ns | 1.927 ns |   719.39 ns |   722.95 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.81 ns | 121.273 ns | 6.647 ns |   121.94 ns |   133.49 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   419.44 ns |  17.856 ns | 0.979 ns |   418.72 ns |   420.55 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.28 ns |   9.747 ns | 0.534 ns |   114.84 ns |   115.87 ns | 0.0062 |     528 B |
