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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.76 ns** |   **0.966 ns** |  **0.053 ns** |    **17.71 ns** |    **17.82 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   121.85 ns |   5.868 ns |  0.322 ns |   121.63 ns |   122.22 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   117.82 ns |   6.396 ns |  0.351 ns |   117.56 ns |   118.22 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    91.28 ns |   3.264 ns |  0.179 ns |    91.16 ns |    91.49 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.44 ns |   3.787 ns |  0.208 ns |    45.22 ns |    45.62 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.49 ns |  21.549 ns |  1.181 ns |    42.79 ns |    44.85 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   126.08 ns |  59.726 ns |  3.274 ns |   122.73 ns |   129.27 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **195.22 ns** |  **13.311 ns** |  **0.730 ns** |   **194.39 ns** |   **195.77 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,226.24 ns | 314.910 ns | 17.261 ns | 1,215.72 ns | 1,246.16 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,149.12 ns |  22.840 ns |  1.252 ns | 1,147.83 ns | 1,150.33 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   924.02 ns | 140.045 ns |  7.676 ns |   917.53 ns |   932.49 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   460.57 ns |  31.250 ns |  1.713 ns |   459.11 ns |   462.46 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   444.27 ns | 151.419 ns |  8.300 ns |   435.07 ns |   451.19 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,183.46 ns |  17.928 ns |  0.983 ns | 1,182.37 ns | 1,184.27 ns | 0.0191 |    1680 B |
