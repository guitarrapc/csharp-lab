```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **517.35 ns** |  **22.369 ns** | **1.226 ns** |   **516.54 ns** |   **518.76 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.72 ns |   2.974 ns | 0.163 ns |   112.62 ns |   112.91 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.09 ns |  11.804 ns | 0.647 ns |   239.46 ns |   240.75 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.75 ns |   3.165 ns | 0.173 ns |    41.56 ns |    41.90 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   151.65 ns |   7.320 ns | 0.401 ns |   151.19 ns |   151.93 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.61 ns |   5.192 ns | 0.285 ns |    39.40 ns |    39.94 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,577.65 ns** | **139.710 ns** | **7.658 ns** | **1,570.33 ns** | **1,585.61 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   342.85 ns |  82.385 ns | 4.516 ns |   339.73 ns |   348.03 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   719.82 ns | 150.793 ns | 8.265 ns |   714.19 ns |   729.31 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.50 ns |  25.279 ns | 1.386 ns |   123.51 ns |   126.09 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   423.32 ns |  11.747 ns | 0.644 ns |   422.84 ns |   424.05 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   119.92 ns |  19.522 ns | 1.070 ns |   118.90 ns |   121.03 ns | 0.0062 |     528 B |
