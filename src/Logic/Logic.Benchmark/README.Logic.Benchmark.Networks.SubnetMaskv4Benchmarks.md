```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.70 ns** |  **1.863 ns** | **0.102 ns** |  **17.60 ns** |  **17.81 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.01 ns |  3.198 ns | 0.175 ns | 121.88 ns | 122.21 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.88 ns |  5.865 ns | 0.322 ns | 118.66 ns | 119.25 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.17 ns |  4.100 ns | 0.225 ns |  90.92 ns |  91.36 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.02 ns |  1.617 ns | 0.089 ns |  44.92 ns |  45.09 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.53 ns |  4.136 ns | 0.227 ns |  43.40 ns |  43.80 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.44 ns | 16.996 ns | 0.932 ns | 118.70 ns | 120.49 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.27 ns** |  **1.143 ns** | **0.063 ns** |  **55.21 ns** |  **55.33 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 368.78 ns |  9.313 ns | 0.510 ns | 368.23 ns | 369.24 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.33 ns | 11.703 ns | 0.641 ns | 355.68 ns | 356.96 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 272.46 ns | 18.029 ns | 0.988 ns | 271.77 ns | 273.59 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.88 ns |  3.132 ns | 0.172 ns | 134.77 ns | 135.08 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.46 ns | 20.080 ns | 1.101 ns | 139.60 ns | 141.70 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 373.54 ns | 40.962 ns | 2.245 ns | 370.95 ns | 374.90 ns | 0.0057 |     504 B |
