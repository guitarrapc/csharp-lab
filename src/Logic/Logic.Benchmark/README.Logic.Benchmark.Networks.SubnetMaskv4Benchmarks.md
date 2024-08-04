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
| **FromPrefix**          | **1**      |  **17.51 ns** |  **2.032 ns** | **0.111 ns** |  **17.39 ns** |  **17.61 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.96 ns |  3.217 ns | 0.176 ns | 119.83 ns | 120.16 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.23 ns |  8.207 ns | 0.450 ns | 116.82 ns | 117.71 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  92.86 ns |  2.924 ns | 0.160 ns |  92.71 ns |  93.03 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.48 ns |  3.880 ns | 0.213 ns |  45.32 ns |  45.72 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.58 ns |  0.863 ns | 0.047 ns |  43.53 ns |  43.62 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.50 ns |  9.554 ns | 0.524 ns | 123.00 ns | 124.04 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.40 ns** |  **3.483 ns** | **0.191 ns** |  **55.18 ns** |  **55.52 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.93 ns | 15.248 ns | 0.836 ns | 375.97 ns | 377.46 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.44 ns | 35.530 ns | 1.948 ns | 347.76 ns | 351.58 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 283.43 ns | 12.092 ns | 0.663 ns | 282.94 ns | 284.18 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.84 ns |  1.771 ns | 0.097 ns | 134.77 ns | 134.95 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 141.70 ns | 36.294 ns | 1.989 ns | 140.30 ns | 143.97 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.51 ns | 26.259 ns | 1.439 ns | 366.23 ns | 369.07 ns | 0.0057 |     504 B |
