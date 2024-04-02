```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.203
  [Host]   : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.3 (8.0.324.11423), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.53 ns** |  **2.923 ns** | **0.160 ns** |  **17.44 ns** |  **17.72 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 119.34 ns | 20.527 ns | 1.125 ns | 118.06 ns | 120.19 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 121.34 ns | 30.500 ns | 1.672 ns | 120.35 ns | 123.27 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.06 ns |  1.519 ns | 0.083 ns |  91.98 ns |  92.15 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.57 ns |  0.554 ns | 0.030 ns |  44.54 ns |  44.61 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.98 ns | 33.822 ns | 1.854 ns |  42.85 ns |  46.23 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.39 ns | 27.385 ns | 1.501 ns | 118.66 ns | 121.36 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.16 ns** |  **1.034 ns** | **0.057 ns** |  **54.12 ns** |  **54.22 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 363.40 ns | 25.541 ns | 1.400 ns | 362.08 ns | 364.87 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 359.60 ns |  9.601 ns | 0.526 ns | 359.28 ns | 360.20 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 286.06 ns | 20.049 ns | 1.099 ns | 285.17 ns | 287.29 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.73 ns | 17.352 ns | 0.951 ns | 134.05 ns | 135.82 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 135.90 ns | 25.279 ns | 1.386 ns | 135.06 ns | 137.50 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 362.91 ns | 72.188 ns | 3.957 ns | 359.17 ns | 367.05 ns | 0.0057 |     504 B |
