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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.67 ns** |   **5.448 ns** | **0.299 ns** |  **16.35 ns** |  **16.94 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 119.61 ns |  15.203 ns | 0.833 ns | 119.05 ns | 120.57 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.41 ns |  20.398 ns | 1.118 ns | 115.45 ns | 117.64 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.56 ns |   5.375 ns | 0.295 ns |  88.32 ns |  88.89 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.41 ns |   4.433 ns | 0.243 ns |  42.25 ns |  42.69 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.55 ns |   1.758 ns | 0.096 ns |  42.45 ns |  42.65 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 115.01 ns |  51.639 ns | 2.830 ns | 112.24 ns | 117.89 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.44 ns |   6.153 ns | 0.337 ns |  25.20 ns |  25.82 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.55 ns |  37.942 ns | 2.080 ns | 113.18 ns | 117.07 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.53 ns |   9.141 ns | 0.501 ns | 111.17 ns | 112.10 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  79.83 ns |  10.550 ns | 0.578 ns |  79.50 ns |  80.50 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  43.00 ns |   3.797 ns | 0.208 ns |  42.78 ns |  43.19 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.04 ns |  15.451 ns | 0.847 ns |  38.40 ns |  40.00 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 111.54 ns |  60.180 ns | 3.299 ns | 107.73 ns | 113.56 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **50.69 ns** |   **3.485 ns** | **0.191 ns** |  **50.48 ns** |  **50.86 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 363.69 ns |  13.325 ns | 0.730 ns | 363.05 ns | 364.48 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 347.56 ns |   2.268 ns | 0.124 ns | 347.44 ns | 347.69 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 269.50 ns |  10.789 ns | 0.591 ns | 269.12 ns | 270.18 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.64 ns |   4.893 ns | 0.268 ns | 128.33 ns | 128.80 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 134.67 ns |   4.978 ns | 0.273 ns | 134.36 ns | 134.87 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 355.47 ns |  37.685 ns | 2.066 ns | 353.09 ns | 356.79 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  73.66 ns |   3.107 ns | 0.170 ns |  73.55 ns |  73.86 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 357.63 ns |  51.498 ns | 2.823 ns | 355.74 ns | 360.87 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 327.79 ns |  24.674 ns | 1.352 ns | 326.92 ns | 329.35 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.15 ns |  18.526 ns | 1.015 ns | 249.50 ns | 251.32 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 122.85 ns |  12.545 ns | 0.688 ns | 122.45 ns | 123.64 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 118.55 ns | 101.219 ns | 5.548 ns | 115.26 ns | 124.95 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 337.23 ns |  75.922 ns | 4.162 ns | 333.18 ns | 341.50 ns | 0.0300 |     504 B |
