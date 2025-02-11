```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method                       | Runtime  | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |--------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **.NET 8.0** | **1**      |   **486.85 ns** |  **45.117 ns** | **2.473 ns** |   **484.11 ns** |   **488.91 ns** | **0.0410** |     **696 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 1      |   107.90 ns |  29.171 ns | 1.599 ns |   106.59 ns |   109.68 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 1      |   234.30 ns |  83.176 ns | 4.559 ns |   229.08 ns |   237.50 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 1      |    38.63 ns |   8.683 ns | 0.476 ns |    38.29 ns |    39.17 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 1      |   141.33 ns |   8.069 ns | 0.442 ns |   140.86 ns |   141.74 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 1      |    37.86 ns |  37.147 ns | 2.036 ns |    36.59 ns |    40.21 ns | 0.0105 |     176 B |
| GetNthSubnetIPv6             | .NET 9.0 | 1      |   462.49 ns |  52.718 ns | 2.890 ns |   459.20 ns |   464.60 ns | 0.0381 |     640 B |
| GetNthSubnetIPv4             | .NET 9.0 | 1      |    97.52 ns |   8.022 ns | 0.440 ns |    97.01 ns |    97.79 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 1      |   242.90 ns |  36.688 ns | 2.011 ns |   240.80 ns |   244.81 ns | 0.0257 |     432 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 1      |    41.23 ns |   5.297 ns | 0.290 ns |    41.00 ns |    41.55 ns | 0.0095 |     160 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 1      |   147.17 ns |   8.127 ns | 0.445 ns |   146.70 ns |   147.58 ns | 0.0124 |     208 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 1      |    31.59 ns |   2.947 ns | 0.162 ns |    31.45 ns |    31.77 ns | 0.0105 |     176 B |
| **GetNthSubnetIPv6**             | **.NET 8.0** | **3**      | **1,648.08 ns** | **102.922 ns** | **5.642 ns** | **1,641.58 ns** | **1,651.79 ns** | **0.1278** |    **2168 B** |
| GetNthSubnetIPv4             | .NET 8.0 | 3      |   342.84 ns |  38.215 ns | 2.095 ns |   340.44 ns |   344.30 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 8.0 | 3      |   708.69 ns |  38.395 ns | 2.105 ns |   706.94 ns |   711.02 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 8.0 | 3      |   120.63 ns |  16.788 ns | 0.920 ns |   119.57 ns |   121.26 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 8.0 | 3      |   424.72 ns |  45.674 ns | 2.504 ns |   422.27 ns |   427.28 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 8.0 | 3      |   107.20 ns |  32.082 ns | 1.759 ns |   105.25 ns |   108.67 ns | 0.0315 |     528 B |
| GetNthSubnetIPv6             | .NET 9.0 | 3      | 1,457.50 ns |  49.926 ns | 2.737 ns | 1,454.91 ns | 1,460.36 ns | 0.1183 |    2000 B |
| GetNthSubnetIPv4             | .NET 9.0 | 3      |   288.12 ns |   7.197 ns | 0.394 ns |   287.68 ns |   288.44 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv6BigInteger | .NET 9.0 | 3      |   732.08 ns |  91.077 ns | 4.992 ns |   726.45 ns |   735.97 ns | 0.0772 |    1296 B |
| GetSubnetRangeIPv6Shift      | .NET 9.0 | 3      |   120.86 ns |  13.724 ns | 0.752 ns |   120.05 ns |   121.53 ns | 0.0286 |     480 B |
| GetSubnetRangeIPv4BigInteger | .NET 9.0 | 3      |   455.47 ns |  85.562 ns | 4.690 ns |   452.01 ns |   460.81 ns | 0.0372 |     624 B |
| GetSubnetRangeIPv4Shift      | .NET 9.0 | 3      |    95.31 ns |  28.072 ns | 1.539 ns |    93.57 ns |    96.49 ns | 0.0315 |     528 B |
