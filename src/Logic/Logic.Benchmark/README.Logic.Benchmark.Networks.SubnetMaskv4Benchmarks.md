```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.09 ns** |   **2.095 ns** | **0.115 ns** |  **17.99 ns** |  **18.21 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.84 ns |  10.280 ns | 0.563 ns | 119.20 ns | 120.27 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.01 ns |   7.397 ns | 0.405 ns | 118.58 ns | 119.38 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.35 ns |   3.858 ns | 0.211 ns |  89.17 ns |  89.58 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.70 ns |   1.056 ns | 0.058 ns |  45.66 ns |  45.76 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.09 ns |   2.211 ns | 0.121 ns |  44.98 ns |  45.22 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.42 ns |  43.729 ns | 2.397 ns | 119.91 ns | 124.18 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.02 ns** |   **5.707 ns** | **0.313 ns** |  **55.83 ns** |  **56.38 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.35 ns |   4.486 ns | 0.246 ns | 376.08 ns | 376.56 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.08 ns |  18.745 ns | 1.027 ns | 358.03 ns | 360.09 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.24 ns |   5.217 ns | 0.286 ns | 273.98 ns | 274.55 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 142.31 ns |  12.153 ns | 0.666 ns | 141.74 ns | 143.04 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.51 ns |  17.994 ns | 0.986 ns | 136.90 ns | 138.65 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 372.01 ns | 151.641 ns | 8.312 ns | 362.82 ns | 379.01 ns | 0.0057 |     504 B |
