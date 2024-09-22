```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **532.54 ns** |  **19.659 ns** |  **1.078 ns** |   **531.82 ns** |   **533.78 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.68 ns |   6.531 ns |  0.358 ns |   112.35 ns |   113.06 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.27 ns |  37.560 ns |  2.059 ns |   234.11 ns |   238.22 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.68 ns |   3.117 ns |  0.171 ns |    41.50 ns |    41.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   147.40 ns |  21.314 ns |  1.168 ns |   146.28 ns |   148.61 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.33 ns |   1.887 ns |  0.103 ns |    39.24 ns |    39.44 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,610.85 ns** | **211.498 ns** | **11.593 ns** | **1,602.01 ns** | **1,623.97 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   356.26 ns |   7.059 ns |  0.387 ns |   355.87 ns |   356.65 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   705.22 ns | 110.794 ns |  6.073 ns |   698.34 ns |   709.82 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.25 ns |  26.810 ns |  1.470 ns |   123.15 ns |   125.92 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   427.31 ns |  72.157 ns |  3.955 ns |   423.89 ns |   431.64 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.14 ns |  13.955 ns |  0.765 ns |   115.70 ns |   117.03 ns | 0.0062 |     528 B |
