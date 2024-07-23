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
| **FromPrefix**          | **1**      |  **17.95 ns** |  **1.837 ns** | **0.101 ns** |  **17.86 ns** |  **18.06 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.26 ns |  7.528 ns | 0.413 ns | 124.89 ns | 125.70 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.58 ns |  7.001 ns | 0.384 ns | 117.32 ns | 118.02 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  94.45 ns |  4.058 ns | 0.222 ns |  94.19 ns |  94.59 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.46 ns |  3.424 ns | 0.188 ns |  45.25 ns |  45.59 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.54 ns | 18.765 ns | 1.029 ns |  44.40 ns |  46.39 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.97 ns | 14.152 ns | 0.776 ns | 125.15 ns | 126.69 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.48 ns** |  **8.624 ns** | **0.473 ns** |  **55.95 ns** |  **56.85 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 368.54 ns | 16.076 ns | 0.881 ns | 367.52 ns | 369.10 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.40 ns | 20.463 ns | 1.122 ns | 351.16 ns | 353.34 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.07 ns |  0.622 ns | 0.034 ns | 287.04 ns | 287.11 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.48 ns |  3.069 ns | 0.168 ns | 136.32 ns | 136.65 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.28 ns | 20.819 ns | 1.141 ns | 137.56 ns | 139.60 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.19 ns | 65.768 ns | 3.605 ns | 365.07 ns | 371.72 ns | 0.0057 |     504 B |
