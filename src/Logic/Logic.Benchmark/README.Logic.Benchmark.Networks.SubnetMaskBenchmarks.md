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
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.28 ns** |   **0.415 ns** |  **0.023 ns** |    **17.26 ns** |    **17.30 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   121.48 ns |   1.014 ns |  0.056 ns |   121.42 ns |   121.53 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   115.60 ns |   0.150 ns |  0.008 ns |   115.60 ns |   115.61 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    93.93 ns |   0.778 ns |  0.043 ns |    93.90 ns |    93.98 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    44.72 ns |   0.939 ns |  0.051 ns |    44.66 ns |    44.76 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.55 ns |   7.888 ns |  0.432 ns |    44.12 ns |    44.98 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   131.59 ns |  88.122 ns |  4.830 ns |   127.21 ns |   136.77 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **192.60 ns** |  **20.621 ns** |  **1.130 ns** |   **191.39 ns** |   **193.62 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,218.19 ns | 343.270 ns | 18.816 ns | 1,202.20 ns | 1,238.92 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,220.88 ns | 196.075 ns | 10.748 ns | 1,214.09 ns | 1,233.27 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   976.12 ns | 323.372 ns | 17.725 ns |   965.47 ns |   996.59 ns | 0.0057 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   455.16 ns |  26.880 ns |  1.473 ns |   453.94 ns |   456.80 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   446.46 ns |  43.224 ns |  2.369 ns |   443.73 ns |   447.91 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,170.83 ns |  53.421 ns |  2.928 ns | 1,168.44 ns | 1,174.10 ns | 0.0191 |    1680 B |
