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
| **FromPrefix**          | **1**      |  **17.82 ns** |  **1.238 ns** | **0.068 ns** |  **17.75 ns** |  **17.88 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.46 ns |  5.062 ns | 0.277 ns | 120.20 ns | 120.75 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.67 ns |  6.073 ns | 0.333 ns | 117.48 ns | 118.06 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  95.22 ns | 52.517 ns | 2.879 ns |  92.71 ns |  98.36 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  46.15 ns |  1.220 ns | 0.067 ns |  46.11 ns |  46.23 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.78 ns | 16.624 ns | 0.911 ns |  44.72 ns |  46.32 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.24 ns | 80.075 ns | 4.389 ns | 120.34 ns | 128.82 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.28 ns** |  **3.070 ns** | **0.168 ns** |  **56.09 ns** |  **56.41 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 377.87 ns | 31.891 ns | 1.748 ns | 375.85 ns | 378.90 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 354.69 ns | 12.527 ns | 0.687 ns | 354.25 ns | 355.48 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.11 ns | 12.217 ns | 0.670 ns | 279.44 ns | 280.78 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 140.65 ns |  0.208 ns | 0.011 ns | 140.64 ns | 140.66 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.58 ns | 78.977 ns | 4.329 ns | 136.75 ns | 144.56 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 370.00 ns | 32.419 ns | 1.777 ns | 367.95 ns | 371.06 ns | 0.0057 |     504 B |
