```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **508.99 ns** |  **54.775 ns** | **3.002 ns** |   **505.58 ns** |   **511.25 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.25 ns |   3.155 ns | 0.173 ns |   112.06 ns |   112.40 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.11 ns |  13.098 ns | 0.718 ns |   236.68 ns |   237.94 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.00 ns |   8.625 ns | 0.473 ns |    40.70 ns |    41.55 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.48 ns |  23.327 ns | 1.279 ns |   142.08 ns |   144.58 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.86 ns |   5.816 ns | 0.319 ns |    39.67 ns |    40.22 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,560.30 ns** | **102.945 ns** | **5.643 ns** | **1,554.54 ns** | **1,565.82 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.73 ns |  30.888 ns | 1.693 ns |   344.85 ns |   348.15 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   731.07 ns |  19.525 ns | 1.070 ns |   730.41 ns |   732.30 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.89 ns |  12.784 ns | 0.701 ns |   124.41 ns |   125.70 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   435.46 ns |  51.120 ns | 2.802 ns |   432.27 ns |   437.52 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.48 ns |   6.471 ns | 0.355 ns |   116.12 ns |   116.82 ns | 0.0062 |     528 B |
