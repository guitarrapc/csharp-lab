```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.67 ns** |  **2.518 ns** | **0.138 ns** |  **17.51 ns** |  **17.75 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.64 ns | 19.279 ns | 1.057 ns | 119.97 ns | 121.86 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.94 ns | 16.425 ns | 0.900 ns | 117.20 ns | 118.94 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.82 ns |  1.046 ns | 0.057 ns |  93.76 ns |  93.87 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.85 ns |  1.156 ns | 0.063 ns |  44.79 ns |  44.92 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  42.70 ns |  2.466 ns | 0.135 ns |  42.60 ns |  42.85 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.40 ns | 17.194 ns | 0.942 ns | 120.40 ns | 122.27 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.86 ns** |  **2.263 ns** | **0.124 ns** |  **55.74 ns** |  **55.98 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 367.02 ns | 27.728 ns | 1.520 ns | 365.56 ns | 368.59 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 363.03 ns | 16.705 ns | 0.916 ns | 362.36 ns | 364.07 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 290.44 ns |  9.695 ns | 0.531 ns | 290.08 ns | 291.05 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.81 ns | 12.610 ns | 0.691 ns | 133.38 ns | 134.60 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.83 ns | 10.083 ns | 0.553 ns | 136.20 ns | 137.24 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 361.68 ns | 25.477 ns | 1.396 ns | 360.14 ns | 362.87 ns | 0.0057 |     504 B |
