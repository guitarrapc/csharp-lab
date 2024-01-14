```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.43 ns** |   **0.697 ns** | **0.038 ns** |    **17.39 ns** |    **17.47 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   124.82 ns |   7.318 ns | 0.401 ns |   124.38 ns |   125.16 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   118.54 ns |  44.547 ns | 2.442 ns |   116.72 ns |   121.32 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    92.53 ns |   1.245 ns | 0.068 ns |    92.47 ns |    92.60 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.08 ns |   3.534 ns | 0.194 ns |    44.89 ns |    45.28 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    45.31 ns |  23.979 ns | 1.314 ns |    44.52 ns |    46.83 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   121.42 ns | 106.365 ns | 5.830 ns |   117.77 ns |   128.14 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **194.55 ns** |  **11.066 ns** | **0.607 ns** |   **193.94 ns** |   **195.15 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,232.24 ns | 100.570 ns | 5.513 ns | 1,226.89 ns | 1,237.90 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,160.91 ns | 121.606 ns | 6.666 ns | 1,153.63 ns | 1,166.71 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   944.48 ns |  97.690 ns | 5.355 ns |   941.21 ns |   950.66 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   458.92 ns |   9.719 ns | 0.533 ns |   458.40 ns |   459.46 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   448.02 ns |  20.446 ns | 1.121 ns |   447.34 ns |   449.32 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,187.80 ns | 131.631 ns | 7.215 ns | 1,182.72 ns | 1,196.06 ns | 0.0191 |    1680 B |
