```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.64 ns** |   **4.210 ns** |  **0.231 ns** |    **17.49 ns** |    **17.90 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   130.51 ns |   3.169 ns |  0.174 ns |   130.41 ns |   130.72 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   117.01 ns |   3.240 ns |  0.178 ns |   116.85 ns |   117.20 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    94.96 ns |   3.098 ns |  0.170 ns |    94.82 ns |    95.15 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.75 ns |   2.160 ns |  0.118 ns |    44.68 ns |    44.89 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    43.71 ns |  15.213 ns |  0.834 ns |    43.04 ns |    44.65 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   123.96 ns |   6.514 ns |  0.357 ns |   123.62 ns |   124.33 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **194.77 ns** |   **9.609 ns** |  **0.527 ns** |   **194.16 ns** |   **195.11 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,229.24 ns | 462.811 ns | 25.368 ns | 1,202.71 ns | 1,253.26 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,195.39 ns |  23.755 ns |  1.302 ns | 1,194.38 ns | 1,196.86 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   928.99 ns |  14.418 ns |  0.790 ns |   928.10 ns |   929.59 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   462.39 ns |  70.845 ns |  3.883 ns |   459.52 ns |   466.81 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   441.85 ns |  10.813 ns |  0.593 ns |   441.37 ns |   442.51 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,175.50 ns |  44.306 ns |  2.429 ns | 1,173.39 ns | 1,178.15 ns | 0.0191 |    1680 B |
