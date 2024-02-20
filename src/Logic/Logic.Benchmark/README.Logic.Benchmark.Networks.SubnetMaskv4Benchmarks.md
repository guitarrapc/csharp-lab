```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error      | StdDev    | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-----------:|----------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.04 ns** |   **1.126 ns** |  **0.062 ns** |    **16.97 ns** |    **17.08 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   119.14 ns |   7.004 ns |  0.384 ns |   118.81 ns |   119.56 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   118.07 ns |   2.632 ns |  0.144 ns |   117.91 ns |   118.20 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    89.07 ns |   0.795 ns |  0.044 ns |    89.01 ns |    89.09 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.86 ns |   3.662 ns |  0.201 ns |    44.73 ns |    45.09 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.33 ns |  32.246 ns |  1.768 ns |    42.94 ns |    46.32 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   122.34 ns |  12.693 ns |  0.696 ns |   121.60 ns |   122.98 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **187.99 ns** |  **84.654 ns** |  **4.640 ns** |   **182.63 ns** |   **190.81 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,227.99 ns | 240.593 ns | 13.188 ns | 1,217.12 ns | 1,242.66 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,194.63 ns |  23.544 ns |  1.291 ns | 1,193.48 ns | 1,196.02 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   941.35 ns |   5.811 ns |  0.318 ns |   941.00 ns |   941.63 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   453.14 ns |  20.828 ns |  1.142 ns |   452.45 ns |   454.46 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   435.63 ns |  32.979 ns |  1.808 ns |   433.54 ns |   436.78 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,171.44 ns |  83.618 ns |  4.583 ns | 1,167.43 ns | 1,176.44 ns | 0.0191 |    1680 B |
