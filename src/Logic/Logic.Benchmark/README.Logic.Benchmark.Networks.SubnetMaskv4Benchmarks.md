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
| **FromPrefix**          | **1**      |    **18.46 ns** |   **3.254 ns** |  **0.178 ns** |    **18.33 ns** |    **18.67 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   124.46 ns |   2.746 ns |  0.151 ns |   124.29 ns |   124.58 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   120.29 ns |  19.762 ns |  1.083 ns |   119.08 ns |   121.17 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    92.36 ns |   5.582 ns |  0.306 ns |    92.11 ns |    92.70 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.94 ns |   0.503 ns |  0.028 ns |    44.91 ns |    44.97 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    43.15 ns |   5.406 ns |  0.296 ns |    42.89 ns |    43.48 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   119.65 ns |  39.984 ns |  2.192 ns |   117.38 ns |   121.75 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **189.59 ns** |  **21.482 ns** |  **1.178 ns** |   **188.82 ns** |   **190.95 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,245.68 ns | 238.767 ns | 13.088 ns | 1,231.89 ns | 1,257.93 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,163.02 ns | 346.748 ns | 19.006 ns | 1,151.27 ns | 1,184.95 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   951.94 ns |  49.837 ns |  2.732 ns |   949.53 ns |   954.91 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   455.12 ns |  12.070 ns |  0.662 ns |   454.53 ns |   455.84 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   446.55 ns | 109.989 ns |  6.029 ns |   442.07 ns |   453.40 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,167.00 ns |  67.107 ns |  3.678 ns | 1,163.19 ns | 1,170.53 ns | 0.0191 |    1680 B |
