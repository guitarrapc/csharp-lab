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
| **FromPrefix**          | **1**      |    **17.57 ns** |   **2.909 ns** |  **0.159 ns** |    **17.42 ns** |    **17.74 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   121.81 ns |   8.724 ns |  0.478 ns |   121.47 ns |   122.36 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   119.41 ns |   3.359 ns |  0.184 ns |   119.25 ns |   119.61 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    90.49 ns |   0.567 ns |  0.031 ns |    90.45 ns |    90.51 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    46.12 ns |  16.863 ns |  0.924 ns |    45.45 ns |    47.18 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.75 ns |  14.867 ns |  0.815 ns |    44.27 ns |    45.69 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   126.78 ns |  39.872 ns |  2.186 ns |   124.95 ns |   129.20 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **195.00 ns** |   **8.147 ns** |  **0.447 ns** |   **194.50 ns** |   **195.35 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,237.70 ns | 115.398 ns |  6.325 ns | 1,233.52 ns | 1,244.98 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,210.86 ns | 358.836 ns | 19.669 ns | 1,198.63 ns | 1,233.55 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   937.43 ns |   4.651 ns |  0.255 ns |   937.17 ns |   937.68 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   459.33 ns |  17.252 ns |  0.946 ns |   458.27 ns |   460.10 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   446.68 ns | 200.770 ns | 11.005 ns |   440.28 ns |   459.39 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,194.03 ns |  15.724 ns |  0.862 ns | 1,193.07 ns | 1,194.73 ns | 0.0191 |    1680 B |
