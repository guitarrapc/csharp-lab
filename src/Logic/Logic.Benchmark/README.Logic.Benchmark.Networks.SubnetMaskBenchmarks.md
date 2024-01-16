```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.20 ns** |   **0.492 ns** |  **0.027 ns** |    **17.17 ns** |    **17.22 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   121.28 ns |  13.760 ns |  0.754 ns |   120.45 ns |   121.93 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   117.03 ns |   4.407 ns |  0.242 ns |   116.80 ns |   117.28 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    92.02 ns |   3.554 ns |  0.195 ns |    91.90 ns |    92.25 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.83 ns |   1.457 ns |  0.080 ns |    44.76 ns |    44.91 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    42.94 ns |   1.827 ns |  0.100 ns |    42.86 ns |    43.05 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   121.54 ns |  57.630 ns |  3.159 ns |   118.08 ns |   124.26 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **193.16 ns** |  **21.904 ns** |  **1.201 ns** |   **192.41 ns** |   **194.55 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,247.55 ns | 501.700 ns | 27.500 ns | 1,230.30 ns | 1,279.27 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,197.37 ns |  32.101 ns |  1.760 ns | 1,195.67 ns | 1,199.19 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   920.43 ns |  16.012 ns |  0.878 ns |   919.42 ns |   921.03 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   454.41 ns |   8.615 ns |  0.472 ns |   454.05 ns |   454.94 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   440.38 ns | 135.385 ns |  7.421 ns |   434.39 ns |   448.68 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,184.17 ns |  93.414 ns |  5.120 ns | 1,179.61 ns | 1,189.71 ns | 0.0191 |    1680 B |
