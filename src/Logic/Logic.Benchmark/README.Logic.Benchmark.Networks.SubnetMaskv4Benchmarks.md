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
| **FromPrefix**          | **1**      |  **17.61 ns** |  **1.046 ns** | **0.057 ns** |  **17.57 ns** |  **17.67 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.92 ns | 23.512 ns | 1.289 ns | 121.17 ns | 123.41 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.92 ns |  3.869 ns | 0.212 ns | 118.79 ns | 119.17 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.77 ns |  9.268 ns | 0.508 ns |  92.36 ns |  93.34 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.16 ns |  0.101 ns | 0.006 ns |  45.16 ns |  45.17 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.86 ns | 29.700 ns | 1.628 ns |  44.85 ns |  47.74 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.32 ns | 17.466 ns | 0.957 ns | 123.61 ns | 125.41 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.70 ns** |  **1.701 ns** | **0.093 ns** |  **55.61 ns** |  **55.80 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.46 ns | 12.618 ns | 0.692 ns | 375.04 ns | 376.26 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.01 ns | 18.665 ns | 1.023 ns | 358.22 ns | 360.17 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 286.06 ns | 23.817 ns | 1.305 ns | 285.17 ns | 287.56 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.14 ns |  2.495 ns | 0.137 ns | 136.01 ns | 136.29 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.01 ns |  4.106 ns | 0.225 ns | 136.79 ns | 137.24 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 364.07 ns | 42.658 ns | 2.338 ns | 361.37 ns | 365.45 ns | 0.0057 |     504 B |
