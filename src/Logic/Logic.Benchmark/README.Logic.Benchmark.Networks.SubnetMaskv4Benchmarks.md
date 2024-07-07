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
| **FromPrefix**          | **1**      |  **17.43 ns** |  **1.645 ns** | **0.090 ns** |  **17.37 ns** |  **17.53 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.07 ns |  2.195 ns | 0.120 ns | 121.98 ns | 122.21 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.32 ns |  6.165 ns | 0.338 ns | 116.12 ns | 116.71 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  91.64 ns | 32.780 ns | 1.797 ns |  90.55 ns |  93.71 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.56 ns |  3.735 ns | 0.205 ns |  45.33 ns |  45.70 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.50 ns | 15.656 ns | 0.858 ns |  44.54 ns |  46.19 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.82 ns | 65.333 ns | 3.581 ns | 123.16 ns | 129.90 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.38 ns** |  **5.725 ns** | **0.314 ns** |  **55.04 ns** |  **55.66 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.33 ns |  7.329 ns | 0.402 ns | 375.89 ns | 376.67 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.70 ns |  9.325 ns | 0.511 ns | 356.35 ns | 357.29 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 278.66 ns | 98.904 ns | 5.421 ns | 275.33 ns | 284.92 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.67 ns |  1.470 ns | 0.081 ns | 133.59 ns | 133.75 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.73 ns | 26.159 ns | 1.434 ns | 137.33 ns | 140.19 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 363.85 ns | 40.391 ns | 2.214 ns | 361.64 ns | 366.07 ns | 0.0057 |     504 B |
