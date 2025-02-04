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
| **GetNthSubnetIPv6**             | **1**      |   **440.79 ns** |  **54.118 ns** | **2.966 ns** |   **437.38 ns** |   **442.71 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    95.68 ns |  14.688 ns | 0.805 ns |    94.76 ns |    96.26 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.21 ns |  34.019 ns | 1.865 ns |   233.88 ns |   237.34 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.39 ns |   3.492 ns | 0.191 ns |    40.20 ns |    40.58 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   148.22 ns |  11.415 ns | 0.626 ns |   147.55 ns |   148.79 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    36.50 ns |  23.131 ns | 1.268 ns |    35.33 ns |    37.85 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,366.01 ns** | **129.181 ns** | **7.081 ns** | **1,358.06 ns** | **1,371.63 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   294.77 ns |  19.969 ns | 1.095 ns |   293.82 ns |   295.97 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   721.90 ns |  33.192 ns | 1.819 ns |   720.03 ns |   723.66 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   121.69 ns |  13.782 ns | 0.755 ns |   120.83 ns |   122.22 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   449.96 ns |  22.994 ns | 1.260 ns |   448.56 ns |   451.00 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    91.89 ns |  22.929 ns | 1.257 ns |    90.48 ns |    92.91 ns | 0.0315 |     528 B |
