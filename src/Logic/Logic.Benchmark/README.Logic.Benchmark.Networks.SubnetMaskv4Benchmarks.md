```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.84 ns** |  **1.839 ns** | **0.101 ns** |  **17.72 ns** |  **17.91 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.74 ns |  3.112 ns | 0.171 ns | 119.58 ns | 119.92 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.32 ns |  4.106 ns | 0.225 ns | 118.08 ns | 118.52 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.71 ns |  6.264 ns | 0.343 ns |  89.32 ns |  89.97 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.49 ns |  3.226 ns | 0.177 ns |  45.30 ns |  45.65 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.97 ns |  4.104 ns | 0.225 ns |  44.81 ns |  45.23 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.08 ns | 35.466 ns | 1.944 ns | 117.88 ns | 121.59 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.91 ns** |  **6.409 ns** | **0.351 ns** |  **55.52 ns** |  **56.21 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 367.16 ns |  8.108 ns | 0.444 ns | 366.75 ns | 367.63 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 350.21 ns | 33.781 ns | 1.852 ns | 348.72 ns | 352.28 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.95 ns | 39.342 ns | 2.156 ns | 274.67 ns | 278.44 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.58 ns |  9.592 ns | 0.526 ns | 134.99 ns | 136.00 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.96 ns | 55.919 ns | 3.065 ns | 136.17 ns | 141.50 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 372.36 ns | 55.794 ns | 3.058 ns | 370.34 ns | 375.88 ns | 0.0057 |     504 B |
