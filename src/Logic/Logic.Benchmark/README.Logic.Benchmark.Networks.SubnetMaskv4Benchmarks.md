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
| **FromPrefix**          | **1**      |    **17.46 ns** |   **0.568 ns** |  **0.031 ns** |    **17.44 ns** |    **17.50 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   121.90 ns |  40.876 ns |  2.241 ns |   120.47 ns |   124.48 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   121.10 ns |  48.490 ns |  2.658 ns |   119.37 ns |   124.16 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    92.94 ns |   1.274 ns |  0.070 ns |    92.89 ns |    93.02 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.74 ns |   0.673 ns |  0.037 ns |    44.71 ns |    44.78 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.63 ns |  12.764 ns |  0.700 ns |    43.87 ns |    45.25 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   124.15 ns |  15.047 ns |  0.825 ns |   123.20 ns |   124.67 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **193.56 ns** |  **11.818 ns** |  **0.648 ns** |   **192.91 ns** |   **194.21 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,240.54 ns | 367.181 ns | 20.126 ns | 1,227.90 ns | 1,263.75 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,156.24 ns |  42.596 ns |  2.335 ns | 1,153.76 ns | 1,158.39 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   944.29 ns |  19.849 ns |  1.088 ns |   943.58 ns |   945.54 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   456.67 ns |  12.016 ns |  0.659 ns |   455.93 ns |   457.20 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   435.74 ns |  15.912 ns |  0.872 ns |   434.78 ns |   436.49 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,187.73 ns | 448.232 ns | 24.569 ns | 1,170.09 ns | 1,215.79 ns | 0.0191 |    1680 B |
