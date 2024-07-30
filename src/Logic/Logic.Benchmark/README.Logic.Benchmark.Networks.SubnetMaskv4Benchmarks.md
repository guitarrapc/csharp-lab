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
| **FromPrefix**          | **1**      |  **17.54 ns** |  **1.342 ns** | **0.074 ns** |  **17.49 ns** |  **17.62 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.18 ns |  9.876 ns | 0.541 ns | 119.64 ns | 120.73 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.35 ns |  1.356 ns | 0.074 ns | 116.26 ns | 116.39 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.98 ns |  3.234 ns | 0.177 ns |  89.80 ns |  90.16 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.11 ns |  0.371 ns | 0.020 ns |  45.09 ns |  45.13 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.37 ns |  8.883 ns | 0.487 ns |  43.81 ns |  44.72 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.58 ns | 19.916 ns | 1.092 ns | 121.71 ns | 123.80 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.79 ns** |  **5.879 ns** | **0.322 ns** |  **55.42 ns** |  **55.99 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 371.67 ns | 13.246 ns | 0.726 ns | 370.84 ns | 372.21 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 363.12 ns | 21.328 ns | 1.169 ns | 361.99 ns | 364.32 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 289.43 ns | 20.546 ns | 1.126 ns | 288.16 ns | 290.31 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.58 ns |  7.727 ns | 0.424 ns | 134.21 ns | 135.04 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.44 ns | 12.363 ns | 0.678 ns | 140.03 ns | 141.23 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.04 ns | 11.692 ns | 0.641 ns | 364.49 ns | 365.74 ns | 0.0057 |     504 B |
