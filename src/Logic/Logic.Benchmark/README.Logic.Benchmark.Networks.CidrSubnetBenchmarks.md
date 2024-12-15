```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **439.39 ns** | **36.667 ns** | **2.010 ns** |   **437.21 ns** |   **441.18 ns** | **0.0076** |     **640 B** |
| GetNthSubnetIPv4             | 1      |    99.06 ns |  9.049 ns | 0.496 ns |    98.56 ns |    99.56 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   244.25 ns | 36.287 ns | 1.989 ns |   242.81 ns |   246.52 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.30 ns |  4.819 ns | 0.264 ns |    43.13 ns |    43.60 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.75 ns |  3.140 ns | 0.172 ns |   146.56 ns |   146.87 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    34.92 ns | 11.880 ns | 0.651 ns |    34.48 ns |    35.66 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,399.66 ns** | **38.473 ns** | **2.109 ns** | **1,397.23 ns** | **1,401.03 ns** | **0.0229** |    **2000 B** |
| GetNthSubnetIPv4             | 3      |   291.90 ns |  7.840 ns | 0.430 ns |   291.57 ns |   292.38 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   726.57 ns | 51.097 ns | 2.801 ns |   723.89 ns |   729.48 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.08 ns | 18.439 ns | 1.011 ns |   126.36 ns |   128.23 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   436.84 ns | 42.289 ns | 2.318 ns |   434.17 ns |   438.35 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   103.07 ns | 34.441 ns | 1.888 ns |   101.68 ns |   105.22 ns | 0.0062 |     528 B |
