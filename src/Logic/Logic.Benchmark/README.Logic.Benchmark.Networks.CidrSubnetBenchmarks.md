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
| **GetNthSubnetIPv6**             | **1**      |   **494.30 ns** |  **29.690 ns** |  **1.627 ns** |   **492.57 ns** |   **495.80 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.65 ns |   3.318 ns |  0.182 ns |   113.49 ns |   113.85 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   231.48 ns |  20.675 ns |  1.133 ns |   230.17 ns |   232.20 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.73 ns |   3.962 ns |  0.217 ns |    41.53 ns |    41.96 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.56 ns |  18.475 ns |  1.013 ns |   145.40 ns |   147.27 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.77 ns |   8.818 ns |  0.483 ns |    39.48 ns |    40.32 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,213.85 ns** | **151.728 ns** |  **8.317 ns** | **5,208.30 ns** | **5,223.41 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,163.69 ns | 193.458 ns | 10.604 ns | 1,151.74 ns | 1,171.96 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,337.44 ns | 253.521 ns | 13.896 ns | 2,329.24 ns | 2,353.49 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   422.86 ns | 104.957 ns |  5.753 ns |   416.24 ns |   426.62 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,419.08 ns |  76.286 ns |  4.181 ns | 1,416.64 ns | 1,423.90 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   387.98 ns |  10.799 ns |  0.592 ns |   387.30 ns |   388.36 ns | 0.0210 |    1760 B |
