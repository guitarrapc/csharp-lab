```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|--------------------------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **CidrSubnetCalculateSubnetRangeIPv6BigInteger** | **1**      |   **235.34 ns** |   **0.796 ns** | **0.044 ns** |   **235.30 ns** |   **235.39 ns** | **0.0050** |     **432 B** |
| CidrSubnetCalculateSubnetRangeIPv6Shift      | 1      |    40.94 ns |   7.637 ns | 0.419 ns |    40.67 ns |    41.42 ns | 0.0019 |     160 B |
| CidrSubnetCalculateSubnetRangeIPv4BigInteger | 1      |   146.42 ns |  11.378 ns | 0.624 ns |   145.89 ns |   147.11 ns | 0.0024 |     208 B |
| CidrSubnetCalculateSubnetRangeIPv4Shift      | 1      |    38.45 ns |   3.768 ns | 0.207 ns |    38.32 ns |    38.69 ns | 0.0021 |     176 B |
| **CidrSubnetCalculateSubnetRangeIPv6BigInteger** | **10**     | **2,456.43 ns** | **139.284 ns** | **7.635 ns** | **2,449.39 ns** | **2,464.54 ns** | **0.0496** |    **4320 B** |
| CidrSubnetCalculateSubnetRangeIPv6Shift      | 10     |   420.18 ns | 120.425 ns | 6.601 ns |   415.70 ns |   427.76 ns | 0.0191 |    1600 B |
| CidrSubnetCalculateSubnetRangeIPv4BigInteger | 10     | 1,484.03 ns | 143.613 ns | 7.872 ns | 1,476.60 ns | 1,492.28 ns | 0.0248 |    2080 B |
| CidrSubnetCalculateSubnetRangeIPv4Shift      | 10     |   418.55 ns |  15.782 ns | 0.865 ns |   417.61 ns |   419.31 ns | 0.0210 |    1760 B |
