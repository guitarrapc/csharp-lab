```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **500.83 ns** |    **25.233 ns** |   **1.383 ns** |   **499.35 ns** |   **502.09 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.99 ns |     3.592 ns |   0.197 ns |   112.83 ns |   113.21 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   241.89 ns |     7.242 ns |   0.397 ns |   241.47 ns |   242.25 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.61 ns |     4.259 ns |   0.233 ns |    42.34 ns |    42.75 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.92 ns |    18.520 ns |   1.015 ns |   143.15 ns |   145.07 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.80 ns |     5.754 ns |   0.315 ns |    39.49 ns |    40.12 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,394.39 ns** | **2,800.005 ns** | **153.478 ns** | **5,217.66 ns** | **5,494.14 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,185.58 ns |   673.649 ns |  36.925 ns | 1,160.48 ns | 1,227.98 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,351.09 ns |   116.032 ns |   6.360 ns | 2,345.18 ns | 2,357.82 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   432.41 ns |   139.264 ns |   7.634 ns |   425.07 ns |   440.31 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,615.17 ns |   398.746 ns |  21.857 ns | 1,590.88 ns | 1,633.25 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   396.76 ns |    64.582 ns |   3.540 ns |   393.52 ns |   400.54 ns | 0.0210 |    1760 B |
