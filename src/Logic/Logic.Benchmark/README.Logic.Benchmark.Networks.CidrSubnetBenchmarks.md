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
| **GetNthSubnetIPv6**             | **1**      |   **467.55 ns** |  **63.780 ns** | **3.496 ns** |   **463.51 ns** |   **469.68 ns** | **0.0381** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    97.27 ns |   6.885 ns | 0.377 ns |    96.99 ns |    97.70 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.74 ns | 120.415 ns | 6.600 ns |   237.53 ns |   250.16 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    40.10 ns |   2.369 ns | 0.130 ns |    39.96 ns |    40.22 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   137.92 ns |   6.315 ns | 0.346 ns |   137.52 ns |   138.12 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    30.09 ns |   3.860 ns | 0.212 ns |    29.85 ns |    30.21 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,435.00 ns** | **139.777 ns** | **7.662 ns** | **1,427.95 ns** | **1,443.15 ns** | **0.1183** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   281.58 ns |  33.782 ns | 1.852 ns |   279.44 ns |   282.66 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   698.48 ns |  83.240 ns | 4.563 ns |   694.92 ns |   703.62 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   119.48 ns |  25.460 ns | 1.396 ns |   117.97 ns |   120.71 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   440.82 ns |  19.019 ns | 1.042 ns |   439.83 ns |   441.91 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |    88.97 ns |  12.560 ns | 0.688 ns |    88.18 ns |    89.48 ns | 0.0315 |     528 B |
