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
| **FromPrefix**          | **1**      |  **21.69 ns** |  **1.407 ns** | **0.077 ns** |  **21.60 ns** |  **21.74 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.69 ns |  3.500 ns | 0.192 ns | 123.48 ns | 123.86 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.22 ns |  5.635 ns | 0.309 ns | 115.87 ns | 116.46 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  91.63 ns |  4.635 ns | 0.254 ns |  91.47 ns |  91.92 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.45 ns |  4.712 ns | 0.258 ns |  44.28 ns |  44.75 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.31 ns |  5.146 ns | 0.282 ns |  44.05 ns |  44.61 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 116.92 ns |  6.439 ns | 0.353 ns | 116.68 ns | 117.33 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.30 ns** |  **4.805 ns** | **0.263 ns** |  **53.99 ns** |  **54.47 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 372.88 ns | 18.762 ns | 1.028 ns | 372.16 ns | 374.06 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.88 ns |  5.187 ns | 0.284 ns | 352.56 ns | 353.08 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 271.18 ns |  7.587 ns | 0.416 ns | 270.94 ns | 271.66 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.03 ns | 11.944 ns | 0.655 ns | 134.35 ns | 135.66 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.61 ns | 34.532 ns | 1.893 ns | 136.45 ns | 140.01 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 374.82 ns | 15.622 ns | 0.856 ns | 374.06 ns | 375.75 ns | 0.0057 |     504 B |
