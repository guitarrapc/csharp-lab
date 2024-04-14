```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **523.36 ns** | **38.396 ns** | **2.105 ns** |   **520.99 ns** |   **525.00 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.06 ns | 25.605 ns | 1.403 ns |   115.87 ns |   118.61 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   240.47 ns | 11.036 ns | 0.605 ns |   239.99 ns |   241.15 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.34 ns |  2.243 ns | 0.123 ns |    42.20 ns |    42.43 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.61 ns | 22.683 ns | 1.243 ns |   143.18 ns |   145.47 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.10 ns |  3.521 ns | 0.193 ns |    39.98 ns |    40.32 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,566.50 ns** | **43.888 ns** | **2.406 ns** | **1,563.73 ns** | **1,568.08 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   356.50 ns | 20.631 ns | 1.131 ns |   355.78 ns |   357.80 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   746.33 ns | 62.004 ns | 3.399 ns |   743.13 ns |   749.90 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   130.51 ns | 52.902 ns | 2.900 ns |   128.73 ns |   133.86 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   435.79 ns | 24.485 ns | 1.342 ns |   434.64 ns |   437.27 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.03 ns |  3.250 ns | 0.178 ns |   121.85 ns |   122.20 ns | 0.0062 |     528 B |
