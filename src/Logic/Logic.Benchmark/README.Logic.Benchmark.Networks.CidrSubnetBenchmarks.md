```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **502.33 ns** |   **5.723 ns** | **0.314 ns** |   **501.99 ns** |   **502.61 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.82 ns |   1.926 ns | 0.106 ns |   114.73 ns |   114.94 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   232.53 ns |   9.560 ns | 0.524 ns |   232.11 ns |   233.12 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.63 ns |   4.403 ns | 0.241 ns |    41.40 ns |    41.88 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.85 ns |   4.363 ns | 0.239 ns |   145.69 ns |   146.12 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.38 ns |   5.357 ns | 0.294 ns |    39.10 ns |    39.68 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,533.53 ns** | **172.239 ns** | **9.441 ns** | **1,526.27 ns** | **1,544.20 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.78 ns |  18.237 ns | 1.000 ns |   344.93 ns |   346.88 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   725.71 ns |  61.055 ns | 3.347 ns |   723.47 ns |   729.56 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   128.65 ns |  14.598 ns | 0.800 ns |   127.99 ns |   129.54 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   444.55 ns |  38.366 ns | 2.103 ns |   443.13 ns |   446.97 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.69 ns |  13.828 ns | 0.758 ns |   118.15 ns |   119.56 ns | 0.0062 |     528 B |
