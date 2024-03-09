```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **501.40 ns** | **26.039 ns** | **1.427 ns** |   **499.78 ns** |   **502.47 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   111.98 ns |  4.303 ns | 0.236 ns |   111.77 ns |   112.23 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   239.68 ns | 50.157 ns | 2.749 ns |   237.51 ns |   242.77 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.91 ns |  4.828 ns | 0.265 ns |    44.63 ns |    45.16 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   139.37 ns |  3.894 ns | 0.213 ns |   139.18 ns |   139.60 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.51 ns |  2.429 ns | 0.133 ns |    39.37 ns |    39.63 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,633.71 ns** | **88.388 ns** | **4.845 ns** | **1,629.57 ns** | **1,639.04 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   342.27 ns |  7.216 ns | 0.396 ns |   341.82 ns |   342.52 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   717.30 ns | 29.252 ns | 1.603 ns |   715.49 ns |   718.52 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.45 ns | 21.500 ns | 1.179 ns |   122.72 ns |   124.81 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   428.92 ns | 39.311 ns | 2.155 ns |   427.05 ns |   431.28 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.24 ns |  8.486 ns | 0.465 ns |   115.86 ns |   116.76 ns | 0.0062 |     528 B |
