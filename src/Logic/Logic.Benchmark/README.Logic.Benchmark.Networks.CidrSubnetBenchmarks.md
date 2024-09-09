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
| **GetNthSubnetIPv6**             | **1**      |   **520.62 ns** |  **86.019 ns** | **4.715 ns** |   **517.37 ns** |   **526.03 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.88 ns |   4.512 ns | 0.247 ns |   115.61 ns |   116.09 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.49 ns |  21.634 ns | 1.186 ns |   235.44 ns |   237.78 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.84 ns |   1.275 ns | 0.070 ns |    41.79 ns |    41.92 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.57 ns | 117.154 ns | 6.422 ns |   139.72 ns |   150.99 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.00 ns |   1.607 ns | 0.088 ns |    38.90 ns |    39.07 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,531.59 ns** |  **97.053 ns** | **5.320 ns** | **1,526.29 ns** | **1,536.93 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   340.49 ns |  18.208 ns | 0.998 ns |   339.37 ns |   341.27 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   752.61 ns |  57.318 ns | 3.142 ns |   749.15 ns |   755.28 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.65 ns |   9.802 ns | 0.537 ns |   128.25 ns |   129.26 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   439.87 ns |  38.938 ns | 2.134 ns |   437.87 ns |   442.12 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.78 ns |   2.663 ns | 0.146 ns |   115.61 ns |   115.87 ns | 0.0062 |     528 B |
