```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.302
  [Host]   : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.27014), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.70 ns** |  **0.720 ns** | **0.039 ns** |  **17.66 ns** |  **17.74 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.89 ns |  6.869 ns | 0.377 ns | 121.66 ns | 122.32 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.65 ns |  6.263 ns | 0.343 ns | 115.40 ns | 116.04 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  88.99 ns |  1.775 ns | 0.097 ns |  88.92 ns |  89.10 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.84 ns |  1.211 ns | 0.066 ns |  44.80 ns |  44.92 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.55 ns | 22.584 ns | 1.238 ns |  44.18 ns |  46.59 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 120.80 ns | 54.529 ns | 2.989 ns | 117.41 ns | 123.03 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.19 ns** |  **3.448 ns** | **0.189 ns** |  **55.98 ns** |  **56.34 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 378.16 ns |  6.467 ns | 0.355 ns | 377.91 ns | 378.57 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 362.16 ns | 69.917 ns | 3.832 ns | 357.75 ns | 364.74 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 287.08 ns | 27.924 ns | 1.531 ns | 285.33 ns | 288.20 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.39 ns | 10.017 ns | 0.549 ns | 134.96 ns | 136.01 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.96 ns | 16.035 ns | 0.879 ns | 136.18 ns | 137.91 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.67 ns | 72.183 ns | 3.957 ns | 362.92 ns | 370.80 ns | 0.0057 |     504 B |
