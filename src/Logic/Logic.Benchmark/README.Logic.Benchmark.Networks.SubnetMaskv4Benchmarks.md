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
| **FromPrefix**          | **1**      |  **17.48 ns** |   **0.342 ns** | **0.019 ns** |  **17.46 ns** |  **17.49 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.35 ns |  29.039 ns | 1.592 ns | 120.80 ns | 123.98 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.23 ns |  19.425 ns | 1.065 ns | 116.19 ns | 118.32 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  89.07 ns |   2.318 ns | 0.127 ns |  88.96 ns |  89.21 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.42 ns |   1.633 ns | 0.089 ns |  44.32 ns |  44.48 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.37 ns |   1.823 ns | 0.100 ns |  43.28 ns |  43.48 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.90 ns |   9.193 ns | 0.504 ns | 120.51 ns | 121.47 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.64 ns** |  **11.095 ns** | **0.608 ns** |  **55.02 ns** |  **56.23 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.17 ns |  31.837 ns | 1.745 ns | 374.68 ns | 378.09 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 357.21 ns |  32.013 ns | 1.755 ns | 355.22 ns | 358.55 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 284.45 ns |  35.505 ns | 1.946 ns | 283.26 ns | 286.70 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.21 ns |   3.113 ns | 0.171 ns | 135.02 ns | 135.36 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 143.65 ns |  67.612 ns | 3.706 ns | 140.63 ns | 147.78 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.81 ns | 154.957 ns | 8.494 ns | 359.59 ns | 375.49 ns | 0.0057 |     504 B |
