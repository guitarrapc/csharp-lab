```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.301
  [Host]   : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.52 ns** |  **5.640 ns** | **0.309 ns** |  **17.31 ns** |  **17.87 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.72 ns |  9.517 ns | 0.522 ns | 122.13 ns | 123.11 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.24 ns |  1.180 ns | 0.065 ns | 116.17 ns | 116.29 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.07 ns |  6.109 ns | 0.335 ns |  89.81 ns |  90.45 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.96 ns |  1.397 ns | 0.077 ns |  44.90 ns |  45.05 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.36 ns | 18.750 ns | 1.028 ns |  44.37 ns |  46.42 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.91 ns | 39.988 ns | 2.192 ns | 117.40 ns | 121.42 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.05 ns** |  **6.395 ns** | **0.351 ns** |  **53.83 ns** |  **54.46 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 363.98 ns |  1.933 ns | 0.106 ns | 363.89 ns | 364.10 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 356.87 ns |  8.488 ns | 0.465 ns | 356.43 ns | 357.36 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 284.68 ns | 19.106 ns | 1.047 ns | 283.50 ns | 285.52 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.19 ns |  7.415 ns | 0.406 ns | 133.92 ns | 134.66 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.65 ns |  5.565 ns | 0.305 ns | 138.45 ns | 139.00 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 364.87 ns | 39.616 ns | 2.171 ns | 362.84 ns | 367.16 ns | 0.0057 |     504 B |
