```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.21 ns** |  **1.206 ns** | **0.066 ns** |  **17.14 ns** |  **17.28 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.30 ns |  3.007 ns | 0.165 ns | 121.11 ns | 121.40 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.03 ns |  0.986 ns | 0.054 ns | 114.96 ns | 115.06 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.21 ns |  4.446 ns | 0.244 ns |  89.00 ns |  89.48 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.26 ns |  2.164 ns | 0.119 ns |  44.16 ns |  44.39 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.91 ns |  0.658 ns | 0.036 ns |  43.88 ns |  43.95 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.53 ns | 11.461 ns | 0.628 ns | 118.81 ns | 119.90 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.17 ns** |  **2.535 ns** | **0.139 ns** |  **54.06 ns** |  **54.33 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 370.02 ns | 23.414 ns | 1.283 ns | 369.24 ns | 371.50 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 343.65 ns |  8.498 ns | 0.466 ns | 343.29 ns | 344.17 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 271.61 ns |  7.425 ns | 0.407 ns | 271.37 ns | 272.08 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.19 ns | 19.380 ns | 1.062 ns | 132.97 ns | 134.91 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.03 ns |  5.607 ns | 0.307 ns | 136.71 ns | 137.33 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 373.12 ns | 26.585 ns | 1.457 ns | 371.73 ns | 374.64 ns | 0.0057 |     504 B |
