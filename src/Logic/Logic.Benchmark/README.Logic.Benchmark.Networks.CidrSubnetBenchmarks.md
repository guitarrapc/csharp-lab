```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **513.35 ns** |  **33.581 ns** | **1.841 ns** |   **512.18 ns** |   **515.47 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.90 ns |   4.084 ns | 0.224 ns |   116.67 ns |   117.12 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   247.51 ns |  13.624 ns | 0.747 ns |   246.64 ns |   247.96 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.56 ns |   7.406 ns | 0.406 ns |    42.09 ns |    42.82 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   150.65 ns |  75.196 ns | 4.122 ns |   148.09 ns |   155.40 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.82 ns |   2.628 ns | 0.144 ns |    40.68 ns |    40.97 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,574.56 ns** | **102.923 ns** | **5.642 ns** | **1,568.09 ns** | **1,578.48 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   350.82 ns |  15.641 ns | 0.857 ns |   349.88 ns |   351.56 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   731.25 ns |  25.143 ns | 1.378 ns |   729.67 ns |   732.19 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.43 ns |   8.061 ns | 0.442 ns |   126.12 ns |   126.94 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   458.20 ns |  35.307 ns | 1.935 ns |   456.74 ns |   460.40 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   121.19 ns |  20.401 ns | 1.118 ns |   119.90 ns |   121.94 ns | 0.0062 |     528 B |
