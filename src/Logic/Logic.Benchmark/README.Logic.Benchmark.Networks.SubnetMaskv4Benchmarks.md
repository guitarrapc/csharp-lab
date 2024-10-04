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
| **FromPrefix**          | **1**      |  **17.72 ns** |  **1.162 ns** | **0.064 ns** |  **17.66 ns** |  **17.79 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.55 ns |  6.948 ns | 0.381 ns | 121.32 ns | 121.99 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.13 ns |  1.316 ns | 0.072 ns | 117.06 ns | 117.20 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  91.45 ns |  4.864 ns | 0.267 ns |  91.26 ns |  91.76 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.60 ns |  5.972 ns | 0.327 ns |  45.28 ns |  45.94 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.77 ns |  3.071 ns | 0.168 ns |  43.62 ns |  43.95 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.87 ns | 38.098 ns | 2.088 ns | 118.19 ns | 122.21 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.40 ns** |  **4.143 ns** | **0.227 ns** |  **55.24 ns** |  **55.66 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 370.76 ns | 15.508 ns | 0.850 ns | 369.82 ns | 371.49 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 345.71 ns | 19.064 ns | 1.045 ns | 344.86 ns | 346.88 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.10 ns |  7.621 ns | 0.418 ns | 274.77 ns | 275.57 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.97 ns |  9.065 ns | 0.497 ns | 136.47 ns | 137.47 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.16 ns | 46.567 ns | 2.552 ns | 135.55 ns | 140.11 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 372.86 ns | 44.085 ns | 2.416 ns | 371.34 ns | 375.65 ns | 0.0057 |     504 B |
