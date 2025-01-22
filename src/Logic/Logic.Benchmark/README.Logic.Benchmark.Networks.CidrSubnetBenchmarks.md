```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **441.71 ns** |  **37.074 ns** | **2.032 ns** |   **439.49 ns** |   **443.49 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    95.32 ns |   9.783 ns | 0.536 ns |    94.81 ns |    95.88 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.96 ns |  49.184 ns | 2.696 ns |   235.03 ns |   240.33 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.78 ns |  36.074 ns | 1.977 ns |    40.79 ns |    44.75 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   148.19 ns |   2.581 ns | 0.141 ns |   148.02 ns |   148.28 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    31.07 ns |  16.238 ns | 0.890 ns |    30.38 ns |    32.08 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,445.94 ns** | **157.423 ns** | **8.629 ns** | **1,436.15 ns** | **1,452.46 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   288.71 ns |   9.481 ns | 0.520 ns |   288.18 ns |   289.22 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   745.31 ns | 148.472 ns | 8.138 ns |   737.99 ns |   754.07 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   121.38 ns |  40.782 ns | 2.235 ns |   119.09 ns |   123.56 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   433.07 ns |  63.707 ns | 3.492 ns |   429.73 ns |   436.69 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    90.78 ns |  12.774 ns | 0.700 ns |    90.04 ns |    91.43 ns | 0.0315 |     528 B |
