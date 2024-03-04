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
| **FromPrefix**          | **1**      |    **15.91 ns** |   **2.202 ns** |  **0.121 ns** |    **15.84 ns** |    **16.05 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   114.18 ns |  13.948 ns |  0.765 ns |   113.46 ns |   114.98 ns | 0.0013 |     112 B |
| FromCidrAddress2    | 1      |   111.37 ns |  12.194 ns |  0.668 ns |   110.67 ns |   112.00 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |    83.65 ns |   2.810 ns |  0.154 ns |    83.56 ns |    83.83 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    41.48 ns |   2.788 ns |  0.153 ns |    41.31 ns |    41.60 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    40.55 ns |  10.104 ns |  0.554 ns |    39.94 ns |    41.02 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   110.94 ns |  24.860 ns |  1.363 ns |   109.39 ns |   111.96 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **177.46 ns** |  **12.108 ns** |  **0.664 ns** |   **176.96 ns** |   **178.21 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,148.33 ns | 175.755 ns |  9.634 ns | 1,142.62 ns | 1,159.45 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,129.42 ns | 420.803 ns | 23.066 ns | 1,110.21 ns | 1,155.00 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   890.26 ns |  69.170 ns |  3.791 ns |   885.89 ns |   892.65 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   423.48 ns |  31.068 ns |  1.703 ns |   422.23 ns |   425.42 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   414.76 ns |  59.651 ns |  3.270 ns |   412.14 ns |   418.43 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,105.91 ns | 310.952 ns | 17.044 ns | 1,094.49 ns | 1,125.50 ns | 0.0191 |    1680 B |
