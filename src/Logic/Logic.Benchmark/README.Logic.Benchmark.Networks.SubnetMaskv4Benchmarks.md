```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **15.99 ns** |   **0.296 ns** |  **0.016 ns** |  **15.97 ns** |  **16.00 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 119.19 ns |   9.218 ns |  0.505 ns | 118.78 ns | 119.76 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 114.63 ns |   5.210 ns |  0.286 ns | 114.40 ns | 114.95 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.25 ns |  14.053 ns |  0.770 ns |  87.76 ns |  89.14 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  41.84 ns |   5.867 ns |  0.322 ns |  41.51 ns |  42.15 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.62 ns |   0.987 ns |  0.054 ns |  42.56 ns |  42.66 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.92 ns |  34.794 ns |  1.907 ns | 114.93 ns | 118.73 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  24.53 ns |   1.574 ns |  0.086 ns |  24.46 ns |  24.63 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.43 ns |   8.713 ns |  0.478 ns | 115.08 ns | 115.97 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 109.95 ns |   5.675 ns |  0.311 ns | 109.77 ns | 110.31 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  79.44 ns |   7.265 ns |  0.398 ns |  79.06 ns |  79.86 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.16 ns |   4.445 ns |  0.244 ns |  41.88 ns |  42.33 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.50 ns |   2.773 ns |  0.152 ns |  38.40 ns |  38.68 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 110.81 ns |  26.567 ns |  1.456 ns | 109.15 ns | 111.87 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.57 ns** |  **10.218 ns** |  **0.560 ns** |  **50.92 ns** |  **51.89 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 366.51 ns |  24.404 ns |  1.338 ns | 365.32 ns | 367.96 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 349.69 ns |  31.207 ns |  1.711 ns | 347.80 ns | 351.14 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 271.29 ns |  38.101 ns |  2.088 ns | 269.16 ns | 273.33 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 135.88 ns |   6.828 ns |  0.374 ns | 135.58 ns | 136.30 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 136.27 ns |   9.429 ns |  0.517 ns | 135.67 ns | 136.57 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 364.81 ns | 185.862 ns | 10.188 ns | 356.69 ns | 376.24 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  77.05 ns |   7.223 ns |  0.396 ns |  76.60 ns |  77.31 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 360.28 ns |  72.787 ns |  3.990 ns | 356.21 ns | 364.18 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 329.23 ns |  33.195 ns |  1.820 ns | 328.02 ns | 331.32 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 247.64 ns |   9.399 ns |  0.515 ns | 247.16 ns | 248.19 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.88 ns |   8.440 ns |  0.463 ns | 123.53 ns | 124.41 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 114.57 ns |   3.909 ns |  0.214 ns | 114.44 ns | 114.82 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 345.25 ns |  90.759 ns |  4.975 ns | 340.35 ns | 350.29 ns | 0.0300 |     504 B |
