```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.56 ns** |   **3.345 ns** | **0.183 ns** |  **17.42 ns** |  **17.77 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.06 ns |   4.149 ns | 0.227 ns | 120.85 ns | 121.30 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.30 ns |   9.825 ns | 0.539 ns | 116.90 ns | 117.91 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.26 ns |   3.620 ns | 0.198 ns |  89.07 ns |  89.47 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.28 ns |   2.324 ns | 0.127 ns |  44.14 ns |  44.40 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.99 ns |   1.074 ns | 0.059 ns |  45.95 ns |  46.06 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.47 ns |  34.233 ns | 1.876 ns | 117.13 ns | 120.61 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.86 ns** |  **10.620 ns** | **0.582 ns** |  **54.21 ns** |  **55.32 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 378.58 ns |   7.066 ns | 0.387 ns | 378.18 ns | 378.95 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 362.47 ns |  17.868 ns | 0.979 ns | 361.88 ns | 363.60 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.84 ns |  22.882 ns | 1.254 ns | 272.93 ns | 275.27 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.66 ns |   5.852 ns | 0.321 ns | 134.35 ns | 134.99 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 135.47 ns |  10.400 ns | 0.570 ns | 134.91 ns | 136.05 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 368.50 ns | 110.733 ns | 6.070 ns | 362.09 ns | 374.15 ns | 0.0057 |     504 B |
