```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **19.92 ns** |   **8.473 ns** |  **0.464 ns** |  **19.53 ns** |  **20.43 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 124.17 ns |   9.294 ns |  0.509 ns | 123.62 ns | 124.63 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 126.69 ns |  10.220 ns |  0.560 ns | 126.17 ns | 127.28 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  93.32 ns |  23.666 ns |  1.297 ns |  92.05 ns |  94.65 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  47.20 ns |   9.215 ns |  0.505 ns |  46.89 ns |  47.79 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  46.03 ns |   5.133 ns |  0.281 ns |  45.84 ns |  46.36 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 126.05 ns |  73.033 ns |  4.003 ns | 123.33 ns | 130.65 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  27.46 ns |   2.655 ns |  0.146 ns |  27.30 ns |  27.56 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 120.13 ns |  10.136 ns |  0.556 ns | 119.54 ns | 120.64 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 115.12 ns |   0.675 ns |  0.037 ns | 115.09 ns | 115.16 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  84.21 ns |   7.334 ns |  0.402 ns |  83.75 ns |  84.47 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  46.22 ns |   3.197 ns |  0.175 ns |  46.12 ns |  46.42 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  42.56 ns |  17.052 ns |  0.935 ns |  41.53 ns |  43.36 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 124.33 ns |   8.145 ns |  0.446 ns | 123.99 ns | 124.84 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **58.94 ns** |   **7.550 ns** |  **0.414 ns** |  **58.47 ns** |  **59.22 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 386.96 ns |  40.873 ns |  2.240 ns | 384.70 ns | 389.18 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 371.16 ns |  97.633 ns |  5.352 ns | 365.20 ns | 375.56 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 283.83 ns |  19.951 ns |  1.094 ns | 283.15 ns | 285.09 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 142.69 ns |   2.317 ns |  0.127 ns | 142.57 ns | 142.82 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 149.95 ns |  38.866 ns |  2.130 ns | 148.47 ns | 152.39 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 402.98 ns | 236.098 ns | 12.941 ns | 388.88 ns | 414.31 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  82.69 ns |   5.846 ns |  0.320 ns |  82.37 ns |  83.01 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 383.27 ns |  40.345 ns |  2.211 ns | 381.51 ns | 385.75 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 357.87 ns | 101.046 ns |  5.539 ns | 352.70 ns | 363.72 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 258.69 ns |  22.849 ns |  1.252 ns | 257.53 ns | 260.02 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 135.45 ns |  31.158 ns |  1.708 ns | 133.71 ns | 137.12 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 128.12 ns |  26.841 ns |  1.471 ns | 126.56 ns | 129.48 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 367.36 ns |  82.008 ns |  4.495 ns | 364.59 ns | 372.55 ns | 0.0300 |     504 B |
