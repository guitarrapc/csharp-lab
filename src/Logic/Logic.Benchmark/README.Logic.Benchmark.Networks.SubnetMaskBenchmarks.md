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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.34 ns** |   **2.148 ns** |  **0.118 ns** |    **17.25 ns** |    **17.47 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   108.27 ns |   2.980 ns |  0.163 ns |   108.08 ns |   108.39 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   103.38 ns |   4.619 ns |  0.253 ns |   103.17 ns |   103.66 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    77.94 ns |   3.252 ns |  0.178 ns |    77.81 ns |    78.14 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.22 ns |   3.113 ns |  0.171 ns |    45.03 ns |    45.36 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.80 ns |  12.952 ns |  0.710 ns |    43.01 ns |    44.38 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   129.61 ns |  55.815 ns |  3.059 ns |   126.61 ns |   132.73 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **189.12 ns** |  **77.300 ns** |  **4.237 ns** |   **186.50 ns** |   **194.01 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,067.93 ns |  83.421 ns |  4.573 ns | 1,063.30 ns | 1,072.44 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,026.23 ns |  77.643 ns |  4.256 ns | 1,021.32 ns | 1,028.71 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   803.33 ns | 556.926 ns | 30.527 ns |   785.27 ns |   838.58 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   483.37 ns |  17.092 ns |  0.937 ns |   482.51 ns |   484.37 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   442.77 ns |  29.720 ns |  1.629 ns |   441.09 ns |   444.34 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,175.75 ns |  69.561 ns |  3.813 ns | 1,171.49 ns | 1,178.85 ns | 0.0191 |    1680 B |
