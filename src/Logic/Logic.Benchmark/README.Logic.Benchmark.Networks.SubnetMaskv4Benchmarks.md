```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.38 ns** |  **2.618 ns** | **0.143 ns** |  **17.29 ns** |  **17.54 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.87 ns |  3.846 ns | 0.211 ns | 122.69 ns | 123.11 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 120.17 ns |  3.862 ns | 0.212 ns | 119.93 ns | 120.34 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.88 ns |  6.294 ns | 0.345 ns |  92.66 ns |  93.28 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.15 ns |  2.302 ns | 0.126 ns |  45.07 ns |  45.29 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.56 ns |  1.044 ns | 0.057 ns |  43.52 ns |  43.63 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.10 ns | 25.432 ns | 1.394 ns | 117.52 ns | 120.15 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.39 ns** |  **7.061 ns** | **0.387 ns** |  **53.94 ns** |  **54.66 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.87 ns | 15.347 ns | 0.841 ns | 376.15 ns | 377.80 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 346.57 ns | 13.489 ns | 0.739 ns | 345.84 ns | 347.32 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.55 ns |  5.318 ns | 0.292 ns | 274.34 ns | 274.88 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.46 ns |  5.694 ns | 0.312 ns | 136.10 ns | 136.67 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.78 ns |  6.038 ns | 0.331 ns | 137.45 ns | 138.11 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 374.87 ns | 34.102 ns | 1.869 ns | 372.78 ns | 376.37 ns | 0.0057 |     504 B |
