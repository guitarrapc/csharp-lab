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
| **FromPrefix**          | **1**      |  **17.62 ns** |   **1.352 ns** | **0.074 ns** |  **17.57 ns** |  **17.70 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 125.90 ns | 100.916 ns | 5.532 ns | 122.53 ns | 132.28 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.54 ns |   2.616 ns | 0.143 ns | 116.45 ns | 116.70 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  93.08 ns |  42.331 ns | 2.320 ns |  91.66 ns |  95.76 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.79 ns |   0.924 ns | 0.051 ns |  44.76 ns |  44.85 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.70 ns |   2.018 ns | 0.111 ns |  43.59 ns |  43.81 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.35 ns |  25.961 ns | 1.423 ns | 116.50 ns | 119.00 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.44 ns** |   **7.224 ns** | **0.396 ns** |  **54.99 ns** |  **55.73 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 365.63 ns |   4.097 ns | 0.225 ns | 365.40 ns | 365.85 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 358.07 ns |   8.732 ns | 0.479 ns | 357.77 ns | 358.62 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 271.29 ns |   6.616 ns | 0.363 ns | 270.92 ns | 271.64 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.28 ns |   7.438 ns | 0.408 ns | 135.89 ns | 136.70 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.96 ns |  17.811 ns | 0.976 ns | 139.29 ns | 141.08 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 372.49 ns |  72.106 ns | 3.952 ns | 368.06 ns | 375.66 ns | 0.0057 |     504 B |
