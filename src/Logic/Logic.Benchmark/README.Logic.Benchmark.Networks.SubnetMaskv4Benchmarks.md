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
| **FromPrefix**          | **1**      |  **17.82 ns** |  **1.924 ns** | **0.105 ns** |  **17.74 ns** |  **17.94 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.03 ns |  1.018 ns | 0.056 ns | 121.99 ns | 122.09 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.71 ns |  1.630 ns | 0.089 ns | 117.61 ns | 117.78 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.46 ns |  5.960 ns | 0.327 ns |  89.21 ns |  89.83 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.09 ns |  2.137 ns | 0.117 ns |  44.98 ns |  45.21 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.27 ns |  0.216 ns | 0.012 ns |  43.26 ns |  43.28 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.46 ns | 42.484 ns | 2.329 ns | 118.82 ns | 123.22 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.10 ns** |  **5.627 ns** | **0.308 ns** |  **54.79 ns** |  **55.41 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 372.97 ns | 15.254 ns | 0.836 ns | 372.19 ns | 373.85 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 357.36 ns | 17.888 ns | 0.981 ns | 356.74 ns | 358.49 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.90 ns |  9.368 ns | 0.514 ns | 280.43 ns | 281.45 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.68 ns | 14.281 ns | 0.783 ns | 134.80 ns | 136.31 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.44 ns |  1.242 ns | 0.068 ns | 136.38 ns | 136.51 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 370.71 ns | 55.520 ns | 3.043 ns | 367.71 ns | 373.80 ns | 0.0057 |     504 B |
