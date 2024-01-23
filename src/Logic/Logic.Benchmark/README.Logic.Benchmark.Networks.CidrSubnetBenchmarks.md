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
| **GetNthSubnetIPv6**             | **1**      |   **495.62 ns** |  **42.174 ns** |  **2.312 ns** |   **493.73 ns** |   **498.20 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.78 ns |   2.921 ns |  0.160 ns |   113.66 ns |   113.96 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   244.16 ns |  49.784 ns |  2.729 ns |   241.06 ns |   246.19 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.49 ns |   2.748 ns |  0.151 ns |    42.32 ns |    42.60 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.67 ns |   6.427 ns |  0.352 ns |   146.31 ns |   147.02 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.71 ns |   4.730 ns |  0.259 ns |    39.48 ns |    39.99 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,184.32 ns** | **339.218 ns** | **18.594 ns** | **5,170.18 ns** | **5,205.38 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,200.30 ns | 233.139 ns | 12.779 ns | 1,189.24 ns | 1,214.29 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,398.87 ns |  80.279 ns |  4.400 ns | 2,395.36 ns | 2,403.81 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   428.16 ns |  55.207 ns |  3.026 ns |   425.27 ns |   431.31 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,424.06 ns |  94.320 ns |  5.170 ns | 1,418.56 ns | 1,428.82 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   396.59 ns |  21.396 ns |  1.173 ns |   395.24 ns |   397.37 ns | 0.0210 |    1760 B |
