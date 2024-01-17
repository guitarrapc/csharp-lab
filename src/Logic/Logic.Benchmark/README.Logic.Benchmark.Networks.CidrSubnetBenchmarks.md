```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|--------------------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **1**      |   **239.55 ns** |  **16.440 ns** |  **0.901 ns** |   **238.55 ns** |   **240.30 ns** | **0.0048** |     **432 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 1      |    41.36 ns |   6.166 ns |  0.338 ns |    40.97 ns |    41.57 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 1      |   146.73 ns |   6.910 ns |  0.379 ns |   146.31 ns |   147.05 ns | 0.0024 |     208 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 1      |    39.48 ns |   5.539 ns |  0.304 ns |    39.29 ns |    39.83 ns | 0.0021 |     176 B |
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **10**     | **2,316.32 ns** | **114.633 ns** |  **6.283 ns** | **2,309.25 ns** | **2,321.27 ns** | **0.0496** |    **4320 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 10     |   426.55 ns |  64.990 ns |  3.562 ns |   422.83 ns |   429.93 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 10     | 1,475.12 ns | 357.973 ns | 19.622 ns | 1,463.41 ns | 1,497.77 ns | 0.0248 |    2080 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 10     |   400.92 ns |  26.331 ns |  1.443 ns |   399.25 ns |   401.77 ns | 0.0210 |    1760 B |
