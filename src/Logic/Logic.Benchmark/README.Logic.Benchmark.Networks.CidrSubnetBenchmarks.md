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
| **GetNthSubnetIPv6**             | **1**      |   **507.21 ns** |  **11.835 ns** |  **0.649 ns** |   **506.60 ns** |   **507.89 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.92 ns |   3.182 ns |  0.174 ns |   115.72 ns |   116.05 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.98 ns |  43.929 ns |  2.408 ns |   241.00 ns |   245.66 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.72 ns |   1.883 ns |  0.103 ns |    41.60 ns |    41.79 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   140.24 ns |  40.856 ns |  2.239 ns |   138.88 ns |   142.83 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.37 ns |   4.035 ns |  0.221 ns |    39.24 ns |    39.63 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,640.51 ns** | **363.553 ns** | **19.928 ns** | **1,628.28 ns** | **1,663.50 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   355.41 ns |   1.850 ns |  0.101 ns |   355.32 ns |   355.52 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   735.62 ns |   4.677 ns |  0.256 ns |   735.37 ns |   735.88 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.95 ns |   4.138 ns |  0.227 ns |   128.71 ns |   129.16 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   431.04 ns |  14.361 ns |  0.787 ns |   430.13 ns |   431.59 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   121.54 ns |   8.447 ns |  0.463 ns |   121.11 ns |   122.03 ns | 0.0062 |     528 B |
