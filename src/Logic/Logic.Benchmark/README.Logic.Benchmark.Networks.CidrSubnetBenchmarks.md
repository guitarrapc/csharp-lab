```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|--------------------------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **CidrSubnetCalculateSubnetRangeIPv6BigInteger** | **1**      |   **243.79 ns** |  **5.328 ns** | **0.292 ns** |   **243.57 ns** |   **244.12 ns** | **0.0048** |     **432 B** |
| CidrSubnetCalculateSubnetRangeIPv6Shift      | 1      |    42.50 ns |  2.888 ns | 0.158 ns |    42.34 ns |    42.66 ns | 0.0019 |     160 B |
| CidrSubnetCalculateSubnetRangeIPv4BigInteger | 1      |   152.86 ns |  3.606 ns | 0.198 ns |   152.64 ns |   153.01 ns | 0.0024 |     208 B |
| CidrSubnetCalculateSubnetRangeIPv4Shift      | 1      |    40.55 ns |  2.616 ns | 0.143 ns |    40.40 ns |    40.68 ns | 0.0021 |     176 B |
| **CidrSubnetCalculateSubnetRangeIPv6BigInteger** | **10**     | **2,433.43 ns** | **60.090 ns** | **3.294 ns** | **2,431.22 ns** | **2,437.21 ns** | **0.0496** |    **4320 B** |
| CidrSubnetCalculateSubnetRangeIPv6Shift      | 10     |   430.54 ns | 74.734 ns | 4.096 ns |   426.01 ns |   433.99 ns | 0.0191 |    1600 B |
| CidrSubnetCalculateSubnetRangeIPv4BigInteger | 10     | 1,503.23 ns | 28.223 ns | 1.547 ns | 1,502.29 ns | 1,505.01 ns | 0.0248 |    2080 B |
| CidrSubnetCalculateSubnetRangeIPv4Shift      | 10     |   400.33 ns | 18.545 ns | 1.017 ns |   399.22 ns |   401.20 ns | 0.0210 |    1760 B |
