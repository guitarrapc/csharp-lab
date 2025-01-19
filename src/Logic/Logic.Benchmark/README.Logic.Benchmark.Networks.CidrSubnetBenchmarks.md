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
| **GetNthSubnetIPv6**             | **1**      |   **451.78 ns** |  **10.776 ns** | **0.591 ns** |   **451.27 ns** |   **452.43 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    95.43 ns |   6.638 ns | 0.364 ns |    95.07 ns |    95.80 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   229.75 ns |  36.344 ns | 1.992 ns |   227.53 ns |   231.39 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.29 ns |   8.297 ns | 0.455 ns |    40.79 ns |    41.67 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.25 ns |  13.527 ns | 0.741 ns |   142.76 ns |   144.11 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    30.27 ns |  13.520 ns | 0.741 ns |    29.56 ns |    31.04 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,435.58 ns** | **163.692 ns** | **8.972 ns** | **1,427.60 ns** | **1,445.29 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   288.20 ns |  15.298 ns | 0.839 ns |   287.41 ns |   289.08 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   735.64 ns |  80.666 ns | 4.422 ns |   731.27 ns |   740.11 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   120.62 ns |  25.350 ns | 1.390 ns |   119.53 ns |   122.19 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   448.06 ns | 107.460 ns | 5.890 ns |   443.32 ns |   454.65 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    90.43 ns |  25.444 ns | 1.395 ns |    89.05 ns |    91.83 ns | 0.0315 |     528 B |
