```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.95 ns** |   **1.484 ns** |  **0.081 ns** |  **17.88 ns** |  **18.04 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.89 ns |  14.046 ns |  0.770 ns | 119.25 ns | 120.74 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.67 ns |   7.833 ns |  0.429 ns | 115.18 ns | 116.00 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  91.18 ns |   3.416 ns |  0.187 ns |  91.03 ns |  91.39 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.73 ns |   0.343 ns |  0.019 ns |  44.70 ns |  44.74 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.03 ns |   0.608 ns |  0.033 ns |  43.99 ns |  44.05 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.03 ns |  21.434 ns |  1.175 ns | 118.17 ns | 120.37 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **53.67 ns** |   **7.031 ns** |  **0.385 ns** |  **53.24 ns** |  **53.97 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.69 ns |   8.381 ns |  0.459 ns | 375.31 ns | 376.20 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 351.49 ns | 200.974 ns | 11.016 ns | 344.97 ns | 364.21 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 272.46 ns |  18.392 ns |  1.008 ns | 271.65 ns | 273.59 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.42 ns |   2.883 ns |  0.158 ns | 135.24 ns | 135.54 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.58 ns |   3.607 ns |  0.198 ns | 138.45 ns | 138.81 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 370.94 ns |  18.538 ns |  1.016 ns | 370.16 ns | 372.09 ns | 0.0057 |     504 B |
