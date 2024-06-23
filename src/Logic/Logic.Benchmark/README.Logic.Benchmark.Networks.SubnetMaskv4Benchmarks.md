```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.28 ns** |   **0.649 ns** | **0.036 ns** |  **17.24 ns** |  **17.31 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.33 ns |   2.352 ns | 0.129 ns | 120.21 ns | 120.46 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.26 ns |  19.797 ns | 1.085 ns | 118.57 ns | 120.52 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.33 ns |   7.901 ns | 0.433 ns |  92.05 ns |  92.82 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.95 ns |   1.688 ns | 0.093 ns |  44.89 ns |  45.05 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.09 ns |  14.907 ns | 0.817 ns |  44.15 ns |  45.64 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 128.34 ns | 165.534 ns | 9.073 ns | 117.87 ns | 133.72 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.13 ns** |   **3.127 ns** | **0.171 ns** |  **54.93 ns** |  **55.25 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.83 ns |   4.767 ns | 0.261 ns | 374.55 ns | 375.07 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 346.01 ns |  18.902 ns | 1.036 ns | 345.04 ns | 347.10 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 277.38 ns |  18.118 ns | 0.993 ns | 276.52 ns | 278.47 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.13 ns |  13.588 ns | 0.745 ns | 134.41 ns | 135.90 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.51 ns |   2.399 ns | 0.132 ns | 136.40 ns | 136.66 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 364.78 ns |  67.366 ns | 3.693 ns | 361.30 ns | 368.65 ns | 0.0057 |     504 B |
