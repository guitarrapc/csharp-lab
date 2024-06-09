```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.45 ns** |  **1.241 ns** | **0.068 ns** |  **17.37 ns** |  **17.49 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.26 ns |  8.831 ns | 0.484 ns | 120.74 ns | 121.69 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.48 ns | 33.170 ns | 1.818 ns | 116.39 ns | 119.74 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.83 ns |  1.915 ns | 0.105 ns |  92.71 ns |  92.89 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.50 ns |  2.419 ns | 0.133 ns |  45.35 ns |  45.61 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.83 ns | 17.396 ns | 0.954 ns |  43.75 ns |  45.58 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.25 ns | 30.876 ns | 1.692 ns | 121.49 ns | 124.87 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.37 ns** |  **2.434 ns** | **0.133 ns** |  **55.26 ns** |  **55.52 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.30 ns | 24.622 ns | 1.350 ns | 375.48 ns | 377.85 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.77 ns | 10.783 ns | 0.591 ns | 358.14 ns | 359.32 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.53 ns | 10.452 ns | 0.573 ns | 281.89 ns | 283.00 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.68 ns |  1.030 ns | 0.056 ns | 134.63 ns | 134.74 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 142.68 ns | 82.079 ns | 4.499 ns | 138.04 ns | 147.02 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 368.86 ns | 24.354 ns | 1.335 ns | 367.49 ns | 370.15 ns | 0.0057 |     504 B |
