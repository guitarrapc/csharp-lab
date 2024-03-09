```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **498.13 ns** | **75.197 ns** | **4.122 ns** |   **495.53 ns** |   **502.88 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.28 ns |  4.912 ns | 0.269 ns |   114.97 ns |   115.44 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.47 ns | 18.725 ns | 1.026 ns |   234.51 ns |   236.55 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.26 ns |  2.008 ns | 0.110 ns |    42.16 ns |    42.38 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   143.39 ns |  5.354 ns | 0.293 ns |   143.14 ns |   143.71 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.45 ns |  4.292 ns | 0.235 ns |    39.27 ns |    39.71 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,536.52 ns** | **98.485 ns** | **5.398 ns** | **1,532.73 ns** | **1,542.70 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   354.20 ns | 11.097 ns | 0.608 ns |   353.70 ns |   354.88 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   710.87 ns | 17.530 ns | 0.961 ns |   709.87 ns |   711.79 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.86 ns |  4.378 ns | 0.240 ns |   127.70 ns |   128.14 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   426.96 ns | 13.250 ns | 0.726 ns |   426.13 ns |   427.48 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   120.11 ns | 39.689 ns | 2.175 ns |   118.54 ns |   122.60 ns | 0.0062 |     528 B |
