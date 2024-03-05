```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.20 ns** |  **1.196 ns** | **0.066 ns** |  **17.13 ns** |  **17.26 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.53 ns |  2.449 ns | 0.134 ns | 121.38 ns | 121.63 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.19 ns | 42.598 ns | 2.335 ns | 116.59 ns | 120.87 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.00 ns |  5.156 ns | 0.283 ns |  89.81 ns |  90.33 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  46.07 ns |  1.251 ns | 0.069 ns |  46.01 ns |  46.14 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.45 ns | 15.415 ns | 0.845 ns |  44.49 ns |  46.09 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.10 ns | 14.079 ns | 0.772 ns | 122.30 ns | 123.84 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.85 ns** |  **4.054 ns** | **0.222 ns** |  **54.68 ns** |  **55.10 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.32 ns |  5.676 ns | 0.311 ns | 365.96 ns | 366.51 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 363.80 ns | 18.537 ns | 1.016 ns | 362.64 ns | 364.55 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 288.77 ns | 19.594 ns | 1.074 ns | 287.55 ns | 289.59 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 133.51 ns |  3.557 ns | 0.195 ns | 133.30 ns | 133.69 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.53 ns |  6.093 ns | 0.334 ns | 136.15 ns | 136.73 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 363.14 ns | 10.624 ns | 0.582 ns | 362.59 ns | 363.75 ns | 0.0057 |     504 B |
