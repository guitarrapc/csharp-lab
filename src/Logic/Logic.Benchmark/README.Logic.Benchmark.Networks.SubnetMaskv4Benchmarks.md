```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.59 ns** |  **1.908 ns** | **0.105 ns** |  **17.51 ns** |  **17.71 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.50 ns | 32.311 ns | 1.771 ns | 119.98 ns | 123.44 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.30 ns |  2.616 ns | 0.143 ns | 115.18 ns | 115.46 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  92.49 ns |  2.632 ns | 0.144 ns |  92.35 ns |  92.64 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.07 ns |  2.018 ns | 0.111 ns |  44.94 ns |  45.16 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.27 ns |  1.940 ns | 0.106 ns |  44.18 ns |  44.39 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.96 ns | 69.327 ns | 3.800 ns | 116.69 ns | 123.99 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.61 ns** |  **2.024 ns** | **0.111 ns** |  **54.48 ns** |  **54.70 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 362.56 ns | 17.478 ns | 0.958 ns | 361.87 ns | 363.66 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.35 ns |  4.236 ns | 0.232 ns | 349.21 ns | 349.62 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.81 ns |  6.421 ns | 0.352 ns | 273.53 ns | 274.20 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.12 ns |  3.087 ns | 0.169 ns | 136.00 ns | 136.32 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.44 ns | 44.996 ns | 2.466 ns | 134.60 ns | 138.95 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 362.98 ns | 38.579 ns | 2.115 ns | 361.53 ns | 365.40 ns | 0.0057 |     504 B |
