```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.34 ns** |  **0.527 ns** | **0.029 ns** |  **17.32 ns** |  **17.37 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.40 ns | 10.117 ns | 0.555 ns | 122.08 ns | 123.04 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.04 ns |  4.383 ns | 0.240 ns | 116.83 ns | 117.30 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.31 ns |  1.733 ns | 0.095 ns |  92.23 ns |  92.42 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.09 ns |  1.434 ns | 0.079 ns |  44.01 ns |  44.16 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.12 ns |  5.228 ns | 0.287 ns |  43.91 ns |  44.44 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.49 ns | 22.676 ns | 1.243 ns | 116.22 ns | 118.70 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.17 ns** |  **2.040 ns** | **0.112 ns** |  **54.07 ns** |  **54.29 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 364.96 ns | 15.503 ns | 0.850 ns | 364.01 ns | 365.66 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 342.62 ns | 20.742 ns | 1.137 ns | 341.56 ns | 343.82 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 271.77 ns | 11.033 ns | 0.605 ns | 271.08 ns | 272.12 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.65 ns | 29.776 ns | 1.632 ns | 133.69 ns | 136.53 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 135.04 ns |  8.072 ns | 0.442 ns | 134.59 ns | 135.47 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 370.79 ns | 20.331 ns | 1.114 ns | 370.06 ns | 372.07 ns | 0.0057 |     504 B |
