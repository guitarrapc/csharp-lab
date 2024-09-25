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
| **GetNthSubnetIPv6**             | **1**      |   **506.57 ns** | **73.567 ns** | **4.032 ns** |   **504.11 ns** |   **511.23 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.97 ns |  6.087 ns | 0.334 ns |   115.73 ns |   116.35 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   237.31 ns |  5.978 ns | 0.328 ns |   236.95 ns |   237.59 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.81 ns |  1.677 ns | 0.092 ns |    43.73 ns |    43.91 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.49 ns |  6.909 ns | 0.379 ns |   146.15 ns |   146.89 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    41.25 ns |  4.281 ns | 0.235 ns |    41.00 ns |    41.45 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,645.81 ns** | **45.733 ns** | **2.507 ns** | **1,642.93 ns** | **1,647.49 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   370.02 ns |  3.779 ns | 0.207 ns |   369.78 ns |   370.17 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   729.01 ns | 25.961 ns | 1.423 ns |   727.59 ns |   730.44 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   131.36 ns | 13.520 ns | 0.741 ns |   130.60 ns |   132.09 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   433.00 ns | 33.781 ns | 1.852 ns |   431.35 ns |   435.00 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   123.72 ns | 15.742 ns | 0.863 ns |   122.73 ns |   124.32 ns | 0.0062 |     528 B |
