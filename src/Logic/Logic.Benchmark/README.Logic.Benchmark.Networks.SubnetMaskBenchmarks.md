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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.58 ns** |   **5.564 ns** |  **0.305 ns** |    **17.38 ns** |    **17.93 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   109.41 ns |   1.865 ns |  0.102 ns |   109.30 ns |   109.49 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   106.03 ns |  62.555 ns |  3.429 ns |   104.05 ns |   109.99 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    76.36 ns |   2.231 ns |  0.122 ns |    76.25 ns |    76.49 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.88 ns |   1.192 ns |  0.065 ns |    44.83 ns |    44.95 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.36 ns |  13.769 ns |  0.755 ns |    43.72 ns |    45.19 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   124.99 ns |   8.653 ns |  0.474 ns |   124.64 ns |   125.53 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **191.87 ns** |  **67.882 ns** |  **3.721 ns** |   **187.59 ns** |   **194.33 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,076.95 ns |  29.852 ns |  1.636 ns | 1,075.06 ns | 1,077.99 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,081.28 ns | 376.944 ns | 20.662 ns | 1,069.35 ns | 1,105.13 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   780.95 ns |  73.635 ns |  4.036 ns |   778.02 ns |   785.56 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   455.28 ns |   9.697 ns |  0.532 ns |   454.89 ns |   455.89 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   454.22 ns |  53.233 ns |  2.918 ns |   451.69 ns |   457.41 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,185.83 ns |  10.526 ns |  0.577 ns | 1,185.17 ns | 1,186.26 ns | 0.0191 |    1680 B |
