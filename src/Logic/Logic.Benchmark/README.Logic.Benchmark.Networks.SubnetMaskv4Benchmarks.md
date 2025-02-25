```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.49 ns** |   **2.141 ns** | **0.117 ns** |  **16.35 ns** |  **16.56 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 129.10 ns |  13.458 ns | 0.738 ns | 128.57 ns | 129.94 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.57 ns |  12.286 ns | 0.673 ns | 115.80 ns | 117.04 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.54 ns |   3.535 ns | 0.194 ns |  91.41 ns |  91.77 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  44.47 ns |   6.756 ns | 0.370 ns |  44.07 ns |  44.80 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.68 ns |   6.475 ns | 0.355 ns |  43.43 ns |  44.08 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 118.53 ns |  16.431 ns | 0.901 ns | 117.77 ns | 119.52 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.76 ns |   1.137 ns | 0.062 ns |  25.71 ns |  25.83 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.41 ns |   4.689 ns | 0.257 ns | 116.17 ns | 116.68 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 113.54 ns |   3.834 ns | 0.210 ns | 113.39 ns | 113.78 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  82.56 ns |  18.304 ns | 1.003 ns |  81.71 ns |  83.67 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.62 ns |   5.582 ns | 0.306 ns |  41.40 ns |  41.97 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.42 ns |  17.754 ns | 0.973 ns |  38.79 ns |  40.54 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 115.39 ns |  27.396 ns | 1.502 ns | 113.67 ns | 116.45 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **52.39 ns** |   **8.233 ns** | **0.451 ns** |  **52.00 ns** |  **52.88 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 364.03 ns |  22.202 ns | 1.217 ns | 363.19 ns | 365.42 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.93 ns |  15.147 ns | 0.830 ns | 350.08 ns | 351.74 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 275.28 ns |  10.252 ns | 0.562 ns | 274.73 ns | 275.85 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 139.20 ns |  16.967 ns | 0.930 ns | 138.33 ns | 140.18 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 135.85 ns |  47.465 ns | 2.602 ns | 132.85 ns | 137.40 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 368.60 ns |  41.669 ns | 2.284 ns | 367.18 ns | 371.24 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.77 ns |   8.121 ns | 0.445 ns |  75.38 ns |  76.25 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 359.48 ns |  22.318 ns | 1.223 ns | 358.16 ns | 360.58 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 331.55 ns |  13.133 ns | 0.720 ns | 330.79 ns | 332.22 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.72 ns |  12.764 ns | 0.700 ns | 250.15 ns | 251.50 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 128.83 ns |   5.670 ns | 0.311 ns | 128.61 ns | 129.19 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 116.67 ns |  13.024 ns | 0.714 ns | 115.90 ns | 117.31 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 354.15 ns | 118.317 ns | 6.485 ns | 346.74 ns | 358.78 ns | 0.0300 |     504 B |
