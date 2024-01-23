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
| **FromPrefix**          | **1**      |    **17.47 ns** |   **2.757 ns** |  **0.151 ns** |    **17.34 ns** |    **17.64 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   126.24 ns |  36.873 ns |  2.021 ns |   124.97 ns |   128.57 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   116.69 ns |   3.534 ns |  0.194 ns |   116.54 ns |   116.91 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |    92.03 ns |   0.968 ns |  0.053 ns |    91.99 ns |    92.09 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.72 ns |   1.609 ns |  0.088 ns |    44.63 ns |    44.81 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    48.16 ns |  29.711 ns |  1.629 ns |    46.90 ns |    50.00 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   126.55 ns |  48.791 ns |  2.674 ns |   124.36 ns |   129.53 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **193.78 ns** |  **20.813 ns** |  **1.141 ns** |   **192.81 ns** |   **195.04 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,246.20 ns |  46.311 ns |  2.538 ns | 1,243.32 ns | 1,248.10 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,202.25 ns | 244.403 ns | 13.397 ns | 1,190.46 ns | 1,216.82 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   942.47 ns |  10.781 ns |  0.591 ns |   941.87 ns |   943.05 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   463.24 ns |  17.573 ns |  0.963 ns |   462.14 ns |   463.96 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   448.44 ns |  47.668 ns |  2.613 ns |   445.43 ns |   450.06 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,187.27 ns |  40.073 ns |  2.197 ns | 1,184.89 ns | 1,189.21 ns | 0.0191 |    1680 B |
