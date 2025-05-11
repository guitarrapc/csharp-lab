```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.05 ns** |   **0.726 ns** | **0.040 ns** |  **16.01 ns** |  **16.09 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.70 ns |  14.188 ns | 0.778 ns | 119.91 ns | 121.47 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 115.73 ns |   8.541 ns | 0.468 ns | 115.28 ns | 116.21 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.50 ns |   0.903 ns | 0.049 ns |  91.45 ns |  91.55 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  44.62 ns |   7.474 ns | 0.410 ns |  44.15 ns |  44.91 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.15 ns |   1.279 ns | 0.070 ns |  42.09 ns |  42.22 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 115.40 ns |   9.245 ns | 0.507 ns | 114.83 ns | 115.78 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.71 ns |   3.780 ns | 0.207 ns |  25.50 ns |  25.92 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.11 ns |   3.351 ns | 0.184 ns | 115.94 ns | 116.31 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.71 ns |  15.900 ns | 0.872 ns | 110.80 ns | 112.54 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.33 ns |   8.114 ns | 0.445 ns |  80.04 ns |  80.84 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.98 ns |   6.551 ns | 0.359 ns |  41.58 ns |  42.27 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.74 ns |   0.642 ns | 0.035 ns |  38.71 ns |  38.78 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 112.55 ns |   3.033 ns | 0.166 ns | 112.40 ns | 112.73 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.41 ns** |  **11.739 ns** | **0.643 ns** |  **50.78 ns** |  **52.07 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 362.34 ns |  11.762 ns | 0.645 ns | 361.62 ns | 362.86 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.92 ns |  25.101 ns | 1.376 ns | 349.34 ns | 351.85 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 281.74 ns |  17.310 ns | 0.949 ns | 280.70 ns | 282.56 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 131.26 ns |   2.743 ns | 0.150 ns | 131.16 ns | 131.43 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 136.17 ns |  48.341 ns | 2.650 ns | 133.12 ns | 137.90 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 365.74 ns |  33.659 ns | 1.845 ns | 363.95 ns | 367.63 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  77.17 ns |   8.418 ns | 0.461 ns |  76.70 ns |  77.62 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 358.48 ns |   2.492 ns | 0.137 ns | 358.34 ns | 358.62 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 335.14 ns |  15.841 ns | 0.868 ns | 334.15 ns | 335.75 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 249.68 ns |  34.570 ns | 1.895 ns | 248.08 ns | 251.77 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 124.36 ns |   3.632 ns | 0.199 ns | 124.19 ns | 124.58 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 118.45 ns |  24.639 ns | 1.351 ns | 117.00 ns | 119.67 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 342.33 ns | 114.058 ns | 6.252 ns | 336.28 ns | 348.77 ns | 0.0300 |     504 B |
