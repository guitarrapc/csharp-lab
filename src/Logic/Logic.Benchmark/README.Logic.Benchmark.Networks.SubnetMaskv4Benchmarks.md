```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **18.77 ns** |   **3.403 ns** |  **0.187 ns** |    **18.57 ns** |    **18.93 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   123.36 ns |  17.701 ns |  0.970 ns |   122.49 ns |   124.41 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   119.66 ns |  53.888 ns |  2.954 ns |   117.45 ns |   123.01 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    90.73 ns |   5.327 ns |  0.292 ns |    90.40 ns |    90.95 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    46.86 ns |   3.823 ns |  0.210 ns |    46.70 ns |    47.10 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.65 ns |   7.710 ns |  0.423 ns |    44.40 ns |    45.14 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   124.43 ns |  12.800 ns |  0.702 ns |   123.79 ns |   125.18 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **198.29 ns** |  **10.428 ns** |  **0.572 ns** |   **197.78 ns** |   **198.91 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,260.22 ns | 257.230 ns | 14.100 ns | 1,251.69 ns | 1,276.49 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,171.10 ns |  59.944 ns |  3.286 ns | 1,167.89 ns | 1,174.46 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   958.70 ns |  94.900 ns |  5.202 ns |   954.77 ns |   964.60 ns | 0.0057 |     560 B |
| FromIPAddressType   | 10     |   464.64 ns |  50.492 ns |  2.768 ns |   462.35 ns |   467.72 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   442.43 ns |  20.432 ns |  1.120 ns |   441.70 ns |   443.72 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,190.34 ns |  61.057 ns |  3.347 ns | 1,186.67 ns | 1,193.22 ns | 0.0191 |    1680 B |
