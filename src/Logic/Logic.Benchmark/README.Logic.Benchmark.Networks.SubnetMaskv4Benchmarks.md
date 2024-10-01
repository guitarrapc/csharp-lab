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
| **FromPrefix**          | **1**      |  **18.02 ns** |  **3.639 ns** | **0.199 ns** |  **17.90 ns** |  **18.25 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.16 ns |  3.925 ns | 0.215 ns | 121.01 ns | 121.40 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.96 ns |  7.321 ns | 0.401 ns | 116.61 ns | 117.39 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.20 ns |  2.600 ns | 0.143 ns |  89.04 ns |  89.32 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.86 ns |  3.144 ns | 0.172 ns |  45.66 ns |  45.98 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.59 ns |  0.598 ns | 0.033 ns |  44.56 ns |  44.62 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.27 ns | 13.094 ns | 0.718 ns | 120.82 ns | 122.10 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.78 ns** | **11.967 ns** | **0.656 ns** |  **54.34 ns** |  **55.54 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 364.64 ns |  3.212 ns | 0.176 ns | 364.49 ns | 364.83 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 346.60 ns | 12.716 ns | 0.697 ns | 346.00 ns | 347.37 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 293.53 ns | 24.813 ns | 1.360 ns | 292.35 ns | 295.02 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.46 ns |  8.653 ns | 0.474 ns | 136.03 ns | 136.97 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.45 ns |  8.755 ns | 0.480 ns | 135.91 ns | 136.83 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 375.92 ns | 19.217 ns | 1.053 ns | 374.86 ns | 376.97 ns | 0.0057 |     504 B |
