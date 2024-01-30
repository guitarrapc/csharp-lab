```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                       | Number | Mean        | Error        | StdDev    | Min         | Max         | Gen0   | Allocated |
|----------------------------- |------- |------------:|-------------:|----------:|------------:|------------:|-------:|----------:|
| **GetNthSubnetIPv6**             | **1**      |   **505.13 ns** |     **7.514 ns** |  **0.412 ns** |   **504.73 ns** |   **505.56 ns** | **0.0076** |     **696 B** |
| GetNthSubnetIPv4             | 1      |   113.87 ns |     1.938 ns |  0.106 ns |   113.78 ns |   113.99 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv6BigInteger | 1      |   238.99 ns |    12.055 ns |  0.661 ns |   238.41 ns |   239.71 ns | 0.0048 |     432 B |
| GetSubnetRangeIPv6Shift      | 1      |    42.88 ns |    21.838 ns |  1.197 ns |    42.13 ns |    44.26 ns | 0.0019 |     160 B |
| GetSubnetRangeIPv4BigInteger | 1      |   142.88 ns |    12.539 ns |  0.687 ns |   142.22 ns |   143.59 ns | 0.0024 |     208 B |
| GetSubnetRangeIPv4Shift      | 1      |    40.14 ns |     4.677 ns |  0.256 ns |    39.88 ns |    40.39 ns | 0.0021 |     176 B |
| **GetNthSubnetIPv6**             | **10**     | **5,116.82 ns** | **1,594.556 ns** | **87.403 ns** | **5,063.34 ns** | **5,217.68 ns** | **0.0839** |    **7336 B** |
| GetNthSubnetIPv4             | 10     | 1,164.17 ns |   103.782 ns |  5.689 ns | 1,159.22 ns | 1,170.38 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv6BigInteger | 10     | 2,390.05 ns |   175.886 ns |  9.641 ns | 2,383.94 ns | 2,401.16 ns | 0.0496 |    4320 B |
| GetSubnetRangeIPv6Shift      | 10     |   421.59 ns |    75.567 ns |  4.142 ns |   418.50 ns |   426.29 ns | 0.0191 |    1600 B |
| GetSubnetRangeIPv4BigInteger | 10     | 1,420.79 ns |   144.927 ns |  7.944 ns | 1,411.62 ns | 1,425.70 ns | 0.0248 |    2080 B |
| GetSubnetRangeIPv4Shift      | 10     |   399.87 ns |    92.832 ns |  5.088 ns |   394.92 ns |   405.08 ns | 0.0210 |    1760 B |
