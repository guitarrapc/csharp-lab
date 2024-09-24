```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.80 ns** |  **1.113 ns** | **0.061 ns** |  **17.75 ns** |  **17.87 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.99 ns |  7.497 ns | 0.411 ns | 121.71 ns | 122.46 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 123.99 ns |  6.846 ns | 0.375 ns | 123.72 ns | 124.42 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.84 ns |  0.816 ns | 0.045 ns |  91.79 ns |  91.87 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.24 ns |  2.335 ns | 0.128 ns |  45.13 ns |  45.38 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.52 ns |  1.918 ns | 0.105 ns |  43.44 ns |  43.64 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.20 ns | 37.655 ns | 2.064 ns | 117.22 ns | 121.34 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.78 ns** |  **1.688 ns** | **0.093 ns** |  **55.68 ns** |  **55.86 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.40 ns |  6.910 ns | 0.379 ns | 376.00 ns | 376.75 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.50 ns |  7.927 ns | 0.435 ns | 358.19 ns | 359.00 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.55 ns | 13.468 ns | 0.738 ns | 272.80 ns | 274.27 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.97 ns |  8.305 ns | 0.455 ns | 133.62 ns | 134.48 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 147.52 ns |  5.120 ns | 0.281 ns | 147.20 ns | 147.68 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 372.04 ns | 42.135 ns | 2.310 ns | 369.61 ns | 374.21 ns | 0.0057 |     504 B |
