```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.86 ns** |  **1.260 ns** | **0.069 ns** |  **17.81 ns** |  **17.94 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.33 ns |  5.769 ns | 0.316 ns | 120.96 ns | 121.51 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 128.06 ns |  5.656 ns | 0.310 ns | 127.76 ns | 128.38 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.33 ns |  0.814 ns | 0.045 ns |  90.29 ns |  90.38 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.81 ns |  2.432 ns | 0.133 ns |  44.66 ns |  44.92 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.97 ns |  1.605 ns | 0.088 ns |  44.87 ns |  45.03 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.29 ns | 59.620 ns | 3.268 ns | 117.81 ns | 124.00 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.91 ns** |  **6.037 ns** | **0.331 ns** |  **55.59 ns** |  **56.25 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 373.26 ns |  9.591 ns | 0.526 ns | 372.92 ns | 373.87 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 346.39 ns |  5.123 ns | 0.281 ns | 346.17 ns | 346.71 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.61 ns |  8.572 ns | 0.470 ns | 273.27 ns | 274.15 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.85 ns |  9.583 ns | 0.525 ns | 135.39 ns | 136.42 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.16 ns | 42.307 ns | 2.319 ns | 136.42 ns | 140.79 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.93 ns | 85.924 ns | 4.710 ns | 364.50 ns | 372.88 ns | 0.0057 |     504 B |
