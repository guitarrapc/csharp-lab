```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.79 ns** |  **2.165 ns** | **0.119 ns** |  **17.68 ns** |  **17.92 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.10 ns | 16.757 ns | 0.919 ns | 122.43 ns | 124.15 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.76 ns | 12.954 ns | 0.710 ns | 117.07 ns | 118.49 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.18 ns |  3.070 ns | 0.168 ns |  93.03 ns |  93.36 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.87 ns |  3.629 ns | 0.199 ns |  44.67 ns |  45.07 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.94 ns |  1.840 ns | 0.101 ns |  44.83 ns |  45.01 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.37 ns | 51.437 ns | 2.819 ns | 122.16 ns | 127.46 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.30 ns** |  **7.926 ns** | **0.434 ns** |  **55.80 ns** |  **56.58 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 372.28 ns | 26.857 ns | 1.472 ns | 370.59 ns | 373.17 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 360.65 ns | 39.783 ns | 2.181 ns | 358.97 ns | 363.11 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 286.49 ns |  5.538 ns | 0.304 ns | 286.19 ns | 286.80 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.93 ns |  7.933 ns | 0.435 ns | 134.44 ns | 135.28 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.06 ns |  6.993 ns | 0.383 ns | 139.63 ns | 140.36 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.37 ns | 69.506 ns | 3.810 ns | 365.03 ns | 372.17 ns | 0.0057 |     504 B |
