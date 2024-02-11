```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **490.70 ns** |   **7.594 ns** |  **0.416 ns** |   **490.24 ns** |   **491.05 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.84 ns |   4.907 ns |  0.269 ns |   113.55 ns |   114.08 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   249.64 ns | 101.738 ns |  5.577 ns |   246.13 ns |   256.07 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.41 ns |   3.102 ns |  0.170 ns |    41.23 ns |    41.57 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.43 ns |  14.129 ns |  0.774 ns |   142.58 ns |   144.09 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.76 ns |   4.559 ns |  0.250 ns |    38.49 ns |    38.97 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,276.82 ns** | **151.578 ns** |  **8.308 ns** | **5,267.71 ns** | **5,283.97 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,159.20 ns | 286.976 ns | 15.730 ns | 1,141.09 ns | 1,169.45 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,356.33 ns |  82.705 ns |  4.533 ns | 2,352.86 ns | 2,361.46 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   417.30 ns |  26.046 ns |  1.428 ns |   416.20 ns |   418.91 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,491.75 ns | 743.042 ns | 40.729 ns | 1,466.53 ns | 1,538.74 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   393.00 ns |  58.014 ns |  3.180 ns |   389.37 ns |   395.26 ns | 0.0210 |    1760 B |
