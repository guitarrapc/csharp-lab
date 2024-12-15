```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **560.23 ns** | **34.324 ns** | **1.881 ns** |   **558.26 ns** |   **562.01 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   119.82 ns |  8.411 ns | 0.461 ns |   119.45 ns |   120.34 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.11 ns |  6.327 ns | 0.347 ns |   235.73 ns |   236.41 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.95 ns |  6.071 ns | 0.333 ns |    42.70 ns |    43.33 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   144.85 ns | 11.760 ns | 0.645 ns |   144.17 ns |   145.45 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.65 ns |  5.891 ns | 0.323 ns |    40.32 ns |    40.97 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,600.05 ns** | **25.226 ns** | **1.383 ns** | **1,598.46 ns** | **1,600.99 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.61 ns |  5.244 ns | 0.287 ns |   346.28 ns |   346.79 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   754.08 ns | 43.515 ns | 2.385 ns |   752.01 ns |   756.69 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.04 ns | 16.000 ns | 0.877 ns |   127.26 ns |   128.99 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   453.03 ns | 68.297 ns | 3.744 ns |   448.92 ns |   456.26 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.79 ns | 18.489 ns | 1.013 ns |   121.66 ns |   123.63 ns | 0.0062 |     528 B |
