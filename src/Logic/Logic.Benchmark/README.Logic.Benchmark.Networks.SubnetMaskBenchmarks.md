```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.34 ns** |   **2.208 ns** |  **0.121 ns** |    **17.21 ns** |    **17.46 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   109.84 ns |   8.797 ns |  0.482 ns |   109.52 ns |   110.40 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   103.62 ns |   2.155 ns |  0.118 ns |   103.52 ns |   103.75 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    78.35 ns |   9.886 ns |  0.542 ns |    77.72 ns |    78.68 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.13 ns |   6.979 ns |  0.383 ns |    44.89 ns |    45.57 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.18 ns |  14.883 ns |  0.816 ns |    43.27 ns |    44.85 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   126.70 ns |  45.688 ns |  2.504 ns |   123.95 ns |   128.85 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **191.08 ns** |  **61.716 ns** |  **3.383 ns** |   **187.28 ns** |   **193.76 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,071.31 ns | 104.658 ns |  5.737 ns | 1,067.10 ns | 1,077.85 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,028.23 ns |  97.114 ns |  5.323 ns | 1,023.15 ns | 1,033.77 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   793.75 ns |  29.015 ns |  1.590 ns |   792.27 ns |   795.43 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   457.75 ns |  19.292 ns |  1.057 ns |   457.06 ns |   458.97 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   434.17 ns |  34.125 ns |  1.870 ns |   432.08 ns |   435.69 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,194.53 ns | 323.646 ns | 17.740 ns | 1,179.36 ns | 1,214.03 ns | 0.0191 |    1680 B |
