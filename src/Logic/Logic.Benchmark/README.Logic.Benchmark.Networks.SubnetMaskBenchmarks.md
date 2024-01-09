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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.29 ns** |   **0.661 ns** |  **0.036 ns** |    **17.25 ns** |    **17.32 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   106.21 ns |   4.957 ns |  0.272 ns |   105.95 ns |   106.49 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   104.03 ns |   2.027 ns |  0.111 ns |   103.94 ns |   104.16 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    76.44 ns |   5.650 ns |  0.310 ns |    76.09 ns |    76.66 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.26 ns |   9.214 ns |  0.505 ns |    44.97 ns |    45.85 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.56 ns |  11.457 ns |  0.628 ns |    43.98 ns |    45.23 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   123.92 ns |   2.533 ns |  0.139 ns |   123.81 ns |   124.08 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **189.84 ns** |  **88.767 ns** |  **4.866 ns** |   **186.28 ns** |   **195.39 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,080.76 ns |  66.918 ns |  3.668 ns | 1,077.15 ns | 1,084.49 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,063.50 ns | 390.373 ns | 21.398 ns | 1,049.13 ns | 1,088.10 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   780.14 ns |  21.903 ns |  1.201 ns |   779.12 ns |   781.46 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   459.74 ns |  13.255 ns |  0.727 ns |   458.99 ns |   460.44 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   439.64 ns |  12.996 ns |  0.712 ns |   439.12 ns |   440.45 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,186.08 ns |  70.135 ns |  3.844 ns | 1,183.11 ns | 1,190.43 ns | 0.0191 |    1680 B |
