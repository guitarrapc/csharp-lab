```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.66 ns** |  **2.510 ns** | **0.138 ns** |  **17.52 ns** |  **17.79 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.46 ns |  4.567 ns | 0.250 ns | 122.24 ns | 122.73 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.64 ns | 55.292 ns | 3.031 ns | 116.07 ns | 121.98 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.85 ns |  4.241 ns | 0.232 ns |  89.59 ns |  90.03 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.62 ns |  2.489 ns | 0.136 ns |  44.47 ns |  44.74 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.64 ns |  5.689 ns | 0.312 ns |  43.43 ns |  44.00 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.04 ns |  3.982 ns | 0.218 ns | 117.79 ns | 118.18 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.84 ns** |  **8.144 ns** | **0.446 ns** |  **55.33 ns** |  **56.16 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 371.29 ns | 25.513 ns | 1.398 ns | 369.83 ns | 372.61 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.47 ns |  5.132 ns | 0.281 ns | 356.22 ns | 356.78 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 285.36 ns | 86.637 ns | 4.749 ns | 282.49 ns | 290.84 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.98 ns | 17.860 ns | 0.979 ns | 135.02 ns | 136.98 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.67 ns |  5.214 ns | 0.286 ns | 139.49 ns | 140.00 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 375.25 ns | 67.668 ns | 3.709 ns | 371.21 ns | 378.49 ns | 0.0057 |     504 B |
