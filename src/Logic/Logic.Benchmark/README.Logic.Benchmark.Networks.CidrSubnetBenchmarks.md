```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **497.80 ns** |  **73.572 ns** |  **4.033 ns** |   **495.33 ns** |   **502.45 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.49 ns |   3.411 ns |  0.187 ns |   113.36 ns |   113.71 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   231.25 ns |   4.350 ns |  0.238 ns |   231.06 ns |   231.51 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.42 ns |   1.566 ns |  0.086 ns |    41.36 ns |    41.52 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.32 ns |   3.335 ns |  0.183 ns |   143.13 ns |   143.49 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.75 ns |   6.287 ns |  0.345 ns |    39.35 ns |    39.96 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,547.87 ns** | **457.349 ns** | **25.069 ns** | **1,530.08 ns** | **1,576.54 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.91 ns |  15.440 ns |  0.846 ns |   344.97 ns |   346.61 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   741.88 ns |  44.967 ns |  2.465 ns |   739.08 ns |   743.70 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   123.63 ns |   9.380 ns |  0.514 ns |   123.30 ns |   124.22 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   433.94 ns |   5.644 ns |  0.309 ns |   433.60 ns |   434.20 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.85 ns |  13.925 ns |  0.763 ns |   116.08 ns |   117.61 ns | 0.0062 |     528 B |
