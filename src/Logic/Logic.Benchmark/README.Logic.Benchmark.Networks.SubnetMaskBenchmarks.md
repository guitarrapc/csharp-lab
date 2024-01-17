```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method                        | Number | Mean        | Error     | StdDev   | Min         | Max         | Gen0   | Allocated |
|------------------------------ |------- |------------:|----------:|---------:|------------:|------------:|-------:|----------:|
| **SubnetMaskFromCidrNotion**      | **1**      |    **17.62 ns** |  **1.366 ns** | **0.075 ns** |    **17.55 ns** |    **17.70 ns** | **0.0007** |      **56 B** |
| SubnetMaskFromCidrAddress     | 1      |   121.61 ns |  9.021 ns | 0.494 ns |   121.16 ns |   122.14 ns | 0.0012 |     112 B |
| SubnetMaskFromCidrAddress2    | 1      |   116.41 ns |  5.586 ns | 0.306 ns |   116.14 ns |   116.74 ns | 0.0012 |     112 B |
| SubnetMaskFromIPAddressString | 1      |    91.14 ns |  2.134 ns | 0.117 ns |    91.02 ns |    91.26 ns | 0.0006 |      56 B |
| SubnetMaskFromIPAddressType   | 1      |    45.48 ns |  4.657 ns | 0.255 ns |    45.24 ns |    45.75 ns | 0.0010 |      88 B |
| SubnetMaskGetNetworkAddress   | 1      |    43.27 ns |  1.184 ns | 0.065 ns |    43.21 ns |    43.34 ns | 0.0007 |      56 B |
| SubnetMaskGetAddressRange     | 1      |   125.48 ns | 13.589 ns | 0.745 ns |   124.85 ns |   126.30 ns | 0.0019 |     168 B |
| **SubnetMaskFromCidrNotion**      | **10**     |   **196.38 ns** |  **6.827 ns** | **0.374 ns** |   **195.96 ns** |   **196.67 ns** | **0.0067** |     **560 B** |
| SubnetMaskFromCidrAddress     | 10     | 1,221.79 ns | 92.785 ns | 5.086 ns | 1,217.35 ns | 1,227.34 ns | 0.0134 |    1120 B |
| SubnetMaskFromCidrAddress2    | 10     | 1,154.24 ns | 56.629 ns | 3.104 ns | 1,150.66 ns | 1,156.16 ns | 0.0134 |    1120 B |
| SubnetMaskFromIPAddressString | 10     |   923.22 ns | 14.271 ns | 0.782 ns |   922.77 ns |   924.12 ns | 0.0067 |     560 B |
| SubnetMaskFromIPAddressType   | 10     |   463.10 ns | 16.198 ns | 0.888 ns |   462.21 ns |   463.99 ns | 0.0105 |     880 B |
| SubnetMaskGetNetworkAddress   | 10     |   434.26 ns |  2.059 ns | 0.113 ns |   434.15 ns |   434.38 ns | 0.0067 |     560 B |
| SubnetMaskGetAddressRange     | 10     | 1,179.02 ns | 34.363 ns | 1.884 ns | 1,177.83 ns | 1,181.19 ns | 0.0191 |    1680 B |
