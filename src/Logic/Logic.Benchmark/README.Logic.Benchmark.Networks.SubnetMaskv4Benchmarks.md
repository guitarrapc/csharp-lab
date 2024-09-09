```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.34 ns** |  **3.962 ns** | **0.217 ns** |  **18.11 ns** |  **18.55 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.60 ns |  4.682 ns | 0.257 ns | 123.39 ns | 123.88 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.68 ns |  1.012 ns | 0.055 ns | 117.63 ns | 117.74 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.16 ns |  2.176 ns | 0.119 ns |  91.05 ns |  91.29 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.18 ns |  1.453 ns | 0.080 ns |  45.09 ns |  45.23 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.44 ns |  0.751 ns | 0.041 ns |  43.41 ns |  43.49 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.45 ns | 13.711 ns | 0.752 ns | 117.77 ns | 119.26 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.74 ns** |  **8.544 ns** | **0.468 ns** |  **56.21 ns** |  **57.10 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.48 ns | 67.692 ns | 3.710 ns | 374.14 ns | 380.76 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 345.51 ns | 21.018 ns | 1.152 ns | 344.21 ns | 346.40 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 272.52 ns | 15.305 ns | 0.839 ns | 271.75 ns | 273.41 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.29 ns |  9.469 ns | 0.519 ns | 134.78 ns | 135.82 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 135.87 ns |  5.261 ns | 0.288 ns | 135.58 ns | 136.15 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.45 ns | 15.755 ns | 0.864 ns | 368.73 ns | 370.41 ns | 0.0057 |     504 B |
