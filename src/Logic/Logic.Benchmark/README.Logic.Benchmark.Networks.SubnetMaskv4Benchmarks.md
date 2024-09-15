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
| **FromPrefix**          | **1**      |  **17.50 ns** |  **1.591 ns** | **0.087 ns** |  **17.45 ns** |  **17.60 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 118.68 ns |  7.876 ns | 0.432 ns | 118.38 ns | 119.18 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.51 ns |  6.815 ns | 0.374 ns | 117.10 ns | 117.82 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.73 ns |  3.558 ns | 0.195 ns |  89.60 ns |  89.95 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.67 ns |  0.789 ns | 0.043 ns |  44.62 ns |  44.70 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.44 ns |  3.667 ns | 0.201 ns |  43.26 ns |  43.66 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.84 ns | 45.870 ns | 2.514 ns | 117.38 ns | 122.41 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **53.79 ns** |  **7.214 ns** | **0.395 ns** |  **53.52 ns** |  **54.25 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 367.50 ns | 46.278 ns | 2.537 ns | 365.71 ns | 370.40 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.88 ns |  9.044 ns | 0.496 ns | 352.31 ns | 353.22 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 281.20 ns | 17.537 ns | 0.961 ns | 280.56 ns | 282.30 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.19 ns |  4.440 ns | 0.243 ns | 133.91 ns | 134.35 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.76 ns | 45.118 ns | 2.473 ns | 135.09 ns | 139.61 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 371.57 ns | 53.931 ns | 2.956 ns | 368.22 ns | 373.84 ns | 0.0057 |     504 B |
