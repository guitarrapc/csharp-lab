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
| **FromPrefix**          | **1**      |  **27.03 ns** |  **7.199 ns** | **0.395 ns** |  **26.78 ns** |  **27.49 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 117.05 ns |  4.531 ns | 0.248 ns | 116.87 ns | 117.33 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 113.20 ns |  4.165 ns | 0.228 ns | 113.00 ns | 113.45 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  82.98 ns |  2.814 ns | 0.154 ns |  82.89 ns |  83.16 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  43.45 ns |  3.513 ns | 0.193 ns |  43.33 ns |  43.67 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  39.62 ns |  0.419 ns | 0.023 ns |  39.59 ns |  39.64 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 110.13 ns |  4.071 ns | 0.223 ns | 109.88 ns | 110.32 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **77.97 ns** |  **1.788 ns** | **0.098 ns** |  **77.88 ns** |  **78.07 ns** | **0.0019** |     **168 B** |
| FromCidrAddress     | 3      | 360.17 ns | 39.777 ns | 2.180 ns | 358.75 ns | 362.68 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 335.63 ns |  6.990 ns | 0.383 ns | 335.40 ns | 336.07 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 254.57 ns |  8.560 ns | 0.469 ns | 254.16 ns | 255.08 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 130.41 ns |  5.331 ns | 0.292 ns | 130.21 ns | 130.74 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 119.42 ns | 12.725 ns | 0.698 ns | 118.86 ns | 120.20 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 358.99 ns | 44.669 ns | 2.448 ns | 356.63 ns | 361.52 ns | 0.0057 |     504 B |
