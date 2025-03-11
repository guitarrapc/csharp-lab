```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **480.52 ns** | **36.141 ns** | **1.981 ns** |   **478.24 ns** |   **481.82 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   111.18 ns |  4.016 ns | 0.220 ns |   110.95 ns |   111.39 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   223.19 ns |  5.005 ns | 0.274 ns |   222.88 ns |   223.41 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    37.77 ns |  6.718 ns | 0.368 ns |    37.54 ns |    38.19 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   146.93 ns | 11.558 ns | 0.634 ns |   146.24 ns |   147.50 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    33.81 ns |  2.237 ns | 0.123 ns |    33.69 ns |    33.94 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   422.12 ns | 19.094 ns | 1.047 ns |   421.16 ns |   423.24 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    93.69 ns |  6.507 ns | 0.357 ns |    93.47 ns |    94.10 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   232.40 ns |  5.348 ns | 0.293 ns |   232.11 ns |   232.69 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    40.52 ns |  6.972 ns | 0.382 ns |    40.27 ns |    40.96 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   137.08 ns | 16.458 ns | 0.902 ns |   136.56 ns |   138.12 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    29.83 ns |  4.593 ns | 0.252 ns |    29.67 ns |    30.12 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,564.97 ns** | **46.143 ns** | **2.529 ns** | **1,563.23 ns** | **1,567.87 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   331.17 ns |  8.594 ns | 0.471 ns |   330.75 ns |   331.68 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   660.44 ns | 56.076 ns | 3.074 ns |   658.49 ns |   663.98 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   113.53 ns |  3.445 ns | 0.189 ns |   113.34 ns |   113.72 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   416.72 ns | 49.618 ns | 2.720 ns |   413.58 ns |   418.41 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   101.22 ns |  5.728 ns | 0.314 ns |   100.88 ns |   101.51 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,376.53 ns | 33.781 ns | 1.852 ns | 1,374.41 ns | 1,377.86 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   281.65 ns | 70.209 ns | 3.848 ns |   279.14 ns |   286.08 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   718.90 ns | 32.835 ns | 1.800 ns |   717.39 ns |   720.89 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   120.84 ns |  0.882 ns | 0.048 ns |   120.78 ns |   120.88 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   434.96 ns | 10.395 ns | 0.570 ns |   434.37 ns |   435.51 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    86.70 ns | 10.973 ns | 0.601 ns |    86.01 ns |    87.12 ns | 0.0315 |     528 B |
