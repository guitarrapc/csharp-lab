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
| **FromPrefix**          | **1**      |  **17.89 ns** |  **1.982 ns** | **0.109 ns** |  **17.79 ns** |  **18.00 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.71 ns | 11.760 ns | 0.645 ns | 125.27 ns | 126.45 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.54 ns |  8.568 ns | 0.470 ns | 118.21 ns | 119.08 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.05 ns |  1.010 ns | 0.055 ns |  89.99 ns |  90.10 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.08 ns |  0.972 ns | 0.053 ns |  45.05 ns |  45.14 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.64 ns | 31.208 ns | 1.711 ns |  44.59 ns |  47.61 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.36 ns |  8.885 ns | 0.487 ns | 117.88 ns | 118.86 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.18 ns** |  **6.682 ns** | **0.366 ns** |  **54.92 ns** |  **55.60 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 364.82 ns | 20.591 ns | 1.129 ns | 363.74 ns | 365.99 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 355.52 ns | 23.717 ns | 1.300 ns | 354.75 ns | 357.02 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.81 ns | 12.717 ns | 0.697 ns | 280.01 ns | 281.23 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 138.43 ns |  8.583 ns | 0.470 ns | 138.02 ns | 138.94 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.78 ns | 32.410 ns | 1.777 ns | 136.78 ns | 140.18 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 372.99 ns | 62.390 ns | 3.420 ns | 369.73 ns | 376.55 ns | 0.0057 |     504 B |
