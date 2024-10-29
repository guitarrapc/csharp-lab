```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.57 ns** |   **0.794 ns** | **0.044 ns** |  **17.54 ns** |  **17.62 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.11 ns |   4.795 ns | 0.263 ns | 124.80 ns | 125.28 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.50 ns |   9.498 ns | 0.521 ns | 119.08 ns | 120.08 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.52 ns |   5.787 ns | 0.317 ns |  91.21 ns |  91.85 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.65 ns |   2.815 ns | 0.154 ns |  44.52 ns |  44.82 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.97 ns |  19.851 ns | 1.088 ns |  44.20 ns |  46.21 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.09 ns |  23.808 ns | 1.305 ns | 117.90 ns | 120.48 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.86 ns** |  **10.199 ns** | **0.559 ns** |  **54.49 ns** |  **55.51 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 368.37 ns |   6.407 ns | 0.351 ns | 368.06 ns | 368.75 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 348.68 ns |   5.209 ns | 0.286 ns | 348.48 ns | 349.01 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 285.21 ns | 119.967 ns | 6.576 ns | 281.40 ns | 292.80 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.58 ns |   5.418 ns | 0.297 ns | 135.25 ns | 135.82 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.53 ns |  27.646 ns | 1.515 ns | 136.83 ns | 139.74 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 374.83 ns |  14.096 ns | 0.773 ns | 373.98 ns | 375.49 ns | 0.0057 |     504 B |
