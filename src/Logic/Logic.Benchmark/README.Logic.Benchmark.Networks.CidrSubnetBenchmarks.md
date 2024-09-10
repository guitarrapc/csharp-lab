```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **500.93 ns** |  **38.060 ns** |  **2.086 ns** |   **499.48 ns** |   **503.32 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.01 ns |   2.140 ns |  0.117 ns |   114.89 ns |   115.12 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   241.53 ns |  14.304 ns |  0.784 ns |   240.65 ns |   242.16 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.18 ns |   3.984 ns |  0.218 ns |    41.98 ns |    42.41 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.86 ns |   8.753 ns |  0.480 ns |   141.36 ns |   142.32 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    43.88 ns |   7.072 ns |  0.388 ns |    43.43 ns |    44.14 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,623.67 ns** | **876.586 ns** | **48.049 ns** | **1,594.71 ns** | **1,679.14 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   352.08 ns |  41.292 ns |  2.263 ns |   349.51 ns |   353.76 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   750.04 ns |  13.272 ns |  0.728 ns |   749.21 ns |   750.55 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.76 ns |   7.263 ns |  0.398 ns |   124.42 ns |   125.20 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   433.33 ns |  23.033 ns |  1.263 ns |   431.94 ns |   434.41 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.21 ns |  12.920 ns |  0.708 ns |   119.56 ns |   120.97 ns | 0.0062 |     528 B |
