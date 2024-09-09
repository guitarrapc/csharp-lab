```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **504.60 ns** |  **44.968 ns** |  **2.465 ns** |   **502.31 ns** |   **507.21 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.42 ns |   7.326 ns |  0.402 ns |   113.09 ns |   113.87 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.14 ns |   4.456 ns |  0.244 ns |   236.87 ns |   237.35 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.54 ns |   5.664 ns |  0.310 ns |    43.28 ns |    43.89 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.48 ns |   5.176 ns |  0.284 ns |   141.32 ns |   141.81 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.36 ns |   5.376 ns |  0.295 ns |    40.07 ns |    40.66 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,619.22 ns** |  **36.817 ns** |  **2.018 ns** | **1,616.89 ns** | **1,620.50 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   370.51 ns | 296.855 ns | 16.272 ns |   361.07 ns |   389.30 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   746.35 ns |  35.322 ns |  1.936 ns |   744.57 ns |   748.41 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.85 ns |  22.292 ns |  1.222 ns |   126.14 ns |   128.26 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   431.40 ns |  17.698 ns |  0.970 ns |   430.49 ns |   432.42 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   136.46 ns |   6.559 ns |  0.360 ns |   136.07 ns |   136.78 ns | 0.0062 |     528 B |
