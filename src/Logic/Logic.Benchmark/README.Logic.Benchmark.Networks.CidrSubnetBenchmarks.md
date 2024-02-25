```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **510.25 ns** | **107.230 ns** |  **5.878 ns** |   **506.23 ns** |   **516.99 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   114.73 ns |   5.229 ns |  0.287 ns |   114.44 ns |   115.01 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.77 ns |   5.792 ns |  0.317 ns |   233.55 ns |   234.14 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    44.94 ns |   7.619 ns |  0.418 ns |    44.53 ns |    45.36 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   141.93 ns |   4.869 ns |  0.267 ns |   141.75 ns |   142.23 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.49 ns |   1.965 ns |  0.108 ns |    40.42 ns |    40.62 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,215.13 ns** | **220.600 ns** | **12.092 ns** | **5,201.25 ns** | **5,223.43 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,185.81 ns | 548.104 ns | 30.043 ns | 1,156.33 ns | 1,216.38 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,384.15 ns | 212.985 ns | 11.674 ns | 2,373.89 ns | 2,396.86 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   438.47 ns |  86.780 ns |  4.757 ns |   433.09 ns |   442.13 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,494.70 ns | 303.096 ns | 16.614 ns | 1,482.16 ns | 1,513.54 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   420.80 ns | 523.809 ns | 28.712 ns |   402.86 ns |   453.92 ns | 0.0210 |    1760 B |
