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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.18 ns** |   **1.422 ns** |  **0.078 ns** |    **17.14 ns** |    **17.27 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   107.66 ns |   5.124 ns |  0.281 ns |   107.48 ns |   107.99 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   103.53 ns |   3.365 ns |  0.184 ns |   103.32 ns |   103.65 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    76.38 ns |   4.538 ns |  0.249 ns |    76.21 ns |    76.66 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.42 ns |   2.993 ns |  0.164 ns |    45.32 ns |    45.61 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    45.25 ns |  13.805 ns |  0.757 ns |    44.62 ns |    46.09 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   124.45 ns |   9.294 ns |  0.509 ns |   123.86 ns |   124.80 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **191.72 ns** |   **6.592 ns** |  **0.361 ns** |   **191.37 ns** |   **192.09 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,069.61 ns |  72.313 ns |  3.964 ns | 1,066.40 ns | 1,074.04 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,029.10 ns |  23.449 ns |  1.285 ns | 1,028.28 ns | 1,030.59 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   803.59 ns | 292.270 ns | 16.020 ns |   792.51 ns |   821.96 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   451.76 ns |  24.860 ns |  1.363 ns |   450.68 ns |   453.29 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   448.56 ns |  64.158 ns |  3.517 ns |   446.40 ns |   452.61 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,172.36 ns |  13.658 ns |  0.749 ns | 1,171.51 ns | 1,172.88 ns | 0.0191 |    1680 B |
