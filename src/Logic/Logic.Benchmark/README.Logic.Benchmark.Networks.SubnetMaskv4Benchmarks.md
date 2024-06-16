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
| **FromPrefix**          | **1**      |  **17.31 ns** |  **0.681 ns** | **0.037 ns** |  **17.29 ns** |  **17.36 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 126.21 ns | 45.467 ns | 2.492 ns | 124.61 ns | 129.08 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.69 ns |  2.002 ns | 0.110 ns | 115.63 ns | 115.82 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.87 ns |  1.772 ns | 0.097 ns |  89.77 ns |  89.96 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.77 ns |  0.875 ns | 0.048 ns |  44.72 ns |  44.81 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.50 ns | 16.978 ns | 0.931 ns |  43.89 ns |  45.57 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.90 ns | 27.159 ns | 1.489 ns | 121.79 ns | 124.59 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.01 ns** |  **1.378 ns** | **0.076 ns** |  **54.94 ns** |  **55.09 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.31 ns | 11.620 ns | 0.637 ns | 365.85 ns | 367.04 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.75 ns | 18.202 ns | 0.998 ns | 358.61 ns | 360.45 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.61 ns | 12.199 ns | 0.669 ns | 274.91 ns | 276.24 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.89 ns |  4.905 ns | 0.269 ns | 133.58 ns | 134.06 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.00 ns | 66.962 ns | 3.670 ns | 136.38 ns | 143.19 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 363.05 ns | 39.935 ns | 2.189 ns | 360.57 ns | 364.70 ns | 0.0057 |     504 B |
