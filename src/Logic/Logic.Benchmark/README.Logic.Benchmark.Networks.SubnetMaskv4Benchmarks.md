```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.63 ns** |  **8.065 ns** | **0.442 ns** |  **17.30 ns** |  **18.14 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.94 ns | 57.377 ns | 3.145 ns | 121.60 ns | 127.51 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.19 ns | 13.338 ns | 0.731 ns | 116.66 ns | 118.02 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.79 ns |  2.234 ns | 0.122 ns |  91.70 ns |  91.93 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.85 ns | 11.668 ns | 0.640 ns |  45.41 ns |  46.58 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.61 ns |  3.255 ns | 0.178 ns |  45.42 ns |  45.77 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.68 ns | 77.650 ns | 4.256 ns | 121.89 ns | 129.57 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.28 ns** |  **6.034 ns** | **0.331 ns** |  **53.90 ns** |  **54.52 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 373.29 ns | 24.769 ns | 1.358 ns | 372.33 ns | 374.85 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.21 ns |  8.056 ns | 0.442 ns | 358.72 ns | 359.58 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.87 ns | 15.316 ns | 0.840 ns | 287.19 ns | 288.81 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.20 ns | 15.988 ns | 0.876 ns | 134.63 ns | 136.21 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.77 ns | 16.819 ns | 0.922 ns | 137.01 ns | 138.79 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 372.49 ns | 31.756 ns | 1.741 ns | 370.81 ns | 374.28 ns | 0.0057 |     504 B |
