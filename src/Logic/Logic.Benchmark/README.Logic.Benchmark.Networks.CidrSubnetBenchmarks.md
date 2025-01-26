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
| **GetNthSubnetIPv6**             | **1**      |   **468.20 ns** |  **32.428 ns** | **1.777 ns** |   **466.53 ns** |   **470.07 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    94.99 ns |   8.467 ns | 0.464 ns |    94.63 ns |    95.52 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.20 ns |  29.487 ns | 1.616 ns |   230.76 ns |   233.95 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    39.98 ns |   5.287 ns | 0.290 ns |    39.65 ns |    40.16 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.50 ns |  25.567 ns | 1.401 ns |   141.42 ns |   144.08 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    29.96 ns |   2.790 ns | 0.153 ns |    29.79 ns |    30.10 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,410.44 ns** | **177.244 ns** | **9.715 ns** | **1,401.04 ns** | **1,420.44 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   283.45 ns |  27.714 ns | 1.519 ns |   281.92 ns |   284.96 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   719.96 ns |  22.743 ns | 1.247 ns |   718.67 ns |   721.16 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   120.85 ns |  29.504 ns | 1.617 ns |   119.17 ns |   122.39 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   449.33 ns |  39.680 ns | 2.175 ns |   446.86 ns |   450.93 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    90.21 ns |  11.520 ns | 0.631 ns |    89.60 ns |    90.86 ns | 0.0315 |     528 B |
