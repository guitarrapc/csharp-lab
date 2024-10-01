```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.89 ns** |  **1.625 ns** | **0.089 ns** |  **17.83 ns** |  **17.99 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.25 ns |  4.596 ns | 0.252 ns | 122.08 ns | 122.54 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.23 ns |  5.182 ns | 0.284 ns | 118.06 ns | 118.55 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.38 ns |  9.433 ns | 0.517 ns |  92.98 ns |  93.96 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.90 ns |  4.555 ns | 0.250 ns |  44.63 ns |  45.12 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  43.88 ns |  2.276 ns | 0.125 ns |  43.81 ns |  44.03 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 118.43 ns | 10.927 ns | 0.599 ns | 117.93 ns | 119.09 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.50 ns** |  **8.019 ns** | **0.440 ns** |  **56.01 ns** |  **56.85 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.66 ns | 23.153 ns | 1.269 ns | 374.78 ns | 377.12 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.11 ns | 15.584 ns | 0.854 ns | 348.28 ns | 349.99 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 281.35 ns | 10.672 ns | 0.585 ns | 280.87 ns | 282.00 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.08 ns |  2.327 ns | 0.128 ns | 135.01 ns | 135.23 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.41 ns | 11.552 ns | 0.633 ns | 135.98 ns | 137.14 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 377.34 ns | 63.626 ns | 3.488 ns | 374.32 ns | 381.16 ns | 0.0057 |     504 B |
