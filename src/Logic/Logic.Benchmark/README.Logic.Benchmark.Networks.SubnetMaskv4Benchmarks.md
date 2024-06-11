```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.50 ns** |  **1.193 ns** | **0.065 ns** |  **17.42 ns** |  **17.54 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.37 ns |  3.680 ns | 0.202 ns | 120.15 ns | 120.55 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.81 ns |  4.446 ns | 0.244 ns | 119.53 ns | 119.98 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.05 ns |  1.029 ns | 0.056 ns |  92.00 ns |  92.11 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.57 ns |  8.131 ns | 0.446 ns |  45.29 ns |  46.08 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.56 ns |  7.670 ns | 0.420 ns |  44.16 ns |  45.00 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.74 ns | 11.260 ns | 0.617 ns | 123.18 ns | 124.40 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.83 ns** |  **2.794 ns** | **0.153 ns** |  **54.69 ns** |  **54.99 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 368.26 ns |  5.674 ns | 0.311 ns | 367.91 ns | 368.51 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.08 ns | 12.679 ns | 0.695 ns | 349.47 ns | 350.84 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 284.87 ns |  3.764 ns | 0.206 ns | 284.64 ns | 285.04 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.65 ns |  4.135 ns | 0.227 ns | 134.47 ns | 134.90 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.08 ns |  2.682 ns | 0.147 ns | 138.91 ns | 139.17 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.70 ns | 44.383 ns | 2.433 ns | 362.90 ns | 367.28 ns | 0.0057 |     504 B |
