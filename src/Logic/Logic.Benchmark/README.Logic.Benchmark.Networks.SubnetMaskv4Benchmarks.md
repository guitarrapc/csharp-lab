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
| **FromPrefix**          | **1**      |  **17.14 ns** |  **0.297 ns** | **0.016 ns** |  **17.12 ns** |  **17.15 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 130.37 ns |  1.256 ns | 0.069 ns | 130.29 ns | 130.42 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.04 ns |  3.947 ns | 0.216 ns | 115.79 ns | 116.20 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.17 ns |  2.392 ns | 0.131 ns |  89.02 ns |  89.26 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.41 ns |  1.110 ns | 0.061 ns |  44.36 ns |  44.47 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.68 ns |  2.834 ns | 0.155 ns |  43.53 ns |  43.84 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.41 ns | 10.686 ns | 0.586 ns | 117.76 ns | 118.90 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.38 ns** |  **2.601 ns** | **0.143 ns** |  **54.22 ns** |  **54.49 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 380.78 ns | 34.112 ns | 1.870 ns | 379.53 ns | 382.93 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 348.88 ns | 20.672 ns | 1.133 ns | 347.95 ns | 350.14 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 272.64 ns | 31.260 ns | 1.713 ns | 271.43 ns | 274.60 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 139.37 ns |  3.999 ns | 0.219 ns | 139.23 ns | 139.62 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 141.88 ns |  3.565 ns | 0.195 ns | 141.70 ns | 142.09 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.62 ns | 73.223 ns | 4.014 ns | 363.27 ns | 371.19 ns | 0.0057 |     504 B |
