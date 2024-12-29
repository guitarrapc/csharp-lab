```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **25.86 ns** |  **3.523 ns** | **0.193 ns** |  **25.74 ns** |  **26.08 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 117.14 ns |  2.083 ns | 0.114 ns | 117.06 ns | 117.27 ns | 0.0013 |     112 B |
| FromCidrAddress2    | 1      | 112.00 ns |  0.805 ns | 0.044 ns | 111.96 ns | 112.05 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  82.24 ns |  0.916 ns | 0.050 ns |  82.20 ns |  82.30 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  43.03 ns |  1.917 ns | 0.105 ns |  42.91 ns |  43.12 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  39.67 ns |  4.600 ns | 0.252 ns |  39.47 ns |  39.95 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 109.94 ns |  0.479 ns | 0.026 ns | 109.92 ns | 109.97 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **77.92 ns** |  **3.128 ns** | **0.171 ns** |  **77.74 ns** |  **78.08 ns** | **0.0019** |     **168 B** |
| FromCidrAddress     | 3      | 366.06 ns |  2.434 ns | 0.133 ns | 365.95 ns | 366.21 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 334.07 ns | 14.761 ns | 0.809 ns | 333.59 ns | 335.01 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 251.93 ns |  7.644 ns | 0.419 ns | 251.58 ns | 252.39 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 137.73 ns | 96.275 ns | 5.277 ns | 134.19 ns | 143.80 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 118.93 ns |  8.114 ns | 0.445 ns | 118.42 ns | 119.23 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 343.65 ns | 56.985 ns | 3.124 ns | 340.08 ns | 345.89 ns | 0.0057 |     504 B |
