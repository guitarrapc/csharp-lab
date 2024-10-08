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
| **GetNthSubnetIPv6**             | **1**      |   **511.25 ns** | **46.835 ns** | **2.567 ns** |   **508.44 ns** |   **513.48 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   115.56 ns |  8.002 ns | 0.439 ns |   115.26 ns |   116.06 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   235.60 ns | 13.648 ns | 0.748 ns |   234.73 ns |   236.04 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.63 ns |  7.456 ns | 0.409 ns |    42.16 ns |    42.90 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.16 ns |  9.552 ns | 0.524 ns |   140.76 ns |   141.76 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.97 ns |  9.497 ns | 0.521 ns |    39.39 ns |    40.41 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,646.03 ns** | **92.144 ns** | **5.051 ns** | **1,640.31 ns** | **1,649.89 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   377.61 ns | 39.722 ns | 2.177 ns |   375.57 ns |   379.90 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   718.87 ns | 18.809 ns | 1.031 ns |   717.68 ns |   719.55 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.50 ns | 18.230 ns | 0.999 ns |   124.64 ns |   126.60 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   438.64 ns | 10.424 ns | 0.571 ns |   437.98 ns |   438.97 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   121.95 ns | 11.284 ns | 0.619 ns |   121.34 ns |   122.58 ns | 0.0062 |     528 B |
