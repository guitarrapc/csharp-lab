```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **471.04 ns** |    **69.574 ns** |   **3.814 ns** |   **467.56 ns** |   **475.11 ns** | **0.0081** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   108.11 ns |     3.206 ns |   0.176 ns |   107.92 ns |   108.25 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   212.79 ns |    27.802 ns |   1.524 ns |   211.52 ns |   214.48 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    38.24 ns |     7.869 ns |   0.431 ns |    37.85 ns |    38.70 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   138.70 ns |     6.478 ns |   0.355 ns |   138.43 ns |   139.10 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    36.46 ns |    11.595 ns |   0.636 ns |    35.99 ns |    37.18 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **4,865.39 ns** |   **252.322 ns** |  **13.831 ns** | **4,850.61 ns** | **4,878.02 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,344.64 ns | 2,534.331 ns | 138.915 ns | 1,262.33 ns | 1,505.02 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,153.62 ns |   128.374 ns |   7.037 ns | 2,146.13 ns | 2,160.09 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   387.70 ns |    36.346 ns |   1.992 ns |   385.46 ns |   389.26 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,314.53 ns |   210.969 ns |  11.564 ns | 1,306.19 ns | 1,327.73 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   390.16 ns |   373.100 ns |  20.451 ns |   366.57 ns |   402.84 ns | 0.0210 |    1760 B |
