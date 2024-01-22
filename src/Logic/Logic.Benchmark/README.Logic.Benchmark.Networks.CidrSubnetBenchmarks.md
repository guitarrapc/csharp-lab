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
| **GetNthSubnetIPv6**             | **1**      |   **499.14 ns** |   **4.815 ns** |  **0.264 ns** |   **498.87 ns** |   **499.39 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   112.34 ns |   6.474 ns |  0.355 ns |   111.93 ns |   112.57 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   234.91 ns |  15.557 ns |  0.853 ns |   234.18 ns |   235.85 ns | 0.0050 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.76 ns |   6.873 ns |  0.377 ns |    42.37 ns |    43.12 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.31 ns |  11.831 ns |  0.649 ns |   141.81 ns |   143.04 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    39.53 ns |   6.289 ns |  0.345 ns |    39.14 ns |    39.81 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,243.41 ns** | **364.486 ns** | **19.979 ns** | **5,220.37 ns** | **5,256.03 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,159.53 ns | 277.479 ns | 15.210 ns | 1,150.11 ns | 1,177.08 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,397.24 ns | 199.486 ns | 10.935 ns | 2,384.64 ns | 2,404.17 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   429.83 ns |  47.951 ns |  2.628 ns |   427.16 ns |   432.41 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,538.35 ns |  60.810 ns |  3.333 ns | 1,535.96 ns | 1,542.16 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   409.83 ns |  27.488 ns |  1.507 ns |   408.58 ns |   411.51 ns | 0.0210 |    1760 B |
