```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **26.02 ns** |  **2.559 ns** | **0.140 ns** |  **25.89 ns** |  **26.17 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 118.82 ns |  1.757 ns | 0.096 ns | 118.71 ns | 118.89 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 113.50 ns |  1.359 ns | 0.075 ns | 113.45 ns | 113.58 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  81.29 ns |  1.882 ns | 0.103 ns |  81.17 ns |  81.35 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  43.52 ns |  3.334 ns | 0.183 ns |  43.33 ns |  43.70 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  39.99 ns |  7.469 ns | 0.409 ns |  39.63 ns |  40.44 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 111.23 ns | 19.246 ns | 1.055 ns | 110.39 ns | 112.41 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **78.06 ns** |  **0.944 ns** | **0.052 ns** |  **78.00 ns** |  **78.10 ns** | **0.0019** |     **168 B** |
| FromCidrAddress     | 3      | 358.49 ns | 17.104 ns | 0.938 ns | 357.71 ns | 359.53 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 336.30 ns | 46.433 ns | 2.545 ns | 334.65 ns | 339.23 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 257.07 ns |  3.235 ns | 0.177 ns | 256.87 ns | 257.19 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 130.40 ns |  9.358 ns | 0.513 ns | 130.10 ns | 130.99 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 118.84 ns |  5.432 ns | 0.298 ns | 118.58 ns | 119.17 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 346.46 ns | 98.449 ns | 5.396 ns | 340.40 ns | 350.74 ns | 0.0057 |     504 B |
