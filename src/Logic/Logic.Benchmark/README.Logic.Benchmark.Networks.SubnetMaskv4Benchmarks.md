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
| **FromPrefix**          | **1**      |    **17.45 ns** |   **0.716 ns** |  **0.039 ns** |    **17.41 ns** |    **17.48 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   122.58 ns |  24.892 ns |  1.364 ns |   121.48 ns |   124.11 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   120.62 ns |  40.967 ns |  2.246 ns |   119.02 ns |   123.19 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    94.61 ns |   2.240 ns |  0.123 ns |    94.48 ns |    94.73 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    44.66 ns |   2.210 ns |  0.121 ns |    44.52 ns |    44.74 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    45.08 ns |   7.949 ns |  0.436 ns |    44.68 ns |    45.55 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   124.97 ns |  86.563 ns |  4.745 ns |   121.86 ns |   130.43 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **194.11 ns** |  **17.848 ns** |  **0.978 ns** |   **193.03 ns** |   **194.93 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,223.67 ns |  24.067 ns |  1.319 ns | 1,222.52 ns | 1,225.11 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,195.25 ns |  54.021 ns |  2.961 ns | 1,191.84 ns | 1,197.12 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     |   945.23 ns | 227.546 ns | 12.473 ns |   933.97 ns |   958.64 ns | 0.0067 |     560 B |
| FromIPAddressType   | 10     |   461.31 ns |  21.770 ns |  1.193 ns |   459.94 ns |   462.09 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   433.39 ns |  31.636 ns |  1.734 ns |   431.60 ns |   435.07 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,171.43 ns |  34.164 ns |  1.873 ns | 1,169.92 ns | 1,173.53 ns | 0.0191 |    1680 B |
