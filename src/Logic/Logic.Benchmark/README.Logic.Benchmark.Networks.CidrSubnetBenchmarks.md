```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **447.76 ns** | **19.917 ns** | **1.092 ns** |   **446.56 ns** |   **448.70 ns** | **0.0076** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    99.35 ns |  3.122 ns | 0.171 ns |    99.25 ns |    99.55 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   245.41 ns | 34.942 ns | 1.915 ns |   243.23 ns |   246.81 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.61 ns |  7.799 ns | 0.427 ns |    43.35 ns |    44.11 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   147.82 ns | 67.358 ns | 3.692 ns |   144.73 ns |   151.91 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    37.70 ns |  9.446 ns | 0.518 ns |    37.19 ns |    38.22 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,464.64 ns** | **82.342 ns** | **4.513 ns** | **1,459.48 ns** | **1,467.83 ns** | **0.0229** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   297.41 ns | 19.488 ns | 1.068 ns |   296.48 ns |   298.58 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   738.18 ns | 28.517 ns | 1.563 ns |   736.95 ns |   739.94 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   129.20 ns | 20.822 ns | 1.141 ns |   127.91 ns |   130.09 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   450.20 ns | 43.597 ns | 2.390 ns |   447.53 ns |   452.14 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   103.19 ns |  8.143 ns | 0.446 ns |   102.81 ns |   103.68 ns | 0.0062 |     528 B |
