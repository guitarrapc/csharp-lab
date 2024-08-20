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
| **FromPrefix**          | **1**      |  **17.35 ns** |  **0.772 ns** | **0.042 ns** |  **17.32 ns** |  **17.40 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 124.38 ns |  2.196 ns | 0.120 ns | 124.29 ns | 124.52 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.77 ns |  6.673 ns | 0.366 ns | 115.55 ns | 116.19 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.32 ns | 13.499 ns | 0.740 ns |  89.68 ns |  91.13 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.09 ns |  0.292 ns | 0.016 ns |  44.07 ns |  44.10 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.34 ns |  1.001 ns | 0.055 ns |  43.28 ns |  43.39 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 116.55 ns |  8.668 ns | 0.475 ns | 116.11 ns | 117.06 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.03 ns** |  **6.854 ns** | **0.376 ns** |  **53.62 ns** |  **54.37 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 360.74 ns |  1.822 ns | 0.100 ns | 360.67 ns | 360.86 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.94 ns |  5.639 ns | 0.309 ns | 356.60 ns | 357.19 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 272.57 ns | 35.836 ns | 1.964 ns | 271.34 ns | 274.84 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.75 ns |  1.829 ns | 0.100 ns | 133.64 ns | 133.81 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.58 ns |  4.232 ns | 0.232 ns | 138.31 ns | 138.75 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.88 ns | 56.906 ns | 3.119 ns | 366.76 ns | 373.00 ns | 0.0057 |     504 B |
