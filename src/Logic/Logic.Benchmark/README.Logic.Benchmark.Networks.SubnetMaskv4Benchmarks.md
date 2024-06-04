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
| **FromPrefix**          | **1**      |  **17.61 ns** |  **1.621 ns** | **0.089 ns** |  **17.55 ns** |  **17.71 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 129.68 ns | 88.258 ns | 4.838 ns | 124.10 ns | 132.64 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.67 ns | 11.576 ns | 0.635 ns | 118.08 ns | 119.34 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.90 ns | 56.012 ns | 3.070 ns |  92.12 ns |  97.44 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.96 ns |  3.560 ns | 0.195 ns |  44.79 ns |  45.18 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.92 ns | 28.687 ns | 1.572 ns |  43.99 ns |  46.74 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.17 ns | 29.648 ns | 1.625 ns | 122.19 ns | 125.04 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.33 ns** |  **5.235 ns** | **0.287 ns** |  **55.10 ns** |  **55.65 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 364.79 ns | 19.147 ns | 1.050 ns | 363.65 ns | 365.71 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.04 ns | 28.520 ns | 1.563 ns | 356.60 ns | 359.71 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.94 ns | 23.770 ns | 1.303 ns | 281.88 ns | 284.39 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.28 ns |  4.103 ns | 0.225 ns | 135.07 ns | 135.52 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.99 ns | 13.588 ns | 0.745 ns | 138.23 ns | 139.72 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.97 ns | 95.784 ns | 5.250 ns | 364.46 ns | 374.01 ns | 0.0057 |     504 B |
