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
| **FromPrefix**          | **1**      |  **18.35 ns** |  **3.090 ns** | **0.169 ns** |  **18.23 ns** |  **18.54 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.67 ns |  1.550 ns | 0.085 ns | 120.59 ns | 120.76 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.02 ns |  4.493 ns | 0.246 ns | 117.84 ns | 118.30 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.09 ns |  1.035 ns | 0.057 ns |  91.05 ns |  91.15 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.06 ns | 17.042 ns | 0.934 ns |  44.42 ns |  46.13 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.60 ns |  0.653 ns | 0.036 ns |  43.56 ns |  43.63 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 116.03 ns |  7.156 ns | 0.392 ns | 115.68 ns | 116.45 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.14 ns** |  **6.996 ns** | **0.383 ns** |  **54.72 ns** |  **55.46 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 377.20 ns |  8.402 ns | 0.461 ns | 376.76 ns | 377.68 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 347.07 ns |  6.097 ns | 0.334 ns | 346.75 ns | 347.41 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.88 ns | 12.439 ns | 0.682 ns | 280.16 ns | 281.51 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.59 ns |  5.099 ns | 0.279 ns | 135.33 ns | 135.89 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.57 ns | 33.784 ns | 1.852 ns | 136.15 ns | 139.67 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 373.21 ns | 59.362 ns | 3.254 ns | 370.43 ns | 376.79 ns | 0.0057 |     504 B |
