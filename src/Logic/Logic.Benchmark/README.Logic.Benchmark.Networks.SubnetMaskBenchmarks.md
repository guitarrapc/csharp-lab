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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.40 ns** |   **1.575 ns** |  **0.086 ns** |    **17.31 ns** |    **17.48 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   109.18 ns |   0.507 ns |  0.028 ns |   109.15 ns |   109.21 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   104.65 ns |   1.600 ns |  0.088 ns |   104.59 ns |   104.75 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    76.99 ns |   4.288 ns |  0.235 ns |    76.78 ns |    77.24 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.88 ns |   1.295 ns |  0.071 ns |    44.80 ns |    44.94 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.78 ns |  17.476 ns |  0.958 ns |    44.18 ns |    45.88 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   124.34 ns |  28.019 ns |  1.536 ns |   123.37 ns |   126.11 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **191.05 ns** |  **91.342 ns** |  **5.007 ns** |   **185.31 ns** |   **194.53 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,099.36 ns | 207.991 ns | 11.401 ns | 1,089.81 ns | 1,111.98 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,051.01 ns |  61.153 ns |  3.352 ns | 1,047.30 ns | 1,053.82 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   779.98 ns |  15.185 ns |  0.832 ns |   779.02 ns |   780.53 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   454.74 ns |  37.254 ns |  2.042 ns |   453.00 ns |   456.99 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   441.98 ns | 212.894 ns | 11.669 ns |   431.55 ns |   454.58 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,207.40 ns | 332.475 ns | 18.224 ns | 1,186.39 ns | 1,218.86 ns | 0.0191 |    1680 B |
