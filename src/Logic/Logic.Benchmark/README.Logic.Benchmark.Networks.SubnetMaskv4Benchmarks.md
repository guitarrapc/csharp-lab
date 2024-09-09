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
| **FromPrefix**          | **1**      |  **18.28 ns** | **18.857 ns** | **1.034 ns** |  **17.52 ns** |  **19.45 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.91 ns |  0.603 ns | 0.033 ns | 123.88 ns | 123.95 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.55 ns |  1.433 ns | 0.079 ns | 117.48 ns | 117.64 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.24 ns |  2.349 ns | 0.129 ns |  91.15 ns |  91.39 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.44 ns | 19.472 ns | 1.067 ns |  44.81 ns |  46.68 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.22 ns |  1.445 ns | 0.079 ns |  43.13 ns |  43.28 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.64 ns | 10.104 ns | 0.554 ns | 117.07 ns | 118.17 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.03 ns** |  **4.455 ns** | **0.244 ns** |  **54.81 ns** |  **55.29 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 373.82 ns | 17.031 ns | 0.934 ns | 372.98 ns | 374.83 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.34 ns | 10.449 ns | 0.573 ns | 355.85 ns | 356.97 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 275.17 ns | 13.889 ns | 0.761 ns | 274.38 ns | 275.90 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.89 ns | 14.433 ns | 0.791 ns | 135.25 ns | 136.78 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.81 ns | 58.645 ns | 3.215 ns | 135.45 ns | 141.47 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 373.64 ns |  4.804 ns | 0.263 ns | 373.46 ns | 373.94 ns | 0.0057 |     504 B |
