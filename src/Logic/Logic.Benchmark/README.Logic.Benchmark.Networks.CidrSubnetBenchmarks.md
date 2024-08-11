```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **516.33 ns** |  **14.334 ns** | **0.786 ns** |   **515.88 ns** |   **517.24 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.86 ns |   0.597 ns | 0.033 ns |   113.83 ns |   113.89 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.29 ns |   8.931 ns | 0.490 ns |   236.80 ns |   237.78 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.57 ns |   4.950 ns | 0.271 ns |    41.39 ns |    41.88 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.07 ns |   2.897 ns | 0.159 ns |   138.88 ns |   139.16 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.84 ns |  13.226 ns | 0.725 ns |    39.25 ns |    40.65 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,572.50 ns** | **118.701 ns** | **6.506 ns** | **1,566.06 ns** | **1,579.07 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.36 ns |  79.890 ns | 4.379 ns |   342.33 ns |   350.38 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   724.05 ns |  21.968 ns | 1.204 ns |   722.92 ns |   725.32 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.59 ns |  33.106 ns | 1.815 ns |   124.47 ns |   127.68 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   436.02 ns |  62.522 ns | 3.427 ns |   432.13 ns |   438.61 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.26 ns |  46.910 ns | 2.571 ns |   117.33 ns |   122.16 ns | 0.0062 |     528 B |
