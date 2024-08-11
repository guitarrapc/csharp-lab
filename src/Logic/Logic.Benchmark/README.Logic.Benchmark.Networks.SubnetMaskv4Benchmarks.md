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
| **FromPrefix**          | **1**      |  **17.41 ns** |  **1.757 ns** | **0.096 ns** |  **17.33 ns** |  **17.51 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.73 ns | 40.615 ns | 2.226 ns | 122.40 ns | 126.30 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.92 ns |  3.799 ns | 0.208 ns | 116.70 ns | 117.12 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.65 ns |  3.150 ns | 0.173 ns |  89.46 ns |  89.78 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.49 ns |  2.031 ns | 0.111 ns |  44.37 ns |  44.60 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  46.11 ns | 37.299 ns | 2.045 ns |  44.15 ns |  48.23 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.29 ns | 92.090 ns | 5.048 ns | 120.67 ns | 130.05 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.72 ns** |  **2.841 ns** | **0.156 ns** |  **55.57 ns** |  **55.88 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.42 ns |  9.503 ns | 0.521 ns | 375.90 ns | 376.94 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.39 ns |  4.796 ns | 0.263 ns | 356.13 ns | 356.66 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.99 ns |  8.035 ns | 0.440 ns | 282.48 ns | 283.25 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.59 ns |  2.321 ns | 0.127 ns | 133.44 ns | 133.66 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.49 ns |  9.370 ns | 0.514 ns | 139.04 ns | 140.05 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 368.37 ns | 20.894 ns | 1.145 ns | 367.08 ns | 369.27 ns | 0.0057 |     504 B |
