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
| **GetNthSubnetIPv6**             | **1**      |   **524.76 ns** |  **51.407 ns** |  **2.818 ns** |   **522.02 ns** |   **527.65 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.28 ns |   0.776 ns |  0.043 ns |   115.24 ns |   115.33 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   238.65 ns |  15.265 ns |  0.837 ns |   237.68 ns |   239.17 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.42 ns |   3.253 ns |  0.178 ns |    42.22 ns |    42.54 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.53 ns |  26.825 ns |  1.470 ns |   142.84 ns |   145.52 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.65 ns |   6.358 ns |  0.348 ns |    39.37 ns |    40.04 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,608.27 ns** | **414.090 ns** | **22.698 ns** | **1,593.05 ns** | **1,634.36 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   355.33 ns |  13.263 ns |  0.727 ns |   354.49 ns |   355.75 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   721.58 ns |  41.839 ns |  2.293 ns |   719.33 ns |   723.92 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.06 ns |  64.078 ns |  3.512 ns |   125.19 ns |   131.98 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   424.49 ns |  49.300 ns |  2.702 ns |   422.63 ns |   427.59 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.61 ns |   7.335 ns |  0.402 ns |   120.25 ns |   121.05 ns | 0.0062 |     528 B |
