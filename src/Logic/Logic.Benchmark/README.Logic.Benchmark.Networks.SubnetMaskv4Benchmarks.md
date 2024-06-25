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
| **FromPrefix**          | **1**      |  **18.01 ns** |  **8.194 ns** | **0.449 ns** |  **17.49 ns** |  **18.29 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.16 ns |  8.572 ns | 0.470 ns | 119.74 ns | 120.67 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.62 ns |  3.688 ns | 0.202 ns | 116.46 ns | 116.85 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.53 ns |  0.701 ns | 0.038 ns |  89.49 ns |  89.56 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.95 ns |  5.514 ns | 0.302 ns |  44.76 ns |  45.30 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.43 ns | 41.063 ns | 2.251 ns |  42.83 ns |  47.01 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.91 ns | 16.401 ns | 0.899 ns | 120.91 ns | 122.64 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.60 ns** |  **5.690 ns** | **0.312 ns** |  **54.35 ns** |  **54.95 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 365.92 ns | 16.262 ns | 0.891 ns | 364.90 ns | 366.56 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.37 ns | 11.272 ns | 0.618 ns | 357.66 ns | 358.80 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.11 ns |  9.945 ns | 0.545 ns | 286.49 ns | 287.48 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.61 ns |  3.318 ns | 0.182 ns | 135.47 ns | 135.81 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 142.55 ns | 54.703 ns | 2.998 ns | 140.24 ns | 145.94 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 362.53 ns | 15.669 ns | 0.859 ns | 361.59 ns | 363.27 ns | 0.0057 |     504 B |
