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
| **FromPrefix**          | **1**      |  **25.62 ns** |  **5.427 ns** | **0.297 ns** |  **25.32 ns** |  **25.91 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 118.01 ns |  7.170 ns | 0.393 ns | 117.62 ns | 118.41 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 111.96 ns | 14.855 ns | 0.814 ns | 111.02 ns | 112.44 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.24 ns |  3.524 ns | 0.193 ns |  81.09 ns |  81.45 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.90 ns |  1.634 ns | 0.090 ns |  41.84 ns |  42.00 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.55 ns |  5.262 ns | 0.288 ns |  39.34 ns |  39.88 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 115.43 ns | 34.914 ns | 1.914 ns | 113.25 ns | 116.87 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **77.32 ns** | **10.268 ns** | **0.563 ns** |  **76.72 ns** |  **77.83 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 357.31 ns | 45.804 ns | 2.511 ns | 355.66 ns | 360.20 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 336.65 ns | 28.314 ns | 1.552 ns | 335.28 ns | 338.34 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 251.55 ns | 42.390 ns | 2.324 ns | 249.97 ns | 254.21 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 123.26 ns |  4.758 ns | 0.261 ns | 122.99 ns | 123.51 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 117.49 ns | 25.858 ns | 1.417 ns | 116.08 ns | 118.91 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 342.12 ns | 27.603 ns | 1.513 ns | 340.83 ns | 343.79 ns | 0.0300 |     504 B |
