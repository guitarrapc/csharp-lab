```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **498.86 ns** | **167.494 ns** | **9.181 ns** |   **493.51 ns** |   **509.46 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.32 ns |   5.371 ns | 0.294 ns |   113.15 ns |   113.66 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.99 ns |   2.957 ns | 0.162 ns |   237.81 ns |   238.12 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.12 ns |   1.403 ns | 0.077 ns |    44.07 ns |    44.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   147.32 ns |  43.176 ns | 2.367 ns |   145.83 ns |   150.04 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.00 ns |   1.721 ns | 0.094 ns |    38.91 ns |    39.10 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,562.21 ns** | **142.243 ns** | **7.797 ns** | **1,553.23 ns** | **1,567.24 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   344.61 ns |  14.096 ns | 0.773 ns |   343.74 ns |   345.21 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   704.26 ns |  73.381 ns | 4.022 ns |   701.70 ns |   708.90 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.29 ns |   7.804 ns | 0.428 ns |   122.80 ns |   123.60 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   431.60 ns |  36.509 ns | 2.001 ns |   430.42 ns |   433.91 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.60 ns |   0.540 ns | 0.030 ns |   117.57 ns |   117.63 ns | 0.0062 |     528 B |
