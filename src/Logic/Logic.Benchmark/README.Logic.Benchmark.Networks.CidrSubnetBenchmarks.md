```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **456.56 ns** |  **42.765 ns** |  **2.344 ns** |   **454.68 ns** |   **459.18 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    95.04 ns |   7.582 ns |  0.416 ns |    94.79 ns |    95.52 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   244.69 ns |  46.412 ns |  2.544 ns |   241.79 ns |   246.52 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.43 ns |   7.216 ns |  0.396 ns |    42.07 ns |    42.85 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.13 ns |  19.092 ns |  1.046 ns |   141.02 ns |   143.10 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    31.14 ns |   2.211 ns |  0.121 ns |    31.02 ns |    31.26 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,518.38 ns** | **307.445 ns** | **16.852 ns** | **1,503.46 ns** | **1,536.66 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   292.89 ns | 160.894 ns |  8.819 ns |   284.90 ns |   302.35 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   737.20 ns |  71.059 ns |  3.895 ns |   732.84 ns |   740.34 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   122.39 ns |  28.543 ns |  1.565 ns |   120.89 ns |   124.01 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   432.54 ns |  64.552 ns |  3.538 ns |   430.20 ns |   436.61 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    90.74 ns |  30.201 ns |  1.655 ns |    89.42 ns |    92.59 ns | 0.0315 |     528 B |
