```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **489.82 ns** | **27.937 ns** | **1.531 ns** |   **488.14 ns** |   **491.14 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.06 ns |  7.021 ns | 0.385 ns |   113.78 ns |   114.50 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.60 ns |  9.869 ns | 0.541 ns |   233.04 ns |   234.12 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.89 ns |  5.047 ns | 0.277 ns |    41.57 ns |    42.08 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.18 ns |  5.822 ns | 0.319 ns |   143.88 ns |   144.52 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.18 ns |  3.309 ns | 0.181 ns |    38.98 ns |    39.35 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,586.90 ns** | **55.990 ns** | **3.069 ns** | **1,584.82 ns** | **1,590.43 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.82 ns | 21.229 ns | 1.164 ns |   347.85 ns |   350.11 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   760.37 ns | 19.676 ns | 1.078 ns |   759.49 ns |   761.57 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.23 ns | 14.954 ns | 0.820 ns |   123.29 ns |   124.79 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   418.41 ns | 23.009 ns | 1.261 ns |   417.63 ns |   419.87 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.60 ns | 26.328 ns | 1.443 ns |   115.64 ns |   118.26 ns | 0.0062 |     528 B |
