```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.03 ns** |  **3.512 ns** | **0.193 ns** |  **17.89 ns** |  **18.25 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.95 ns | 17.738 ns | 0.972 ns | 120.17 ns | 122.04 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 120.12 ns | 17.991 ns | 0.986 ns | 119.16 ns | 121.13 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.42 ns |  5.487 ns | 0.301 ns |  91.23 ns |  91.77 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.35 ns |  1.751 ns | 0.096 ns |  45.29 ns |  45.46 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.68 ns | 20.253 ns | 1.110 ns |  44.40 ns |  46.44 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.21 ns | 19.377 ns | 1.062 ns | 124.00 ns | 125.99 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.40 ns** |  **6.538 ns** | **0.358 ns** |  **56.09 ns** |  **56.79 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 380.15 ns | 19.627 ns | 1.076 ns | 378.94 ns | 381.01 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.72 ns | 27.975 ns | 1.533 ns | 358.42 ns | 361.41 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 288.24 ns | 42.822 ns | 2.347 ns | 286.83 ns | 290.95 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.08 ns |  9.529 ns | 0.522 ns | 135.77 ns | 136.69 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.73 ns | 11.074 ns | 0.607 ns | 137.38 ns | 138.44 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 370.35 ns | 16.436 ns | 0.901 ns | 369.51 ns | 371.30 ns | 0.0057 |     504 B |
