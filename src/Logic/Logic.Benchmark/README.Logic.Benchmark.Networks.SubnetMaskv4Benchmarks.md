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
| **FromPrefix**          | **1**      |  **17.58 ns** |  **0.968 ns** | **0.053 ns** |  **17.54 ns** |  **17.64 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.38 ns |  6.310 ns | 0.346 ns | 123.13 ns | 123.78 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.48 ns |  1.202 ns | 0.066 ns | 116.42 ns | 116.55 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.27 ns | 10.648 ns | 0.584 ns |  88.91 ns |  89.94 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.54 ns |  1.644 ns | 0.090 ns |  44.49 ns |  44.65 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.26 ns |  0.334 ns | 0.018 ns |  44.24 ns |  44.28 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.52 ns | 52.871 ns | 2.898 ns | 116.26 ns | 121.78 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.69 ns** |  **3.795 ns** | **0.208 ns** |  **54.48 ns** |  **54.90 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.84 ns |  7.529 ns | 0.413 ns | 375.57 ns | 376.31 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 346.33 ns | 15.967 ns | 0.875 ns | 345.43 ns | 347.18 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.67 ns | 10.300 ns | 0.565 ns | 273.25 ns | 274.32 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.48 ns |  0.657 ns | 0.036 ns | 134.44 ns | 134.52 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.19 ns | 32.222 ns | 1.766 ns | 136.15 ns | 139.23 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.64 ns | 44.319 ns | 2.429 ns | 362.86 ns | 367.36 ns | 0.0057 |     504 B |
