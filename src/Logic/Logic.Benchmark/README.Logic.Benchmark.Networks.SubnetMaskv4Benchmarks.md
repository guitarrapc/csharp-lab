```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.17 ns** |   **2.254 ns** | **0.124 ns** |  **16.04 ns** |  **16.28 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.81 ns |   4.040 ns | 0.221 ns | 120.64 ns | 121.06 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 118.48 ns |  13.457 ns | 0.738 ns | 117.98 ns | 119.33 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.68 ns |   6.718 ns | 0.368 ns |  88.30 ns |  89.04 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.78 ns |   4.475 ns | 0.245 ns |  42.53 ns |  43.03 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.28 ns |   2.491 ns | 0.137 ns |  43.15 ns |  43.42 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 115.86 ns |  16.592 ns | 0.909 ns | 114.88 ns | 116.68 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.99 ns |   5.236 ns | 0.287 ns |  25.65 ns |  26.15 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.57 ns |   9.813 ns | 0.538 ns | 115.19 ns | 116.19 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 109.89 ns |   6.770 ns | 0.371 ns | 109.52 ns | 110.27 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.50 ns |  16.752 ns | 0.918 ns |  80.81 ns |  82.54 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.08 ns |   1.161 ns | 0.064 ns |  42.01 ns |  42.12 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  40.64 ns |  64.980 ns | 3.562 ns |  38.54 ns |  44.75 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 116.26 ns |  11.389 ns | 0.624 ns | 115.62 ns | 116.86 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.45 ns** |   **2.208 ns** | **0.121 ns** |  **51.33 ns** |  **51.57 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 368.57 ns |  18.788 ns | 1.030 ns | 367.68 ns | 369.70 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.84 ns |   9.025 ns | 0.495 ns | 350.28 ns | 351.20 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 278.11 ns |  14.223 ns | 0.780 ns | 277.43 ns | 278.96 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 129.02 ns |   8.749 ns | 0.480 ns | 128.64 ns | 129.56 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 141.02 ns |  23.394 ns | 1.282 ns | 139.72 ns | 142.29 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 363.11 ns |  49.503 ns | 2.713 ns | 360.08 ns | 365.31 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.98 ns |   7.654 ns | 0.420 ns |  75.55 ns |  76.38 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 363.30 ns |  25.180 ns | 1.380 ns | 361.74 ns | 364.36 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 333.71 ns |  35.312 ns | 1.936 ns | 332.05 ns | 335.84 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.82 ns |  12.650 ns | 0.693 ns | 250.37 ns | 251.62 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.88 ns |  15.183 ns | 0.832 ns | 123.10 ns | 124.76 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 117.87 ns |  11.347 ns | 0.622 ns | 117.25 ns | 118.49 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 355.18 ns | 127.571 ns | 6.993 ns | 347.17 ns | 360.06 ns | 0.0300 |     504 B |
