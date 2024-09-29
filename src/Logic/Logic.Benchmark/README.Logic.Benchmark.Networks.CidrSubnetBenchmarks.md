```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **518.81 ns** | **105.600 ns** | **5.788 ns** |   **512.13 ns** |   **522.26 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   111.83 ns |   2.157 ns | 0.118 ns |   111.69 ns |   111.91 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.87 ns |  12.106 ns | 0.664 ns |   233.27 ns |   234.58 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.31 ns |   8.333 ns | 0.457 ns |    40.85 ns |    41.76 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.09 ns |   5.050 ns | 0.277 ns |   139.81 ns |   140.37 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.10 ns |   3.554 ns | 0.195 ns |    37.88 ns |    38.24 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,584.45 ns** |  **93.873 ns** | **5.145 ns** | **1,579.99 ns** | **1,590.08 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   367.28 ns |  38.539 ns | 2.112 ns |   364.97 ns |   369.12 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   714.13 ns |  74.322 ns | 4.074 ns |   709.57 ns |   717.39 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   120.35 ns |  42.996 ns | 2.357 ns |   118.97 ns |   123.07 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   445.10 ns |  18.272 ns | 1.002 ns |   444.07 ns |   446.07 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   112.50 ns |  28.385 ns | 1.556 ns |   110.78 ns |   113.81 ns | 0.0062 |     528 B |
