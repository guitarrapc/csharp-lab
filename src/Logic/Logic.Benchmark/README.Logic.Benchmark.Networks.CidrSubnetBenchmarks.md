```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **576.15 ns** |  **17.249 ns** | **0.945 ns** |   **575.26 ns** |   **577.14 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.50 ns |   2.804 ns | 0.154 ns |   114.37 ns |   114.67 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.95 ns |   7.923 ns | 0.434 ns |   236.45 ns |   237.24 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.38 ns |   2.891 ns | 0.158 ns |    41.26 ns |    41.56 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.40 ns |  20.224 ns | 1.109 ns |   139.15 ns |   141.28 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.73 ns |   8.701 ns | 0.477 ns |    38.34 ns |    39.26 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,596.13 ns** | **115.328 ns** | **6.322 ns** | **1,588.91 ns** | **1,600.67 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.48 ns |  48.453 ns | 2.656 ns |   343.61 ns |   348.52 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   720.08 ns |  47.036 ns | 2.578 ns |   717.51 ns |   722.67 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.41 ns |  11.956 ns | 0.655 ns |   122.68 ns |   123.95 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   436.04 ns |  25.292 ns | 1.386 ns |   434.57 ns |   437.33 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   114.27 ns |  12.254 ns | 0.672 ns |   113.79 ns |   115.04 ns | 0.0062 |     528 B |
