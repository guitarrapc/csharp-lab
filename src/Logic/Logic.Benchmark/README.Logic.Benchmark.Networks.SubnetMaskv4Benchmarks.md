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
| **FromPrefix**          | **1**      |  **17.56 ns** |  **1.031 ns** | **0.056 ns** |  **17.52 ns** |  **17.63 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.19 ns | 25.992 ns | 1.425 ns | 121.34 ns | 123.83 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.53 ns |  7.203 ns | 0.395 ns | 118.28 ns | 118.99 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.19 ns | 15.247 ns | 0.836 ns |  89.61 ns |  91.15 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.43 ns |  4.626 ns | 0.254 ns |  44.27 ns |  44.72 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.59 ns |  1.093 ns | 0.060 ns |  44.52 ns |  44.64 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.67 ns | 27.899 ns | 1.529 ns | 117.50 ns | 120.40 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.24 ns** |  **2.710 ns** | **0.149 ns** |  **55.09 ns** |  **55.38 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.96 ns | 51.320 ns | 2.813 ns | 363.79 ns | 369.16 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 361.41 ns | 36.427 ns | 1.997 ns | 359.23 ns | 363.15 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 286.70 ns |  7.031 ns | 0.385 ns | 286.34 ns | 287.10 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.56 ns |  2.602 ns | 0.143 ns | 134.44 ns | 134.71 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.30 ns |  5.541 ns | 0.304 ns | 139.06 ns | 139.64 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 374.99 ns | 56.249 ns | 3.083 ns | 371.45 ns | 377.07 ns | 0.0057 |     504 B |
