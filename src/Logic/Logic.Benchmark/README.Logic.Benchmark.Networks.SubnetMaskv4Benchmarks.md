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
| **FromPrefix**          | **1**      |  **17.86 ns** |  **0.835 ns** | **0.046 ns** |  **17.81 ns** |  **17.91 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.83 ns |  4.918 ns | 0.270 ns | 125.64 ns | 126.13 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.12 ns | 21.419 ns | 1.174 ns | 118.03 ns | 120.36 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.62 ns |  2.918 ns | 0.160 ns |  89.51 ns |  89.80 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.64 ns |  0.558 ns | 0.031 ns |  44.61 ns |  44.67 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.77 ns |  1.981 ns | 0.109 ns |  44.65 ns |  44.86 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.92 ns | 64.703 ns | 3.547 ns | 116.74 ns | 123.01 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.36 ns** |  **6.920 ns** | **0.379 ns** |  **54.92 ns** |  **55.60 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.23 ns |  9.127 ns | 0.500 ns | 365.88 ns | 366.81 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.76 ns | 13.413 ns | 0.735 ns | 358.08 ns | 359.54 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 283.90 ns | 21.393 ns | 1.173 ns | 282.57 ns | 284.78 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.82 ns |  7.252 ns | 0.397 ns | 135.54 ns | 136.27 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.64 ns | 12.254 ns | 0.672 ns | 136.20 ns | 137.41 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 368.07 ns | 30.644 ns | 1.680 ns | 366.15 ns | 369.21 ns | 0.0057 |     504 B |
