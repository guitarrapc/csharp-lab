```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **510.14 ns** |  **50.778 ns** |  **2.783 ns** |   **507.17 ns** |   **512.69 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   120.97 ns |  13.158 ns |  0.721 ns |   120.51 ns |   121.80 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   233.65 ns |  16.203 ns |  0.888 ns |   232.65 ns |   234.35 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    41.40 ns |   1.210 ns |  0.066 ns |    41.33 ns |    41.47 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   146.62 ns |  23.700 ns |  1.299 ns |   145.23 ns |   147.81 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    38.77 ns |   0.888 ns |  0.049 ns |    38.72 ns |    38.81 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,143.37 ns** | **231.945 ns** | **12.714 ns** | **5,131.58 ns** | **5,156.84 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,151.10 ns | 113.806 ns |  6.238 ns | 1,145.35 ns | 1,157.73 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,433.16 ns | 919.341 ns | 50.392 ns | 2,403.82 ns | 2,491.34 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   421.69 ns |  16.693 ns |  0.915 ns |   420.75 ns |   422.57 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,425.96 ns |  72.261 ns |  3.961 ns | 1,422.07 ns | 1,429.99 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   388.75 ns |  44.285 ns |  2.427 ns |   386.16 ns |   390.98 ns | 0.0210 |    1760 B |
