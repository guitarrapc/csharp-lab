```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **565.79 ns** |  **47.642 ns** |  **2.611 ns** |   **563.47 ns** |   **568.62 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.56 ns |   0.943 ns |  0.052 ns |   114.50 ns |   114.60 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.46 ns |  22.096 ns |  1.211 ns |   236.49 ns |   238.82 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.99 ns |   2.610 ns |  0.143 ns |    42.88 ns |    43.15 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.54 ns |  23.564 ns |  1.292 ns |   140.06 ns |   142.41 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.34 ns |   6.183 ns |  0.339 ns |    40.00 ns |    40.68 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,620.65 ns** | **450.635 ns** | **24.701 ns** | **1,602.92 ns** | **1,648.86 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   354.99 ns |  12.662 ns |  0.694 ns |   354.35 ns |   355.73 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   738.84 ns |  42.232 ns |  2.315 ns |   737.20 ns |   741.49 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   130.45 ns |   9.764 ns |  0.535 ns |   129.85 ns |   130.86 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   436.58 ns |  52.688 ns |  2.888 ns |   433.32 ns |   438.82 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   124.57 ns |  42.856 ns |  2.349 ns |   122.29 ns |   126.98 ns | 0.0062 |     528 B |
