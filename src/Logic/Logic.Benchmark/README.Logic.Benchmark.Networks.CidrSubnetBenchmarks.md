```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **506.00 ns** |   **270.486 ns** | **14.826 ns** |   **495.95 ns** |   **523.03 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.77 ns |     1.172 ns |  0.064 ns |   113.71 ns |   113.84 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   230.58 ns |    19.767 ns |  1.083 ns |   229.80 ns |   231.82 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.81 ns |     5.118 ns |  0.281 ns |    42.49 ns |    43.02 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.36 ns |     6.781 ns |  0.372 ns |   141.06 ns |   141.78 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.53 ns |     2.874 ns |  0.158 ns |    39.36 ns |    39.67 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,628.75 ns** | **1,102.541 ns** | **60.434 ns** | **1,591.76 ns** | **1,698.49 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   345.18 ns |     4.870 ns |  0.267 ns |   344.89 ns |   345.42 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   718.52 ns |    34.525 ns |  1.892 ns |   716.56 ns |   720.33 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.81 ns |    17.546 ns |  0.962 ns |   125.75 ns |   127.62 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   429.64 ns |     7.929 ns |  0.435 ns |   429.23 ns |   430.09 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   118.83 ns |     5.270 ns |  0.289 ns |   118.53 ns |   119.10 ns | 0.0062 |     528 B |
