```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                                 | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|--------------------------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **1**      |   **240.09 ns** | **146.072 ns** | **8.007 ns** |   **235.29 ns** |   **249.34 ns** | **0.0050** |     **432 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 1      |    41.80 ns |   3.037 ns | 0.166 ns |    41.62 ns |    41.95 ns | 0.0019 |     160 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 1      |   148.95 ns |  37.887 ns | 2.077 ns |   147.33 ns |   151.29 ns | 0.0024 |     208 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 1      |    39.97 ns |   2.572 ns | 0.141 ns |    39.86 ns |    40.13 ns | 0.0021 |     176 B |
| **CidrSubnetGetSubnetRangeIPv6BigInteger** | **10**     | **2,340.66 ns** |  **54.171 ns** | **2.969 ns** | **2,337.71 ns** | **2,343.65 ns** | **0.0496** |    **4320 B** |
| CidrSubnetGetSubnetRangeIPv6Shift      | 10     |   426.09 ns | 136.631 ns | 7.489 ns |   419.12 ns |   434.01 ns | 0.0191 |    1600 B |
| CidrSubnetGetSubnetRangeIPv4BigInteger | 10     | 1,464.37 ns |  88.869 ns | 4.871 ns | 1,461.26 ns | 1,469.98 ns | 0.0248 |    2080 B |
| CidrSubnetGetSubnetRangeIPv4Shift      | 10     |   402.03 ns |  46.272 ns | 2.536 ns |   399.18 ns |   404.05 ns | 0.0210 |    1760 B |
