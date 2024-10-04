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
| **GetNthSubnetIPv6**             | **1**      |   **528.34 ns** | **73.248 ns** | **4.015 ns** |   **525.01 ns** |   **532.80 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.81 ns | 14.776 ns | 0.810 ns |   117.21 ns |   118.73 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   242.42 ns |  8.731 ns | 0.479 ns |   242.03 ns |   242.95 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.33 ns | 11.937 ns | 0.654 ns |    43.84 ns |    45.07 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.93 ns |  8.704 ns | 0.477 ns |   145.45 ns |   146.40 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.52 ns |  6.638 ns | 0.364 ns |    40.14 ns |    40.87 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,581.63 ns** | **52.872 ns** | **2.898 ns** | **1,578.37 ns** | **1,583.93 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   352.43 ns | 35.697 ns | 1.957 ns |   350.68 ns |   354.54 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   738.11 ns | 95.661 ns | 5.243 ns |   733.08 ns |   743.54 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.66 ns |  4.194 ns | 0.230 ns |   128.44 ns |   128.90 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   444.37 ns | 27.352 ns | 1.499 ns |   442.96 ns |   445.94 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.86 ns | 13.249 ns | 0.726 ns |   120.05 ns |   121.45 ns | 0.0062 |     528 B |
