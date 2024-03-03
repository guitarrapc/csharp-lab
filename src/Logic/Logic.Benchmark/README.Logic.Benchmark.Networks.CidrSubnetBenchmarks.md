```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **510.57 ns** |  **38.505 ns** |  **2.111 ns** |   **508.73 ns** |   **512.87 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.62 ns |  22.192 ns |  1.216 ns |   113.85 ns |   116.02 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   247.93 ns | 107.082 ns |  5.870 ns |   244.07 ns |   254.68 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.58 ns |   1.709 ns |  0.094 ns |    42.48 ns |    42.66 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.44 ns |   4.262 ns |  0.234 ns |   143.18 ns |   143.64 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.14 ns |   2.617 ns |  0.143 ns |    39.98 ns |    40.26 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,110.88 ns** | **334.579 ns** | **18.339 ns** | **5,098.54 ns** | **5,131.96 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,152.78 ns | 206.988 ns | 11.346 ns | 1,145.62 ns | 1,165.86 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,392.08 ns |  44.963 ns |  2.465 ns | 2,390.29 ns | 2,394.89 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   422.48 ns |  27.655 ns |  1.516 ns |   421.07 ns |   424.09 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,449.98 ns |  44.780 ns |  2.455 ns | 1,448.44 ns | 1,452.81 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   398.64 ns |  70.309 ns |  3.854 ns |   394.20 ns |   401.07 ns | 0.0210 |    1760 B |
