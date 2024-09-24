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
| **FromPrefix**          | **1**      |  **17.69 ns** |  **4.959 ns** | **0.272 ns** |  **17.38 ns** |  **17.85 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.56 ns |  4.585 ns | 0.251 ns | 122.33 ns | 122.83 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.15 ns |  6.138 ns | 0.336 ns | 114.76 ns | 115.35 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.18 ns |  4.261 ns | 0.234 ns |  88.95 ns |  89.42 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.77 ns |  2.680 ns | 0.147 ns |  44.65 ns |  44.93 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.04 ns |  5.471 ns | 0.300 ns |  44.77 ns |  45.36 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.22 ns | 21.467 ns | 1.177 ns | 116.39 ns | 118.56 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.10 ns** | **14.588 ns** | **0.800 ns** |  **54.50 ns** |  **56.01 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.24 ns |  1.720 ns | 0.094 ns | 375.18 ns | 375.35 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.86 ns | 18.309 ns | 1.004 ns | 358.70 ns | 360.45 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.39 ns | 40.440 ns | 2.217 ns | 280.95 ns | 284.95 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.18 ns | 13.215 ns | 0.724 ns | 133.44 ns | 134.88 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 142.79 ns | 17.382 ns | 0.953 ns | 141.70 ns | 143.48 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 376.33 ns | 31.665 ns | 1.736 ns | 374.98 ns | 378.29 ns | 0.0057 |     504 B |
