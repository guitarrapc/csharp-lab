```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.79 ns** |  **3.466 ns** | **0.190 ns** |  **17.66 ns** |  **18.01 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.36 ns |  3.198 ns | 0.175 ns | 119.18 ns | 119.53 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.08 ns |  3.590 ns | 0.197 ns | 117.86 ns | 118.25 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.30 ns |  3.147 ns | 0.172 ns |  91.16 ns |  91.49 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.59 ns |  1.046 ns | 0.057 ns |  45.52 ns |  45.62 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.26 ns |  1.847 ns | 0.101 ns |  43.14 ns |  43.34 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.37 ns | 55.584 ns | 3.047 ns | 115.95 ns | 121.79 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.21 ns** |  **5.833 ns** | **0.320 ns** |  **53.84 ns** |  **54.41 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.93 ns | 18.661 ns | 1.023 ns | 373.89 ns | 375.93 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 354.34 ns | 15.371 ns | 0.843 ns | 353.61 ns | 355.26 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 272.52 ns | 22.251 ns | 1.220 ns | 271.75 ns | 273.92 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.90 ns |  3.111 ns | 0.171 ns | 134.79 ns | 135.09 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.81 ns | 65.092 ns | 3.568 ns | 134.70 ns | 140.93 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 371.29 ns | 28.329 ns | 1.553 ns | 369.95 ns | 372.99 ns | 0.0057 |     504 B |
