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
| **FromPrefix**          | **1**      |  **17.57 ns** |  **1.202 ns** | **0.066 ns** |  **17.51 ns** |  **17.64 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.82 ns |  8.631 ns | 0.473 ns | 122.47 ns | 123.36 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.83 ns | 23.373 ns | 1.281 ns | 116.99 ns | 119.30 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.02 ns |  2.478 ns | 0.136 ns |  90.89 ns |  91.16 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.66 ns |  1.434 ns | 0.079 ns |  44.59 ns |  44.74 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.13 ns |  2.682 ns | 0.147 ns |  43.97 ns |  44.26 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.30 ns | 23.549 ns | 1.291 ns | 118.88 ns | 121.40 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.84 ns** | **23.825 ns** | **1.306 ns** |  **53.59 ns** |  **56.19 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 372.54 ns |  7.219 ns | 0.396 ns | 372.14 ns | 372.93 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 353.25 ns | 14.459 ns | 0.793 ns | 352.63 ns | 354.14 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.83 ns |  1.878 ns | 0.103 ns | 280.74 ns | 280.94 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.34 ns |  3.106 ns | 0.170 ns | 134.15 ns | 134.49 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.97 ns | 13.554 ns | 0.743 ns | 139.11 ns | 140.41 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.06 ns | 89.101 ns | 4.884 ns | 360.80 ns | 370.46 ns | 0.0057 |     504 B |
