```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **527.79 ns** | **144.163 ns** |  **7.902 ns** |   **518.68 ns** |   **532.84 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.54 ns |   6.251 ns |  0.343 ns |   114.15 ns |   114.80 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.87 ns |  19.421 ns |  1.065 ns |   234.06 ns |   236.07 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.89 ns |   3.792 ns |  0.208 ns |    42.70 ns |    43.11 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.95 ns |   5.079 ns |  0.278 ns |   145.72 ns |   146.26 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.46 ns |   2.881 ns |  0.158 ns |    39.30 ns |    39.61 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,678.56 ns** | **408.480 ns** | **22.390 ns** | **1,664.59 ns** | **1,704.39 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   342.09 ns |   2.800 ns |  0.153 ns |   341.99 ns |   342.26 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   733.36 ns |  52.948 ns |  2.902 ns |   730.26 ns |   736.02 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.76 ns |  10.739 ns |  0.589 ns |   124.13 ns |   125.30 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   448.94 ns |   3.768 ns |  0.207 ns |   448.78 ns |   449.17 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.19 ns |   3.432 ns |  0.188 ns |   119.98 ns |   120.34 ns | 0.0062 |     528 B |
