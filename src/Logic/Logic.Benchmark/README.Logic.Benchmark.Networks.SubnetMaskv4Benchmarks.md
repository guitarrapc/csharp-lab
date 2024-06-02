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
| **FromPrefix**          | **1**      |  **17.21 ns** |  **1.747 ns** | **0.096 ns** |  **17.14 ns** |  **17.32 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.66 ns |  5.620 ns | 0.308 ns | 121.31 ns | 121.86 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 160.56 ns |  5.558 ns | 0.305 ns | 160.37 ns | 160.91 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  91.07 ns |  1.782 ns | 0.098 ns |  90.96 ns |  91.16 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.49 ns |  0.994 ns | 0.055 ns |  44.44 ns |  44.55 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.84 ns | 33.579 ns | 1.841 ns |  44.23 ns |  47.85 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.96 ns | 16.442 ns | 0.901 ns | 121.92 ns | 123.53 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.40 ns** |  **9.311 ns** | **0.510 ns** |  **53.89 ns** |  **54.91 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.36 ns |  7.594 ns | 0.416 ns | 375.00 ns | 375.82 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 351.06 ns | 98.491 ns | 5.399 ns | 347.78 ns | 357.29 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 277.49 ns | 85.140 ns | 4.667 ns | 274.02 ns | 282.80 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 140.19 ns |  3.774 ns | 0.207 ns | 140.01 ns | 140.42 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 136.73 ns |  3.756 ns | 0.206 ns | 136.51 ns | 136.92 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.10 ns | 14.255 ns | 0.781 ns | 365.39 ns | 366.94 ns | 0.0057 |     504 B |
