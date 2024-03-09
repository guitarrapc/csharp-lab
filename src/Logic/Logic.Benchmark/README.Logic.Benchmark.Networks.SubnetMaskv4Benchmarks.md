```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.35 ns** |  **0.866 ns** | **0.047 ns** |  **17.32 ns** |  **17.41 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.84 ns |  7.089 ns | 0.389 ns | 123.57 ns | 124.29 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.81 ns |  1.545 ns | 0.085 ns | 115.74 ns | 115.90 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  92.73 ns |  2.437 ns | 0.134 ns |  92.60 ns |  92.87 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.82 ns |  1.760 ns | 0.096 ns |  44.74 ns |  44.93 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  46.02 ns | 15.691 ns | 0.860 ns |  45.27 ns |  46.96 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.55 ns | 42.367 ns | 2.322 ns | 122.50 ns | 127.07 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.12 ns** | **14.106 ns** | **0.773 ns** |  **53.59 ns** |  **55.01 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 361.55 ns |  9.858 ns | 0.540 ns | 360.98 ns | 362.06 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.08 ns | 17.958 ns | 0.984 ns | 358.49 ns | 360.21 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.93 ns | 16.371 ns | 0.897 ns | 275.40 ns | 276.96 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.84 ns | 38.273 ns | 2.098 ns | 133.49 ns | 137.52 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.46 ns | 14.066 ns | 0.771 ns | 138.91 ns | 140.34 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 364.36 ns | 28.461 ns | 1.560 ns | 362.99 ns | 366.06 ns | 0.0057 |     504 B |
