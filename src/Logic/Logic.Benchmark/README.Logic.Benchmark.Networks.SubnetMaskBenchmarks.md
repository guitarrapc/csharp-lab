```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.79 ns** |   **0.497 ns** | **0.027 ns** |    **17.76 ns** |    **17.82 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   122.23 ns |   1.061 ns | 0.058 ns |   122.19 ns |   122.30 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   117.54 ns |   1.750 ns | 0.096 ns |   117.48 ns |   117.65 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    92.97 ns |   2.370 ns | 0.130 ns |    92.82 ns |    93.07 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.37 ns |   1.319 ns | 0.072 ns |    45.32 ns |    45.45 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    45.25 ns |  13.273 ns | 0.728 ns |    44.72 ns |    46.08 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   127.12 ns |  15.889 ns | 0.871 ns |   126.11 ns |   127.62 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **197.99 ns** |   **7.743 ns** | **0.424 ns** |   **197.74 ns** |   **198.48 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,245.92 ns | 128.770 ns | 7.058 ns | 1,240.96 ns | 1,254.00 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,198.28 ns | 108.384 ns | 5.941 ns | 1,194.35 ns | 1,205.12 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   946.84 ns |  23.731 ns | 1.301 ns |   945.39 ns |   947.89 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   464.98 ns |  14.028 ns | 0.769 ns |   464.27 ns |   465.79 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   443.70 ns |   5.496 ns | 0.301 ns |   443.36 ns |   443.94 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,188.02 ns | 110.613 ns | 6.063 ns | 1,183.57 ns | 1,194.93 ns | 0.0191 |    1680 B |
