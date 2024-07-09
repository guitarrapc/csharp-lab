```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.39 ns** |  **0.337 ns** | **0.018 ns** |  **17.38 ns** |  **17.41 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.84 ns | 46.744 ns | 2.562 ns | 118.97 ns | 123.76 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.01 ns |  7.099 ns | 0.389 ns | 117.57 ns | 118.29 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.87 ns |  0.239 ns | 0.013 ns |  91.86 ns |  91.88 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  48.66 ns |  0.692 ns | 0.038 ns |  48.62 ns |  48.70 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.67 ns | 35.819 ns | 1.963 ns |  43.05 ns |  46.86 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.29 ns | 18.293 ns | 1.003 ns | 122.20 ns | 124.18 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.04 ns** |  **2.882 ns** | **0.158 ns** |  **54.87 ns** |  **55.18 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.29 ns |  4.682 ns | 0.257 ns | 374.03 ns | 374.55 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 357.04 ns | 11.951 ns | 0.655 ns | 356.65 ns | 357.80 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 284.62 ns | 10.980 ns | 0.602 ns | 284.26 ns | 285.32 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.64 ns | 13.297 ns | 0.729 ns | 134.90 ns | 136.36 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.65 ns | 58.515 ns | 3.207 ns | 138.13 ns | 144.26 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.21 ns | 99.204 ns | 5.438 ns | 364.03 ns | 373.49 ns | 0.0057 |     504 B |
