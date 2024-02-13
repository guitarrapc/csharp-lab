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
| **GetNthSubnetIPv6**             | **1**      |   **483.73 ns** | **159.457 ns** |  **8.740 ns** |   **476.66 ns** |   **493.50 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   110.22 ns |  17.784 ns |  0.975 ns |   109.10 ns |   110.90 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.42 ns |  11.381 ns |  0.624 ns |   232.81 ns |   234.06 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.17 ns |   8.561 ns |  0.469 ns |    40.64 ns |    41.55 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   149.84 ns |  69.007 ns |  3.783 ns |   147.13 ns |   154.16 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.18 ns |   1.461 ns |  0.080 ns |    39.12 ns |    39.27 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,119.50 ns** | **724.659 ns** | **39.721 ns** | **5,096.22 ns** | **5,165.37 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,161.11 ns | 299.941 ns | 16.441 ns | 1,144.93 ns | 1,177.80 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,296.75 ns | 300.526 ns | 16.473 ns | 2,278.91 ns | 2,311.38 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   419.43 ns |  79.488 ns |  4.357 ns |   416.79 ns |   424.46 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,470.77 ns | 367.686 ns | 20.154 ns | 1,451.27 ns | 1,491.52 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   375.11 ns | 112.564 ns |  6.170 ns |   371.22 ns |   382.23 ns | 0.0210 |    1760 B |
