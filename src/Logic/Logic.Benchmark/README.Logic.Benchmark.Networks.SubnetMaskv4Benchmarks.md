```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.13 ns** |  **0.540 ns** | **0.030 ns** |  **18.10 ns** |  **18.15 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 124.32 ns |  4.676 ns | 0.256 ns | 124.14 ns | 124.61 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.06 ns | 24.603 ns | 1.349 ns | 116.10 ns | 118.60 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  93.96 ns |  1.405 ns | 0.077 ns |  93.91 ns |  94.05 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.72 ns |  0.230 ns | 0.013 ns |  44.70 ns |  44.73 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.89 ns |  2.252 ns | 0.123 ns |  44.81 ns |  45.03 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.81 ns | 13.323 ns | 0.730 ns | 118.02 ns | 119.45 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.91 ns** |  **0.866 ns** | **0.047 ns** |  **55.85 ns** |  **55.94 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 373.56 ns | 12.215 ns | 0.670 ns | 372.88 ns | 374.22 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 355.00 ns |  3.757 ns | 0.206 ns | 354.80 ns | 355.21 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.83 ns |  5.102 ns | 0.280 ns | 274.51 ns | 275.02 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.68 ns |  9.077 ns | 0.498 ns | 136.24 ns | 137.22 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.07 ns |  4.781 ns | 0.262 ns | 139.89 ns | 140.37 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 373.85 ns | 38.203 ns | 2.094 ns | 371.55 ns | 375.66 ns | 0.0057 |     504 B |
