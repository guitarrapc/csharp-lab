```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **538.82 ns** |  **45.117 ns** | **2.473 ns** |   **535.98 ns** |   **540.50 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.94 ns |   4.235 ns | 0.232 ns |   114.71 ns |   115.18 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.21 ns |  14.705 ns | 0.806 ns |   241.68 ns |   243.14 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.95 ns |   1.090 ns | 0.060 ns |    41.89 ns |    42.00 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   147.51 ns |  10.124 ns | 0.555 ns |   147.14 ns |   148.15 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.37 ns |   4.848 ns | 0.266 ns |    39.12 ns |    39.65 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,593.76 ns** |  **57.642 ns** | **3.160 ns** | **1,591.93 ns** | **1,597.41 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   355.84 ns | 163.310 ns | 8.952 ns |   350.25 ns |   366.16 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   735.82 ns |  17.507 ns | 0.960 ns |   734.73 ns |   736.54 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   136.69 ns |  14.694 ns | 0.805 ns |   135.91 ns |   137.52 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   422.44 ns | 110.833 ns | 6.075 ns |   418.53 ns |   429.44 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.07 ns |   7.534 ns | 0.413 ns |   117.60 ns |   118.33 ns | 0.0062 |     528 B |
