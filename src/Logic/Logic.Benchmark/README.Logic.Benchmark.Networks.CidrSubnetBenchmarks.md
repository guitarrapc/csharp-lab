```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **524.88 ns** | **247.076 ns** | **13.543 ns** |   **514.51 ns** |   **540.20 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.65 ns |   5.730 ns |  0.314 ns |   116.29 ns |   116.87 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.77 ns |  23.492 ns |  1.288 ns |   232.70 ns |   235.20 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.44 ns |   0.422 ns |  0.023 ns |    42.42 ns |    42.47 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.07 ns |  34.672 ns |  1.900 ns |   141.88 ns |   145.20 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    44.99 ns |   4.604 ns |  0.252 ns |    44.72 ns |    45.22 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,585.15 ns** |  **19.055 ns** |  **1.044 ns** | **1,584.03 ns** | **1,586.09 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.85 ns |   6.925 ns |  0.380 ns |   348.48 ns |   349.24 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   754.62 ns | 317.714 ns | 17.415 ns |   744.45 ns |   774.73 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.28 ns |  13.277 ns |  0.728 ns |   126.81 ns |   128.12 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   441.69 ns |  51.606 ns |  2.829 ns |   438.90 ns |   444.56 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   119.57 ns |  33.591 ns |  1.841 ns |   118.47 ns |   121.70 ns | 0.0062 |     528 B |
