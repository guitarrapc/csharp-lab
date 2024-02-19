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
| **GetNthSubnetIPv6**             | **1**      |   **502.56 ns** | **239.207 ns** | **13.112 ns** |   **494.27 ns** |   **517.68 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.01 ns |   1.984 ns |  0.109 ns |   112.93 ns |   113.13 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.73 ns |  33.575 ns |  1.840 ns |   241.25 ns |   244.79 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.70 ns |   7.343 ns |  0.403 ns |    41.46 ns |    42.16 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.18 ns |  17.271 ns |  0.947 ns |   144.35 ns |   146.21 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.80 ns |  35.171 ns |  1.928 ns |    38.48 ns |    42.01 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,332.97 ns** | **252.026 ns** | **13.814 ns** | **5,320.02 ns** | **5,347.51 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,163.39 ns | 131.250 ns |  7.194 ns | 1,159.13 ns | 1,171.69 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,836.10 ns |  41.585 ns |  2.279 ns | 2,833.57 ns | 2,837.98 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   424.31 ns |  28.783 ns |  1.578 ns |   422.58 ns |   425.67 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,487.86 ns | 118.710 ns |  6.507 ns | 1,483.91 ns | 1,495.37 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   396.87 ns |  75.278 ns |  4.126 ns |   392.52 ns |   400.72 ns | 0.0210 |    1760 B |
