```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev   | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|---------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.44 ns** |   **1.752 ns** | **0.096 ns** |    **17.37 ns** |    **17.55 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   121.03 ns |   5.266 ns | 0.289 ns |   120.80 ns |   121.35 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   116.96 ns |   7.491 ns | 0.411 ns |   116.51 ns |   117.30 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |    92.60 ns |  20.895 ns | 1.145 ns |    91.82 ns |    93.91 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.95 ns |   3.576 ns | 0.196 ns |    44.78 ns |    45.16 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.87 ns |  20.722 ns | 1.136 ns |    44.11 ns |    46.18 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   118.98 ns |  23.846 ns | 1.307 ns |   117.47 ns |   119.79 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **193.98 ns** |   **9.307 ns** | **0.510 ns** |   **193.51 ns** |   **194.52 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,247.16 ns | 155.373 ns | 8.517 ns | 1,237.80 ns | 1,254.45 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,196.86 ns |  20.164 ns | 1.105 ns | 1,196.08 ns | 1,198.12 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   942.97 ns |  40.228 ns | 2.205 ns |   941.29 ns |   945.47 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   458.66 ns |  82.744 ns | 4.535 ns |   454.34 ns |   463.39 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   438.76 ns |  27.680 ns | 1.517 ns |   437.87 ns |   440.52 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,174.75 ns |  66.714 ns | 3.657 ns | 1,170.84 ns | 1,178.08 ns | 0.0191 |    1680 B |
