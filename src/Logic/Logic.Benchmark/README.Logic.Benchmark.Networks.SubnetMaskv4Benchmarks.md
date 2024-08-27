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
| **FromPrefix**          | **1**      |  **17.60 ns** |  **0.163 ns** | **0.009 ns** |  **17.59 ns** |  **17.61 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 118.89 ns |  4.975 ns | 0.273 ns | 118.62 ns | 119.17 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.14 ns |  3.504 ns | 0.192 ns | 114.98 ns | 115.35 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  92.29 ns |  5.840 ns | 0.320 ns |  92.03 ns |  92.64 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.53 ns |  3.017 ns | 0.165 ns |  44.42 ns |  44.72 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.32 ns |  0.675 ns | 0.037 ns |  44.28 ns |  44.35 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.68 ns | 47.322 ns | 2.594 ns | 116.79 ns | 121.64 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.60 ns** |  **3.599 ns** | **0.197 ns** |  **54.44 ns** |  **54.82 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.07 ns |  9.750 ns | 0.534 ns | 374.45 ns | 375.43 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.79 ns | 20.912 ns | 1.146 ns | 355.48 ns | 357.58 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.16 ns | 25.752 ns | 1.412 ns | 280.71 ns | 283.53 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.21 ns |  1.660 ns | 0.091 ns | 133.14 ns | 133.31 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.92 ns | 39.589 ns | 2.170 ns | 135.41 ns | 139.27 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 362.45 ns | 62.364 ns | 3.418 ns | 358.98 ns | 365.82 ns | 0.0057 |     504 B |
