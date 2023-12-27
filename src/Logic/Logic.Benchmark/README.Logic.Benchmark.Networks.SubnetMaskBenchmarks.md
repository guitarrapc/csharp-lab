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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.40 ns** |   **1.591 ns** |  **0.087 ns** |    **17.34 ns** |    **17.50 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   106.86 ns |   1.376 ns |  0.075 ns |   106.80 ns |   106.94 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   104.38 ns |   3.371 ns |  0.185 ns |   104.18 ns |   104.54 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    76.64 ns |   7.870 ns |  0.431 ns |    76.28 ns |    77.12 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.78 ns |   0.932 ns |  0.051 ns |    44.74 ns |    44.84 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.29 ns |   5.002 ns |  0.274 ns |    43.09 ns |    43.60 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   129.24 ns |  54.197 ns |  2.971 ns |   126.83 ns |   132.56 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **188.45 ns** |  **43.717 ns** |  **2.396 ns** |   **186.99 ns** |   **191.22 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,068.83 ns | 138.951 ns |  7.616 ns | 1,064.29 ns | 1,077.63 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,042.92 ns | 382.413 ns | 20.961 ns | 1,029.87 ns | 1,067.10 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   781.92 ns |  24.987 ns |  1.370 ns |   780.61 ns |   783.34 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   459.53 ns |  21.549 ns |  1.181 ns |   458.52 ns |   460.83 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   446.82 ns |   9.484 ns |  0.520 ns |   446.24 ns |   447.23 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,177.20 ns | 166.503 ns |  9.127 ns | 1,170.29 ns | 1,187.54 ns | 0.0191 |    1680 B |
