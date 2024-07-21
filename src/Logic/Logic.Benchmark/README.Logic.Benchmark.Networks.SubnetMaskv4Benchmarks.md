```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.59 ns** |   **1.615 ns** |  **0.089 ns** |  **17.51 ns** |  **17.69 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 126.02 ns |  83.725 ns |  4.589 ns | 123.26 ns | 131.32 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.26 ns |  13.026 ns |  0.714 ns | 118.85 ns | 120.08 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.04 ns |   2.141 ns |  0.117 ns |  89.90 ns |  90.11 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.86 ns |   2.159 ns |  0.118 ns |  44.76 ns |  44.99 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.92 ns |  15.044 ns |  0.825 ns |  45.28 ns |  46.85 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.40 ns |  13.504 ns |  0.740 ns | 123.96 ns | 125.26 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.30 ns** |   **9.347 ns** |  **0.512 ns** |  **54.80 ns** |  **55.83 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 376.89 ns |  48.242 ns |  2.644 ns | 375.35 ns | 379.95 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.21 ns |  37.102 ns |  2.034 ns | 357.48 ns | 361.45 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 277.24 ns |  17.831 ns |  0.977 ns | 276.12 ns | 277.92 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.52 ns |   2.745 ns |  0.150 ns | 136.34 ns | 136.62 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.82 ns |  64.485 ns |  3.535 ns | 137.22 ns | 144.28 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 377.14 ns | 224.521 ns | 12.307 ns | 365.58 ns | 390.08 ns | 0.0057 |     504 B |
