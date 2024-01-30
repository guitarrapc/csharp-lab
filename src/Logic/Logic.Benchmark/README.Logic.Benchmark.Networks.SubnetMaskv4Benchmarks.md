```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.3 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.101
  [Host]   : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean        | Error        | StdDev     | Min         | Max         | Gen0   | Allocated |
|-------------------- |------- |------------:|-------------:|-----------:|------------:|------------:|-------:|----------:|
| **FromPrefix**          | **1**      |    **17.83 ns** |     **7.256 ns** |   **0.398 ns** |    **17.58 ns** |    **18.29 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      |   121.86 ns |    20.590 ns |   1.129 ns |   120.89 ns |   123.10 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      |   118.54 ns |     6.675 ns |   0.366 ns |   118.13 ns |   118.82 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |    92.30 ns |     5.213 ns |   0.286 ns |    92.02 ns |    92.59 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |    45.39 ns |     4.001 ns |   0.219 ns |    45.15 ns |    45.59 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |    45.44 ns |    26.778 ns |   1.468 ns |    44.29 ns |    47.09 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      |   124.86 ns |    11.327 ns |   0.621 ns |   124.22 ns |   125.46 ns | 0.0019 |     168 B |
| **FromPrefix**          | **10**     |   **196.52 ns** |    **10.810 ns** |   **0.593 ns** |   **195.84 ns** |   **196.92 ns** | **0.0067** |     **560 B** |
| FromCidrAddress     | 10     | 1,208.64 ns |    95.778 ns |   5.250 ns | 1,204.39 ns | 1,214.51 ns | 0.0134 |    1120 B |
| FromCidrAddress2    | 10     | 1,244.29 ns |    73.256 ns |   4.015 ns | 1,239.92 ns | 1,247.81 ns | 0.0134 |    1120 B |
| FromIPAddressString | 10     | 1,030.59 ns | 2,337.579 ns | 128.131 ns |   956.48 ns | 1,178.54 ns | 0.0057 |     560 B |
| FromIPAddressType   | 10     |   457.42 ns |    27.483 ns |   1.506 ns |   456.26 ns |   459.12 ns | 0.0105 |     880 B |
| GetNetworkAddress   | 10     |   438.49 ns |    52.421 ns |   2.873 ns |   436.11 ns |   441.68 ns | 0.0067 |     560 B |
| GetAddressRange     | 10     | 1,184.17 ns |   115.067 ns |   6.307 ns | 1,180.00 ns | 1,191.43 ns | 0.0191 |    1680 B |
