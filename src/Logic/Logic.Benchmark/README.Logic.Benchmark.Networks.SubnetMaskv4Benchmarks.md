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
| **FromPrefix**          | **1**      |  **17.74 ns** |  **3.529 ns** | **0.193 ns** |  **17.54 ns** |  **17.93 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.19 ns |  1.298 ns | 0.071 ns | 122.13 ns | 122.27 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.13 ns |  3.186 ns | 0.175 ns | 116.94 ns | 117.29 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.48 ns |  2.605 ns | 0.143 ns |  92.37 ns |  92.64 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.25 ns |  4.380 ns | 0.240 ns |  45.11 ns |  45.53 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.06 ns | 20.643 ns | 1.132 ns |  44.29 ns |  46.36 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.67 ns | 20.135 ns | 1.104 ns | 120.42 ns | 122.50 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.94 ns** |  **0.883 ns** | **0.048 ns** |  **55.91 ns** |  **55.99 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.45 ns |  9.306 ns | 0.510 ns | 376.13 ns | 377.03 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 351.04 ns | 33.569 ns | 1.840 ns | 349.01 ns | 352.61 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 284.82 ns |  9.447 ns | 0.518 ns | 284.30 ns | 285.34 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.32 ns | 10.450 ns | 0.573 ns | 134.66 ns | 135.69 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.82 ns | 72.194 ns | 3.957 ns | 136.31 ns | 143.39 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.45 ns | 89.913 ns | 4.928 ns | 362.08 ns | 371.79 ns | 0.0057 |     504 B |
