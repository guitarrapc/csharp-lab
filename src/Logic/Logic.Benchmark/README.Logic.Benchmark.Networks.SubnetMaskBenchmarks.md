```

BenchmarkDotNet v0.13.11, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100
  [Host]   : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.0 (8.0.23.53103), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.27 ns** |  **2.033 ns** | **0.111 ns** |    **17.16 ns** |    **17.38 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   107.95 ns |  4.126 ns | 0.226 ns |   107.73 ns |   108.18 ns | 0.0013 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   105.22 ns |  2.742 ns | 0.150 ns |   105.09 ns |   105.39 ns | 0.0013 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    76.63 ns |  4.378 ns | 0.240 ns |    76.39 ns |    76.87 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.73 ns |  0.825 ns | 0.045 ns |    45.69 ns |    45.78 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.74 ns | 16.030 ns | 0.879 ns |    42.73 ns |    44.25 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   124.62 ns | 19.623 ns | 1.076 ns |   123.41 ns |   125.49 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **184.88 ns** | **19.950 ns** | **1.094 ns** |   **184.18 ns** |   **186.14 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,073.98 ns | 80.824 ns | 4.430 ns | 1,069.76 ns | 1,078.59 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,027.59 ns | 80.624 ns | 4.419 ns | 1,022.73 ns | 1,031.38 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   776.86 ns | 53.600 ns | 2.938 ns |   774.22 ns |   780.02 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   451.39 ns | 13.932 ns | 0.764 ns |   450.51 ns |   451.84 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   444.64 ns | 27.706 ns | 1.519 ns |   443.18 ns |   446.21 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,164.23 ns | 84.080 ns | 4.609 ns | 1,158.92 ns | 1,167.22 ns | 0.0191 |    1680 B |
