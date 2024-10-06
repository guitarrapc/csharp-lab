```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **508.78 ns** | **28.274 ns** | **1.550 ns** |   **507.20 ns** |   **510.29 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.80 ns |  0.559 ns | 0.031 ns |   117.76 ns |   117.82 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   246.29 ns | 12.923 ns | 0.708 ns |   245.58 ns |   247.00 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.88 ns |  5.472 ns | 0.300 ns |    42.57 ns |    43.16 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.32 ns |  2.615 ns | 0.143 ns |   143.23 ns |   143.48 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.91 ns | 22.545 ns | 1.236 ns |    40.08 ns |    42.33 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,632.12 ns** | **45.934 ns** | **2.518 ns** | **1,629.25 ns** | **1,633.92 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   351.38 ns |  4.281 ns | 0.235 ns |   351.11 ns |   351.53 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   740.88 ns | 13.154 ns | 0.721 ns |   740.18 ns |   741.62 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.72 ns |  5.672 ns | 0.311 ns |   127.44 ns |   128.05 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   447.36 ns | 55.940 ns | 3.066 ns |   444.42 ns |   450.54 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   119.30 ns | 13.751 ns | 0.754 ns |   118.53 ns |   120.03 ns | 0.0062 |     528 B |
