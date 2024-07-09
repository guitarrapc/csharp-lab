```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.72 ns** |  **1.052 ns** | **0.058 ns** |  **17.65 ns** |  **17.76 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.77 ns |  6.901 ns | 0.378 ns | 120.50 ns | 121.21 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 121.75 ns |  5.764 ns | 0.316 ns | 121.54 ns | 122.12 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.03 ns |  3.928 ns | 0.215 ns |  90.86 ns |  91.27 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.55 ns |  2.664 ns | 0.146 ns |  45.44 ns |  45.71 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.24 ns |  2.132 ns | 0.117 ns |  43.16 ns |  43.37 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.18 ns | 34.880 ns | 1.912 ns | 123.90 ns | 127.38 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.44 ns** |  **6.353 ns** | **0.348 ns** |  **55.07 ns** |  **55.75 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 377.75 ns | 11.253 ns | 0.617 ns | 377.37 ns | 378.46 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.36 ns | 24.809 ns | 1.360 ns | 357.52 ns | 359.93 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.57 ns | 12.412 ns | 0.680 ns | 275.15 ns | 276.35 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.10 ns | 65.971 ns | 3.616 ns | 134.83 ns | 141.27 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.31 ns | 58.421 ns | 3.202 ns | 137.27 ns | 143.65 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.60 ns | 38.720 ns | 2.122 ns | 364.17 ns | 368.11 ns | 0.0057 |     504 B |
