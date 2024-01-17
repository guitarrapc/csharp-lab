```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|--------------------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **CidrSubnetGetNthSubnetIPv6**             | **1**      |   **529.78 ns** |    **16.898 ns** |   **0.926 ns** |   **528.88 ns** |   **530.73 ns** | **0.0076** |     **696 B** |
| CidrSubnetGetNthSubnetIPv4             | 1      |   113.09 ns |     3.296 ns |   0.181 ns |   112.88 ns |   113.22 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv6BigInteger | 1      |   234.10 ns |     5.844 ns |   0.320 ns |   233.73 ns |   234.31 ns | 0.0050 |     432 B |
| CidrSubnetGetSubnetRangeIPv6Shift      | 1      |    42.26 ns |     1.340 ns |   0.073 ns |    42.21 ns |    42.35 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 1      |   144.93 ns |     9.350 ns |   0.513 ns |   144.60 ns |   145.52 ns | 0.0024 |     208 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 1      |    45.27 ns |     4.493 ns |   0.246 ns |    45.09 ns |    45.55 ns | 0.0021 |     176 B |
| **CidrSubnetGetNthSubnetIPv6**             | **10**     | **5,397.24 ns** | **7,276.651 ns** | **398.858 ns** | **5,164.70 ns** | **5,857.80 ns** | **0.0839** |    **7336 B** |
| CidrSubnetGetNthSubnetIPv4             | 10     | 1,158.80 ns |    43.982 ns |   2.411 ns | 1,156.36 ns | 1,161.18 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv6BigInteger | 10     | 2,345.46 ns |    57.448 ns |   3.149 ns | 2,342.97 ns | 2,349.00 ns | 0.0496 |    4320 B |
| CidrSubnetGetSubnetRangeIPv6Shift      | 10     |   419.36 ns |    73.809 ns |   4.046 ns |   414.69 ns |   421.87 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 10     | 1,552.62 ns |    70.666 ns |   3.873 ns | 1,548.40 ns | 1,556.01 ns | 0.0248 |    2080 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 10     |   405.06 ns |    35.468 ns |   1.944 ns |   402.83 ns |   406.39 ns | 0.0210 |    1760 B |
