```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **25.87 ns** |  **2.744 ns** | **0.150 ns** |  **25.69 ns** |  **25.96 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 114.65 ns |  8.311 ns | 0.456 ns | 114.32 ns | 115.17 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 111.83 ns |  7.169 ns | 0.393 ns | 111.40 ns | 112.17 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  80.54 ns |  7.347 ns | 0.403 ns |  80.08 ns |  80.85 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.51 ns |  3.906 ns | 0.214 ns |  41.32 ns |  41.74 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.13 ns |  6.458 ns | 0.354 ns |  38.82 ns |  39.51 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 117.29 ns | 16.553 ns | 0.907 ns | 116.71 ns | 118.34 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **76.43 ns** |  **6.810 ns** | **0.373 ns** |  **76.00 ns** |  **76.65 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 356.14 ns | 14.775 ns | 0.810 ns | 355.45 ns | 357.03 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 333.86 ns | 20.425 ns | 1.120 ns | 333.01 ns | 335.13 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 252.60 ns | 20.173 ns | 1.106 ns | 251.62 ns | 253.80 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 124.82 ns |  3.451 ns | 0.189 ns | 124.69 ns | 125.03 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 115.31 ns |  5.368 ns | 0.294 ns | 115.02 ns | 115.61 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 356.48 ns | 46.669 ns | 2.558 ns | 353.75 ns | 358.82 ns | 0.0300 |     504 B |
