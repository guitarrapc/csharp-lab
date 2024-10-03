```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.84 ns** |  **3.551 ns** | **0.195 ns** |  **17.65 ns** |  **18.04 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.11 ns |  6.879 ns | 0.377 ns | 121.69 ns | 122.43 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.01 ns |  5.069 ns | 0.278 ns | 117.83 ns | 118.33 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.21 ns |  1.442 ns | 0.079 ns |  89.12 ns |  89.27 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.67 ns |  0.493 ns | 0.027 ns |  44.64 ns |  44.69 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.41 ns |  0.391 ns | 0.021 ns |  44.39 ns |  44.43 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.83 ns | 43.663 ns | 2.393 ns | 117.45 ns | 122.24 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.30 ns** |  **4.508 ns** | **0.247 ns** |  **55.02 ns** |  **55.49 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.03 ns | 10.690 ns | 0.586 ns | 373.58 ns | 374.69 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 345.54 ns | 14.107 ns | 0.773 ns | 344.84 ns | 346.37 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 280.95 ns | 20.932 ns | 1.147 ns | 280.05 ns | 282.24 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.21 ns |  2.921 ns | 0.160 ns | 136.12 ns | 136.40 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.88 ns |  5.382 ns | 0.295 ns | 138.71 ns | 139.22 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 373.19 ns | 37.746 ns | 2.069 ns | 371.56 ns | 375.52 ns | 0.0057 |     504 B |
