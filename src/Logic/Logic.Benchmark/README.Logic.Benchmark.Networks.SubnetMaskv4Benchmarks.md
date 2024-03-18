```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.06 ns** |  **2.287 ns** | **0.125 ns** |  **17.97 ns** |  **18.20 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.61 ns | 75.302 ns | 4.128 ns | 120.18 ns | 127.38 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.18 ns | 12.793 ns | 0.701 ns | 116.77 ns | 117.99 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.02 ns |  6.877 ns | 0.377 ns |  90.71 ns |  91.44 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.49 ns |  0.763 ns | 0.042 ns |  45.45 ns |  45.52 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  47.81 ns | 36.761 ns | 2.015 ns |  46.19 ns |  50.06 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.08 ns | 27.696 ns | 1.518 ns | 122.92 ns | 125.80 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.32 ns** | **10.016 ns** | **0.549 ns** |  **55.69 ns** |  **56.69 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.07 ns | 40.439 ns | 2.217 ns | 363.66 ns | 368.01 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 355.00 ns | 59.646 ns | 3.269 ns | 352.06 ns | 358.52 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 288.94 ns | 40.101 ns | 2.198 ns | 287.28 ns | 291.43 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.88 ns | 11.777 ns | 0.646 ns | 136.50 ns | 137.62 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.88 ns |  4.143 ns | 0.227 ns | 136.62 ns | 137.04 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.30 ns | 75.049 ns | 4.114 ns | 364.81 ns | 372.88 ns | 0.0057 |     504 B |
