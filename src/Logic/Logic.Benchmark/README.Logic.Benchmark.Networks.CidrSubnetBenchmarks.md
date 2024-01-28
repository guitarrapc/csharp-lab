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
| **GetNthSubnetIPv6**             | **1**      |   **513.13 ns** |  **26.596 ns** |  **1.458 ns** |   **512.08 ns** |   **514.79 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.14 ns |   3.263 ns |  0.179 ns |   113.03 ns |   113.35 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   229.71 ns |  14.421 ns |  0.790 ns |   228.82 ns |   230.35 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.06 ns |   3.521 ns |  0.193 ns |    41.91 ns |    42.27 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.47 ns |   2.635 ns |  0.144 ns |   145.33 ns |   145.62 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.22 ns |   2.614 ns |  0.143 ns |    39.05 ns |    39.32 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,275.93 ns** | **915.475 ns** | **50.180 ns** | **5,238.89 ns** | **5,333.04 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,188.63 ns | 483.520 ns | 26.503 ns | 1,158.04 ns | 1,204.52 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,410.95 ns |  92.005 ns |  5.043 ns | 2,406.81 ns | 2,416.57 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   422.79 ns |  32.906 ns |  1.804 ns |   421.00 ns |   424.61 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,517.45 ns |  28.488 ns |  1.562 ns | 1,516.30 ns | 1,519.23 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   396.93 ns |  25.979 ns |  1.424 ns |   395.83 ns |   398.54 ns | 0.0210 |    1760 B |
