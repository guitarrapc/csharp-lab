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
| **FromPrefix**          | **1**      |  **17.72 ns** |  **2.256 ns** | **0.124 ns** |  **17.65 ns** |  **17.86 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 124.84 ns |  2.547 ns | 0.140 ns | 124.68 ns | 124.92 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.68 ns |  1.927 ns | 0.106 ns | 115.57 ns | 115.79 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  88.94 ns |  1.792 ns | 0.098 ns |  88.87 ns |  89.05 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.77 ns |  0.939 ns | 0.051 ns |  44.72 ns |  44.82 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.13 ns |  6.509 ns | 0.357 ns |  43.82 ns |  44.52 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.61 ns | 25.681 ns | 1.408 ns | 116.31 ns | 119.10 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.48 ns** |  **9.331 ns** | **0.511 ns** |  **55.05 ns** |  **56.05 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 368.99 ns |  8.325 ns | 0.456 ns | 368.46 ns | 369.29 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.32 ns | 43.304 ns | 2.374 ns | 357.70 ns | 362.04 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.21 ns |  9.532 ns | 0.522 ns | 286.67 ns | 287.71 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.15 ns | 10.409 ns | 0.571 ns | 134.69 ns | 135.79 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.84 ns | 30.137 ns | 1.652 ns | 136.56 ns | 139.71 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 375.36 ns | 41.458 ns | 2.272 ns | 372.74 ns | 376.78 ns | 0.0057 |     504 B |
