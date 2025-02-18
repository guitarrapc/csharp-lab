```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.89 ns** |  **4.962 ns** | **0.272 ns** |  **16.68 ns** |  **17.20 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.54 ns |  5.019 ns | 0.275 ns | 120.24 ns | 120.78 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.49 ns |  7.352 ns | 0.403 ns | 116.05 ns | 116.84 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.98 ns | 11.583 ns | 0.635 ns |  90.57 ns |  91.71 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.58 ns |  2.050 ns | 0.112 ns |  42.49 ns |  42.70 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.38 ns |  4.000 ns | 0.219 ns |  42.18 ns |  42.61 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 114.71 ns | 21.528 ns | 1.180 ns | 113.51 ns | 115.87 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.77 ns |  4.100 ns | 0.225 ns |  25.58 ns |  26.02 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.37 ns |  5.734 ns | 0.314 ns | 115.05 ns | 115.68 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 109.84 ns |  5.381 ns | 0.295 ns | 109.57 ns | 110.15 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  82.66 ns |  5.405 ns | 0.296 ns |  82.33 ns |  82.91 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.61 ns |  0.809 ns | 0.044 ns |  41.58 ns |  41.66 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.30 ns |  8.830 ns | 0.484 ns |  38.81 ns |  39.77 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 112.26 ns | 31.731 ns | 1.739 ns | 110.31 ns | 113.65 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.84 ns** | **15.095 ns** | **0.827 ns** |  **50.88 ns** |  **52.34 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 365.03 ns | 33.344 ns | 1.828 ns | 362.93 ns | 366.26 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 341.97 ns | 30.242 ns | 1.658 ns | 340.16 ns | 343.41 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 275.93 ns | 17.885 ns | 0.980 ns | 275.15 ns | 277.03 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 129.36 ns |  4.625 ns | 0.253 ns | 129.13 ns | 129.63 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 134.82 ns | 28.201 ns | 1.546 ns | 133.04 ns | 135.85 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 366.63 ns | 70.316 ns | 3.854 ns | 363.28 ns | 370.84 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.52 ns |  6.503 ns | 0.356 ns |  74.17 ns |  74.88 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 357.72 ns |  6.839 ns | 0.375 ns | 357.42 ns | 358.14 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 329.21 ns | 12.321 ns | 0.675 ns | 328.46 ns | 329.78 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 275.42 ns |  7.420 ns | 0.407 ns | 274.98 ns | 275.79 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 124.80 ns | 20.175 ns | 1.106 ns | 123.76 ns | 125.96 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.83 ns |  2.653 ns | 0.145 ns | 115.74 ns | 116.00 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 351.40 ns | 62.765 ns | 3.440 ns | 348.29 ns | 355.10 ns | 0.0300 |     504 B |
