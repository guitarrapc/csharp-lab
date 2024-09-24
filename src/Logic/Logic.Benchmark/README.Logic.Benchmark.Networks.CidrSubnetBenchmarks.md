```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **507.26 ns** |  **14.466 ns** |  **0.793 ns** |   **506.44 ns** |   **508.03 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.66 ns |  89.609 ns |  4.912 ns |   113.69 ns |   122.33 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.21 ns |   3.589 ns |  0.197 ns |   242.04 ns |   242.42 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.19 ns |   4.131 ns |  0.226 ns |    42.97 ns |    43.42 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.18 ns |  64.760 ns |  3.550 ns |   141.70 ns |   148.24 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.84 ns |   6.490 ns |  0.356 ns |    39.47 ns |    40.18 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,587.67 ns** | **560.965 ns** | **30.748 ns** | **1,567.41 ns** | **1,623.05 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   372.05 ns |  18.657 ns |  1.023 ns |   371.21 ns |   373.19 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   743.08 ns |  18.846 ns |  1.033 ns |   742.14 ns |   744.18 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.27 ns |   1.480 ns |  0.081 ns |   127.20 ns |   127.36 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   447.83 ns |  15.892 ns |  0.871 ns |   447.14 ns |   448.81 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.93 ns |  16.431 ns |  0.901 ns |   118.35 ns |   119.96 ns | 0.0062 |     528 B |
