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
| **FromPrefix**          | **1**      |    **17.82 ns** |   **2.277 ns** |  **0.125 ns** |    **17.69 ns** |    **17.94 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   120.88 ns |  33.946 ns |  1.861 ns |   119.50 ns |   122.99 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   117.93 ns |   2.098 ns |  0.115 ns |   117.80 ns |   118.00 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |    93.68 ns |   7.151 ns |  0.392 ns |    93.30 ns |    94.08 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    45.22 ns |   2.097 ns |  0.115 ns |    45.08 ns |    45.30 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.60 ns |   7.461 ns |  0.409 ns |    44.14 ns |    44.92 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   124.92 ns |   9.133 ns |  0.501 ns |   124.38 ns |   125.37 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **197.72 ns** |   **4.103 ns** |  **0.225 ns** |   **197.46 ns** |   **197.86 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,248.29 ns |  49.579 ns |  2.718 ns | 1,246.40 ns | 1,251.41 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,200.09 ns |  37.065 ns |  2.032 ns | 1,198.02 ns | 1,202.08 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   920.21 ns | 253.787 ns | 13.911 ns |   912.07 ns |   936.28 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   459.71 ns |  12.295 ns |  0.674 ns |   458.99 ns |   460.32 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   444.08 ns | 117.149 ns |  6.421 ns |   436.78 ns |   448.86 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,188.57 ns |  94.967 ns |  5.205 ns | 1,183.52 ns | 1,193.92 ns | 0.0191 |    1680 B |
