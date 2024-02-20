```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **500.06 ns** |  **19.401 ns** |  **1.063 ns** |   **498.85 ns** |   **500.83 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.18 ns |   3.480 ns |  0.191 ns |   112.99 ns |   113.37 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.40 ns |  15.113 ns |  0.828 ns |   231.82 ns |   233.35 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.46 ns |   9.895 ns |  0.542 ns |    41.06 ns |    42.08 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   137.25 ns |   5.832 ns |  0.320 ns |   137.00 ns |   137.61 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.18 ns |   7.121 ns |  0.390 ns |    38.91 ns |    39.63 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,088.37 ns** | **188.155 ns** | **10.313 ns** | **5,076.53 ns** | **5,095.40 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,155.12 ns | 288.937 ns | 15.838 ns | 1,136.94 ns | 1,165.92 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,333.00 ns |  47.763 ns |  2.618 ns | 2,329.98 ns | 2,334.51 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   416.47 ns |  57.876 ns |  3.172 ns |   413.41 ns |   419.74 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,429.11 ns | 189.973 ns | 10.413 ns | 1,420.74 ns | 1,440.77 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   404.01 ns | 391.784 ns | 21.475 ns |   379.23 ns |   417.22 ns | 0.0210 |    1760 B |
