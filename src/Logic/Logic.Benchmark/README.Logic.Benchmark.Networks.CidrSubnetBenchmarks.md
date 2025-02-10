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
| **GetNthSubnetIPv6**             | **1**      |   **446.08 ns** |   **7.119 ns** | **0.390 ns** |   **445.69 ns** |   **446.47 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |   103.20 ns |   6.280 ns | 0.344 ns |   102.81 ns |   103.43 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   254.97 ns |  47.494 ns | 2.603 ns |   252.29 ns |   257.49 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.01 ns |  10.577 ns | 0.580 ns |    43.47 ns |    44.63 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   148.19 ns |  25.738 ns | 1.411 ns |   147.16 ns |   149.80 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    35.27 ns |  13.192 ns | 0.723 ns |    34.74 ns |    36.10 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,468.23 ns** | **148.460 ns** | **8.138 ns** | **1,461.77 ns** | **1,477.37 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   298.76 ns |  53.813 ns | 2.950 ns |   295.36 ns |   300.60 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   769.74 ns |  93.130 ns | 5.105 ns |   764.58 ns |   774.78 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.28 ns |  24.631 ns | 1.350 ns |   126.78 ns |   129.40 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   470.72 ns |  58.972 ns | 3.232 ns |   467.72 ns |   474.14 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   104.51 ns |  47.783 ns | 2.619 ns |   101.79 ns |   107.01 ns | 0.0315 |     528 B |
