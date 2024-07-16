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
| **FromPrefix**          | **1**      |  **17.29 ns** |   **2.697 ns** |  **0.148 ns** |  **17.18 ns** |  **17.46 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.00 ns |  71.136 ns |  3.899 ns | 119.55 ns | 126.49 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.21 ns |   5.787 ns |  0.317 ns | 118.01 ns | 118.58 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.40 ns |   5.546 ns |  0.304 ns |  91.20 ns |  91.75 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.83 ns |   2.472 ns |  0.135 ns |  44.68 ns |  44.95 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.56 ns |  50.146 ns |  2.749 ns |  43.86 ns |  48.73 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 124.93 ns |  66.791 ns |  3.661 ns | 122.02 ns | 129.04 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.22 ns** |   **3.732 ns** |  **0.205 ns** |  **54.99 ns** |  **55.39 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.68 ns |   9.410 ns |  0.516 ns | 374.36 ns | 375.27 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 366.32 ns | 216.859 ns | 11.887 ns | 359.44 ns | 380.04 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 273.95 ns |   2.878 ns |  0.158 ns | 273.82 ns | 274.13 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.18 ns |   8.934 ns |  0.490 ns | 134.63 ns | 135.57 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.69 ns |  55.062 ns |  3.018 ns | 138.53 ns | 144.14 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 363.82 ns |  34.857 ns |  1.911 ns | 362.34 ns | 365.97 ns | 0.0057 |     504 B |
