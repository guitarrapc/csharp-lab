```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **539.70 ns** |  **48.293 ns** | **2.647 ns** |   **536.65 ns** |   **541.42 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.82 ns |   6.298 ns | 0.345 ns |   116.52 ns |   117.20 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   241.68 ns |  19.964 ns | 1.094 ns |   240.63 ns |   242.81 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.22 ns |   3.976 ns | 0.218 ns |    42.07 ns |    42.47 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.26 ns |  12.555 ns | 0.688 ns |   141.61 ns |   142.98 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.00 ns |   5.358 ns | 0.294 ns |    38.82 ns |    39.34 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,613.37 ns** | **168.807 ns** | **9.253 ns** | **1,606.69 ns** | **1,623.93 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   341.42 ns |  21.230 ns | 1.164 ns |   340.47 ns |   342.72 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   738.76 ns |  91.601 ns | 5.021 ns |   733.76 ns |   743.80 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   127.52 ns |  15.023 ns | 0.823 ns |   126.62 ns |   128.24 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   454.46 ns | 142.943 ns | 7.835 ns |   446.19 ns |   461.77 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.17 ns |   6.050 ns | 0.332 ns |   117.79 ns |   118.38 ns | 0.0062 |     528 B |
