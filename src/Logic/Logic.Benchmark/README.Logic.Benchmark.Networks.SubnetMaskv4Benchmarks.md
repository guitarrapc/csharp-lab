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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.26 ns** |   **3.293 ns** | **0.181 ns** |  **16.05 ns** |  **16.36 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 122.91 ns |   5.771 ns | 0.316 ns | 122.72 ns | 123.28 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 117.70 ns |   7.575 ns | 0.415 ns | 117.22 ns | 117.95 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  89.01 ns |   3.764 ns | 0.206 ns |  88.78 ns |  89.18 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  43.20 ns |   2.085 ns | 0.114 ns |  43.08 ns |  43.30 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.65 ns |   1.412 ns | 0.077 ns |  42.56 ns |  42.70 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 117.19 ns |  32.552 ns | 1.784 ns | 115.13 ns | 118.34 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.70 ns |   2.048 ns | 0.112 ns |  25.58 ns |  25.80 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.26 ns |   7.936 ns | 0.435 ns | 115.90 ns | 116.74 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.32 ns |  12.126 ns | 0.665 ns | 110.56 ns | 111.72 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.86 ns |   6.540 ns | 0.358 ns |  80.52 ns |  81.24 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.80 ns |   3.767 ns | 0.206 ns |  41.61 ns |  42.02 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.02 ns |   5.327 ns | 0.292 ns |  38.73 ns |  39.32 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 109.23 ns |   9.122 ns | 0.500 ns | 108.80 ns | 109.78 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **52.17 ns** |   **7.017 ns** | **0.385 ns** |  **51.73 ns** |  **52.41 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 376.23 ns |  25.361 ns | 1.390 ns | 375.13 ns | 377.79 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 340.36 ns |   3.333 ns | 0.183 ns | 340.21 ns | 340.57 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 280.25 ns |  48.943 ns | 2.683 ns | 278.48 ns | 283.34 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 130.46 ns |  24.436 ns | 1.339 ns | 129.03 ns | 131.69 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 134.90 ns |  33.051 ns | 1.812 ns | 132.81 ns | 136.01 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 357.63 ns | 151.085 ns | 8.281 ns | 351.81 ns | 367.11 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.25 ns |   2.848 ns | 0.156 ns |  75.12 ns |  75.42 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 362.81 ns |  15.466 ns | 0.848 ns | 362.01 ns | 363.70 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 331.26 ns |   4.360 ns | 0.239 ns | 330.98 ns | 331.41 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.41 ns |   9.544 ns | 0.523 ns | 249.80 ns | 250.71 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 125.16 ns |   6.627 ns | 0.363 ns | 124.75 ns | 125.46 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 117.15 ns |  16.214 ns | 0.889 ns | 116.29 ns | 118.07 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 336.78 ns |  28.431 ns | 1.558 ns | 335.16 ns | 338.27 ns | 0.0300 |     504 B |
