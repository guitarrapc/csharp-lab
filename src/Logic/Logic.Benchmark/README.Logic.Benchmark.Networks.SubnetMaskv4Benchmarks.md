```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **17.02 ns** |   **3.436 ns** | **0.188 ns** |  **16.88 ns** |  **17.23 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 124.24 ns |   6.197 ns | 0.340 ns | 123.97 ns | 124.62 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 114.89 ns |   5.392 ns | 0.296 ns | 114.57 ns | 115.16 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  89.99 ns |   7.009 ns | 0.384 ns |  89.68 ns |  90.42 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.54 ns |   5.716 ns | 0.313 ns |  42.26 ns |  42.88 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.17 ns |   5.169 ns | 0.283 ns |  41.99 ns |  42.50 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 118.68 ns |  53.683 ns | 2.943 ns | 116.17 ns | 121.92 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.55 ns |   2.632 ns | 0.144 ns |  25.42 ns |  25.70 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.95 ns |  11.438 ns | 0.627 ns | 116.32 ns | 117.57 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 113.27 ns |  12.674 ns | 0.695 ns | 112.66 ns | 114.02 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  84.72 ns |   6.774 ns | 0.371 ns |  84.43 ns |  85.14 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.44 ns |   7.124 ns | 0.390 ns |  42.20 ns |  42.89 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.86 ns |   6.562 ns | 0.360 ns |  38.47 ns |  39.18 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 112.32 ns |  37.867 ns | 2.076 ns | 110.01 ns | 114.04 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.18 ns** |   **2.328 ns** | **0.128 ns** |  **51.04 ns** |  **51.29 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 370.11 ns |  27.169 ns | 1.489 ns | 368.69 ns | 371.66 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 340.26 ns |  20.707 ns | 1.135 ns | 339.48 ns | 341.56 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 270.44 ns |  13.233 ns | 0.725 ns | 269.99 ns | 271.28 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.66 ns |   5.833 ns | 0.320 ns | 128.29 ns | 128.89 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 136.54 ns |  57.078 ns | 3.129 ns | 133.67 ns | 139.88 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 365.78 ns | 122.300 ns | 6.704 ns | 360.43 ns | 373.30 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  73.77 ns |   5.822 ns | 0.319 ns |  73.46 ns |  74.10 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 356.91 ns |  29.748 ns | 1.631 ns | 355.40 ns | 358.63 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 336.68 ns |  31.122 ns | 1.706 ns | 335.49 ns | 338.63 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 252.61 ns |  20.957 ns | 1.149 ns | 251.42 ns | 253.72 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 127.21 ns |  10.548 ns | 0.578 ns | 126.55 ns | 127.64 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.18 ns |  12.163 ns | 0.667 ns | 114.58 ns | 115.90 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 336.91 ns |  47.745 ns | 2.617 ns | 335.38 ns | 339.93 ns | 0.0300 |     504 B |
