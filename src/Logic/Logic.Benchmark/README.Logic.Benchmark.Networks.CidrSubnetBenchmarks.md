```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.75 ns** |  **22.665 ns** | **1.242 ns** |   **504.36 ns** |   **506.76 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.10 ns |   6.739 ns | 0.369 ns |   111.85 ns |   112.52 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.53 ns |   5.021 ns | 0.275 ns |   236.35 ns |   236.85 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.66 ns |   9.870 ns | 0.541 ns |    42.21 ns |    43.26 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.31 ns |  11.200 ns | 0.614 ns |   140.64 ns |   141.84 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.67 ns |  12.075 ns | 0.662 ns |    39.06 ns |    40.37 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,611.89 ns** | **101.719 ns** | **5.576 ns** | **1,605.78 ns** | **1,616.69 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   352.52 ns |  73.393 ns | 4.023 ns |   349.54 ns |   357.10 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   738.50 ns |  52.791 ns | 2.894 ns |   735.18 ns |   740.48 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   125.91 ns |   6.481 ns | 0.355 ns |   125.69 ns |   126.32 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   432.10 ns |  56.739 ns | 3.110 ns |   428.52 ns |   434.08 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   117.36 ns |   6.686 ns | 0.366 ns |   117.01 ns |   117.74 ns | 0.0062 |     528 B |
