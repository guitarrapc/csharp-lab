```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **495.67 ns** |   **9.376 ns** | **0.514 ns** |   **495.26 ns** |   **496.25 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   117.11 ns |   1.833 ns | 0.100 ns |   117.02 ns |   117.22 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.00 ns |  13.461 ns | 0.738 ns |   233.57 ns |   234.85 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.44 ns |   0.894 ns | 0.049 ns |    41.39 ns |    41.49 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.67 ns |  16.779 ns | 0.920 ns |   144.87 ns |   146.67 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.23 ns |   7.229 ns | 0.396 ns |    38.97 ns |    39.69 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,631.71 ns** | **156.586 ns** | **8.583 ns** | **1,621.87 ns** | **1,637.64 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   348.58 ns |  15.888 ns | 0.871 ns |   347.94 ns |   349.57 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   726.42 ns |  33.582 ns | 1.841 ns |   724.33 ns |   727.79 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   124.32 ns |  21.937 ns | 1.202 ns |   123.50 ns |   125.70 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   439.38 ns |  23.251 ns | 1.274 ns |   438.65 ns |   440.86 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   116.44 ns |   1.349 ns | 0.074 ns |   116.37 ns |   116.52 ns | 0.0062 |     528 B |
