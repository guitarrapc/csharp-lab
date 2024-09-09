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
| **FromPrefix**          | **1**      |  **17.68 ns** |  **0.804 ns** | **0.044 ns** |  **17.63 ns** |  **17.71 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.29 ns |  6.921 ns | 0.379 ns | 119.98 ns | 120.72 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.23 ns |  9.265 ns | 0.508 ns | 115.89 ns | 116.82 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  91.04 ns |  9.579 ns | 0.525 ns |  90.73 ns |  91.65 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.48 ns |  2.742 ns | 0.150 ns |  44.34 ns |  44.64 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.20 ns |  3.725 ns | 0.204 ns |  43.00 ns |  43.41 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.23 ns | 38.908 ns | 2.133 ns | 115.97 ns | 119.70 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.30 ns** |  **2.355 ns** | **0.129 ns** |  **54.15 ns** |  **54.38 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.44 ns |  8.843 ns | 0.485 ns | 374.04 ns | 374.98 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 345.03 ns | 20.860 ns | 1.143 ns | 343.95 ns | 346.23 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 279.54 ns | 21.289 ns | 1.167 ns | 278.40 ns | 280.73 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.15 ns | 11.164 ns | 0.612 ns | 133.74 ns | 134.86 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 135.26 ns |  6.266 ns | 0.343 ns | 135.04 ns | 135.65 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 369.88 ns | 33.278 ns | 1.824 ns | 367.78 ns | 371.00 ns | 0.0057 |     504 B |
