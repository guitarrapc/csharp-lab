```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **524.97 ns** |  **43.373 ns** | **2.377 ns** |   **522.68 ns** |   **527.43 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.54 ns |   4.768 ns | 0.261 ns |   115.25 ns |   115.76 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   228.83 ns |  44.266 ns | 2.426 ns |   227.41 ns |   231.63 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.89 ns |   4.941 ns | 0.271 ns |    41.58 ns |    42.07 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   150.90 ns |  24.520 ns | 1.344 ns |   149.61 ns |   152.29 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.41 ns |   5.217 ns | 0.286 ns |    39.08 ns |    39.58 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,544.35 ns** |  **74.811 ns** | **4.101 ns** | **1,540.55 ns** | **1,548.70 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   354.42 ns |   5.649 ns | 0.310 ns |   354.21 ns |   354.78 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   764.35 ns | 161.469 ns | 8.851 ns |   758.92 ns |   774.56 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.25 ns |  16.642 ns | 0.912 ns |   123.20 ns |   124.86 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   424.82 ns |  34.724 ns | 1.903 ns |   422.70 ns |   426.39 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   115.82 ns |  16.585 ns | 0.909 ns |   115.14 ns |   116.85 ns | 0.0062 |     528 B |
