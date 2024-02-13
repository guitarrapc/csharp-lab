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
| **FromPrefix**          | **1**      |    **17.42 ns** |   **1.683 ns** |  **0.092 ns** |    **17.34 ns** |    **17.52 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   119.15 ns |  12.912 ns |  0.708 ns |   118.55 ns |   119.93 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   128.16 ns |  41.971 ns |  2.301 ns |   126.62 ns |   130.80 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    88.87 ns |   1.060 ns |  0.058 ns |    88.80 ns |    88.90 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.47 ns |   3.655 ns |  0.200 ns |    44.24 ns |    44.62 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    44.31 ns |  19.769 ns |  1.084 ns |    43.27 ns |    45.43 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   118.61 ns |  63.814 ns |  3.498 ns |   115.68 ns |   122.48 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **188.99 ns** |  **36.764 ns** |  **2.015 ns** |   **186.67 ns** |   **190.34 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,189.14 ns | 154.237 ns |  8.454 ns | 1,180.11 ns | 1,196.88 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,142.39 ns |  75.482 ns |  4.137 ns | 1,137.75 ns | 1,145.71 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   941.52 ns | 210.836 ns | 11.557 ns |   932.97 ns |   954.67 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   458.25 ns |  20.597 ns |  1.129 ns |   457.40 ns |   459.53 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   429.20 ns |  87.810 ns |  4.813 ns |   423.69 ns |   432.56 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,180.16 ns | 178.872 ns |  9.805 ns | 1,171.49 ns | 1,190.80 ns | 0.0191 |    1680 B |
