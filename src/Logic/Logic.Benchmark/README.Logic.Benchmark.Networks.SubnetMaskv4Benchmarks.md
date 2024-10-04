```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.90 ns** |  **0.656 ns** | **0.036 ns** |  **17.86 ns** |  **17.93 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 126.46 ns |  2.369 ns | 0.130 ns | 126.31 ns | 126.55 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.34 ns |  4.115 ns | 0.226 ns | 115.10 ns | 115.54 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.10 ns |  4.432 ns | 0.243 ns |  89.87 ns |  90.35 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.77 ns |  8.204 ns | 0.450 ns |  44.38 ns |  45.26 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.19 ns |  3.705 ns | 0.203 ns |  45.03 ns |  45.42 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.31 ns | 20.546 ns | 1.126 ns | 120.18 ns | 122.43 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.77 ns** |  **4.353 ns** | **0.239 ns** |  **54.52 ns** |  **54.99 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.25 ns | 34.479 ns | 1.890 ns | 372.93 ns | 376.41 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 354.52 ns | 24.455 ns | 1.340 ns | 353.68 ns | 356.07 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.00 ns |  7.476 ns | 0.410 ns | 272.53 ns | 273.28 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.65 ns |  9.386 ns | 0.514 ns | 134.17 ns | 135.19 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.39 ns | 12.247 ns | 0.671 ns | 138.80 ns | 140.12 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.80 ns | 35.854 ns | 1.965 ns | 365.54 ns | 369.04 ns | 0.0057 |     504 B |
