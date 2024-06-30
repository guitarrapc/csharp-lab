```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.53 ns** |  **0.623 ns** | **0.034 ns** |  **17.49 ns** |  **17.56 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.81 ns |  4.516 ns | 0.248 ns | 121.53 ns | 122.00 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.39 ns |  4.806 ns | 0.263 ns | 115.09 ns | 115.58 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  92.36 ns |  4.291 ns | 0.235 ns |  92.10 ns |  92.54 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.18 ns | 17.532 ns | 0.961 ns |  44.58 ns |  46.29 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.50 ns | 25.774 ns | 1.413 ns |  44.19 ns |  47.00 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.76 ns |  8.711 ns | 0.477 ns | 120.22 ns | 121.13 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.51 ns** |  **2.982 ns** | **0.163 ns** |  **55.33 ns** |  **55.66 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 379.59 ns | 88.532 ns | 4.853 ns | 375.91 ns | 385.09 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 347.12 ns |  5.878 ns | 0.322 ns | 346.86 ns | 347.48 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.05 ns | 18.166 ns | 0.996 ns | 281.27 ns | 283.17 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.60 ns |  7.543 ns | 0.413 ns | 136.17 ns | 137.00 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.82 ns | 62.422 ns | 3.422 ns | 135.42 ns | 142.27 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 364.50 ns | 58.090 ns | 3.184 ns | 361.79 ns | 368.01 ns | 0.0057 |     504 B |
