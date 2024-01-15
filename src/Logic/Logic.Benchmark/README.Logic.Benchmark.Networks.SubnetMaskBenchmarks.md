```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.74 ns** |   **0.714 ns** |  **0.039 ns** |    **17.72 ns** |    **17.79 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   120.72 ns |   3.985 ns |  0.218 ns |   120.58 ns |   120.97 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   120.05 ns |  22.713 ns |  1.245 ns |   119.25 ns |   121.49 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    93.14 ns |   2.748 ns |  0.151 ns |    93.02 ns |    93.31 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.23 ns |   2.504 ns |  0.137 ns |    45.14 ns |    45.38 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    44.36 ns |   2.034 ns |  0.112 ns |    44.26 ns |    44.48 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   128.46 ns |  34.086 ns |  1.868 ns |   126.94 ns |   130.54 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **195.44 ns** |  **13.751 ns** |  **0.754 ns** |   **194.61 ns** |   **196.07 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,266.01 ns | 430.940 ns | 23.621 ns | 1,251.23 ns | 1,293.25 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,200.07 ns |  65.693 ns |  3.601 ns | 1,195.93 ns | 1,202.40 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   913.50 ns |  14.593 ns |  0.800 ns |   912.76 ns |   914.35 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   461.17 ns |  24.354 ns |  1.335 ns |   460.30 ns |   462.71 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   452.63 ns | 101.561 ns |  5.567 ns |   448.73 ns |   459.00 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,189.40 ns |  24.071 ns |  1.319 ns | 1,187.90 ns | 1,190.35 ns | 0.0191 |    1680 B |
