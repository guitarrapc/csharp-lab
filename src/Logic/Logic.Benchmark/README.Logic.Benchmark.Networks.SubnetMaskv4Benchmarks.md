```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.62 ns** |   **0.389 ns** | **0.021 ns** |  **17.61 ns** |  **17.65 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 120.53 ns |   4.354 ns | 0.239 ns | 120.34 ns | 120.79 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.76 ns |   9.611 ns | 0.527 ns | 116.32 ns | 117.35 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.74 ns |   3.002 ns | 0.165 ns |  90.55 ns |  90.84 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.83 ns |   3.852 ns | 0.211 ns |  44.61 ns |  45.03 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  47.92 ns |  12.093 ns | 0.663 ns |  47.17 ns |  48.41 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 121.64 ns |  32.506 ns | 1.782 ns | 120.47 ns | 123.70 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.84 ns** |   **2.769 ns** | **0.152 ns** |  **55.73 ns** |  **56.01 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 374.51 ns |  10.088 ns | 0.553 ns | 373.88 ns | 374.90 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 351.33 ns |  19.362 ns | 1.061 ns | 350.52 ns | 352.53 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.02 ns |   8.385 ns | 0.460 ns | 286.70 ns | 287.55 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.55 ns |  14.642 ns | 0.803 ns | 133.93 ns | 135.46 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.48 ns |  48.776 ns | 2.674 ns | 136.65 ns | 141.55 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.20 ns | 118.285 ns | 6.484 ns | 362.83 ns | 374.65 ns | 0.0057 |     504 B |
