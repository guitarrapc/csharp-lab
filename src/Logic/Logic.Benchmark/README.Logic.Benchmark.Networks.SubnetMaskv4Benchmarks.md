```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.404
  [Host]   : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.12 ns** |  **0.255 ns** | **0.014 ns** |  **17.10 ns** |  **17.13 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.04 ns | 16.672 ns | 0.914 ns | 122.33 ns | 124.07 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.49 ns |  1.742 ns | 0.095 ns | 117.40 ns | 117.59 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.40 ns |  5.150 ns | 0.282 ns |  90.07 ns |  90.57 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.00 ns |  2.124 ns | 0.116 ns |  43.89 ns |  44.12 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.39 ns |  1.486 ns | 0.081 ns |  44.33 ns |  44.49 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.83 ns | 16.380 ns | 0.898 ns | 117.17 ns | 118.85 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **53.55 ns** |  **6.622 ns** | **0.363 ns** |  **53.21 ns** |  **53.94 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.14 ns | 14.757 ns | 0.809 ns | 365.52 ns | 367.05 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 354.64 ns | 18.241 ns | 1.000 ns | 353.50 ns | 355.40 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 270.84 ns | 18.501 ns | 1.014 ns | 269.96 ns | 271.95 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.80 ns |  4.613 ns | 0.253 ns | 133.57 ns | 134.07 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 135.83 ns |  5.967 ns | 0.327 ns | 135.48 ns | 136.11 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.68 ns | 79.058 ns | 4.333 ns | 362.71 ns | 370.65 ns | 0.0057 |     504 B |
