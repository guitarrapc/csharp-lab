```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **516.02 ns** |    **40.109 ns** |   **2.199 ns** |   **514.30 ns** |   **518.50 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   116.39 ns |    28.236 ns |   1.548 ns |   114.63 ns |   117.51 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   236.47 ns |     5.357 ns |   0.294 ns |   236.15 ns |   236.73 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    43.14 ns |     1.426 ns |   0.078 ns |    43.05 ns |    43.19 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   145.33 ns |     1.028 ns |   0.056 ns |   145.27 ns |   145.38 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    42.74 ns |     4.206 ns |   0.231 ns |    42.53 ns |    42.99 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **3**      | **1,762.78 ns** | **2,868.628 ns** | **157.239 ns** | **1,638.93 ns** | **1,939.69 ns** | **0.0248** |    **2168 B** |
| GetNthSubnetIPv4             | 3      |   346.32 ns |    15.962 ns |   0.875 ns |   345.44 ns |   347.19 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv6BigInteger | 3      |   720.78 ns |    16.814 ns |   0.922 ns |   720.14 ns |   721.83 ns | 0.0153 |    1296 B |
| GetSubnetRangeIPv6Shift      | 3      |   126.27 ns |    24.580 ns |   1.347 ns |   124.90 ns |   127.60 ns | 0.0057 |     480 B |
| GetSubnetRangeIPv4BigInteger | 3      |   434.48 ns |    34.228 ns |   1.876 ns |   432.36 ns |   435.92 ns | 0.0072 |     624 B |
| GetSubnetRangeIPv4Shift      | 3      |   122.54 ns |    10.561 ns |   0.579 ns |   121.89 ns |   123.01 ns | 0.0062 |     528 B |
