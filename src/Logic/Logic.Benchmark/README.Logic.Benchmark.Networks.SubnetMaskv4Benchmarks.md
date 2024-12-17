```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **26.67 ns** |   **1.451 ns** | **0.080 ns** |  **26.61 ns** |  **26.76 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 116.26 ns |   4.375 ns | 0.240 ns | 116.05 ns | 116.52 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 113.10 ns |   5.353 ns | 0.293 ns | 112.86 ns | 113.43 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  83.49 ns |   3.930 ns | 0.215 ns |  83.26 ns |  83.69 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  43.24 ns |   4.624 ns | 0.253 ns |  43.07 ns |  43.53 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  40.00 ns |   2.591 ns | 0.142 ns |  39.85 ns |  40.12 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 112.01 ns |  10.921 ns | 0.599 ns | 111.32 ns | 112.37 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **79.64 ns** |   **7.508 ns** | **0.412 ns** |  **79.18 ns** |  **79.98 ns** | **0.0019** |     **168 B** |
| FromCidrAddress     | 3      | 364.90 ns |  81.873 ns | 4.488 ns | 359.88 ns | 368.53 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 336.66 ns |   6.671 ns | 0.366 ns | 336.39 ns | 337.08 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 257.17 ns |  34.179 ns | 1.873 ns | 256.08 ns | 259.33 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 131.81 ns |   6.150 ns | 0.337 ns | 131.42 ns | 132.03 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 119.69 ns |  19.604 ns | 1.075 ns | 118.93 ns | 120.92 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 350.31 ns | 130.456 ns | 7.151 ns | 342.30 ns | 356.05 ns | 0.0057 |     504 B |
