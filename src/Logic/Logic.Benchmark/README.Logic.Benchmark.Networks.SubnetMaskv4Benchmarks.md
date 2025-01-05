```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **25.29 ns** |  **7.527 ns** | **0.413 ns** |  **24.88 ns** |  **25.71 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 115.58 ns | 13.455 ns | 0.737 ns | 115.07 ns | 116.43 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 112.44 ns | 15.606 ns | 0.855 ns | 111.50 ns | 113.17 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  82.54 ns |  9.253 ns | 0.507 ns |  82.01 ns |  83.02 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.04 ns |  2.768 ns | 0.152 ns |  40.89 ns |  41.19 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  38.93 ns |  7.078 ns | 0.388 ns |  38.66 ns |  39.37 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 112.46 ns | 45.853 ns | 2.513 ns | 109.83 ns | 114.84 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **75.80 ns** | **41.006 ns** | **2.248 ns** |  **74.47 ns** |  **78.40 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 358.12 ns | 21.494 ns | 1.178 ns | 357.17 ns | 359.44 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 331.89 ns | 32.969 ns | 1.807 ns | 329.97 ns | 333.56 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 252.84 ns | 26.514 ns | 1.453 ns | 251.31 ns | 254.20 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 125.64 ns | 28.302 ns | 1.551 ns | 124.11 ns | 127.21 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 115.72 ns |  5.858 ns | 0.321 ns | 115.35 ns | 115.92 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 336.40 ns | 95.982 ns | 5.261 ns | 331.76 ns | 342.12 ns | 0.0300 |     504 B |
