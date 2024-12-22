```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **26.66 ns** |  **0.364 ns** | **0.020 ns** |  **26.65 ns** |  **26.69 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 116.38 ns |  2.486 ns | 0.136 ns | 116.25 ns | 116.52 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 111.90 ns |  2.258 ns | 0.124 ns | 111.83 ns | 112.04 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  83.02 ns |  4.168 ns | 0.228 ns |  82.87 ns |  83.28 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  43.24 ns |  3.304 ns | 0.181 ns |  43.03 ns |  43.37 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  39.83 ns |  4.988 ns | 0.273 ns |  39.52 ns |  40.02 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 111.16 ns | 11.376 ns | 0.624 ns | 110.53 ns | 111.78 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **77.72 ns** |  **3.852 ns** | **0.211 ns** |  **77.51 ns** |  **77.93 ns** | **0.0019** |     **168 B** |
| FromCidrAddress     | 3      | 363.45 ns |  9.711 ns | 0.532 ns | 362.84 ns | 363.76 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 336.22 ns | 26.278 ns | 1.440 ns | 334.81 ns | 337.69 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 252.74 ns | 27.755 ns | 1.521 ns | 251.80 ns | 254.49 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 130.79 ns |  5.014 ns | 0.275 ns | 130.60 ns | 131.11 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 119.47 ns | 12.185 ns | 0.668 ns | 118.98 ns | 120.23 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.77 ns | 33.326 ns | 1.827 ns | 366.20 ns | 369.78 ns | 0.0057 |     504 B |
