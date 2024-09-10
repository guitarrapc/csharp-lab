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
| **FromPrefix**          | **1**      |  **18.08 ns** |  **1.241 ns** | **0.068 ns** |  **18.03 ns** |  **18.16 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.09 ns |  3.489 ns | 0.191 ns | 121.87 ns | 122.22 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.46 ns |  7.414 ns | 0.406 ns | 117.08 ns | 117.89 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  91.99 ns | 13.497 ns | 0.740 ns |  91.40 ns |  92.82 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.83 ns |  2.873 ns | 0.157 ns |  45.72 ns |  46.01 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.08 ns |  5.580 ns | 0.306 ns |  44.72 ns |  45.26 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.16 ns | 14.221 ns | 0.779 ns | 119.49 ns | 121.02 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.34 ns** |  **7.593 ns** | **0.416 ns** |  **55.92 ns** |  **56.75 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 369.93 ns | 37.354 ns | 2.047 ns | 368.37 ns | 372.25 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 348.50 ns | 10.273 ns | 0.563 ns | 347.86 ns | 348.89 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.58 ns |  5.119 ns | 0.281 ns | 282.37 ns | 282.90 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 139.17 ns |  2.621 ns | 0.144 ns | 139.02 ns | 139.31 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.71 ns |  8.555 ns | 0.469 ns | 139.26 ns | 140.19 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 375.52 ns | 55.000 ns | 3.015 ns | 373.49 ns | 378.99 ns | 0.0057 |     504 B |
