```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.14 ns** |  **2.417 ns** | **0.133 ns** |  **16.02 ns** |  **16.28 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.11 ns | 24.721 ns | 1.355 ns | 119.20 ns | 121.67 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 112.56 ns |  7.885 ns | 0.432 ns | 112.15 ns | 113.01 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.22 ns | 17.147 ns | 0.940 ns |  89.67 ns |  91.30 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  41.70 ns |  0.525 ns | 0.029 ns |  41.67 ns |  41.73 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.66 ns |  5.747 ns | 0.315 ns |  42.45 ns |  43.02 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.95 ns | 56.138 ns | 3.077 ns | 113.42 ns | 119.10 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.22 ns |  0.807 ns | 0.044 ns |  25.18 ns |  25.27 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.18 ns | 22.233 ns | 1.219 ns | 115.34 ns | 117.58 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 110.03 ns |  5.117 ns | 0.280 ns | 109.80 ns | 110.34 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  79.49 ns |  5.087 ns | 0.279 ns |  79.21 ns |  79.76 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  40.54 ns |  1.227 ns | 0.067 ns |  40.47 ns |  40.61 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.42 ns |  7.569 ns | 0.415 ns |  38.12 ns |  38.89 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 114.50 ns |  7.105 ns | 0.389 ns | 114.17 ns | 114.93 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **50.87 ns** |  **3.204 ns** | **0.176 ns** |  **50.74 ns** |  **51.07 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 364.60 ns | 10.709 ns | 0.587 ns | 363.92 ns | 364.96 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 336.17 ns | 17.055 ns | 0.935 ns | 335.55 ns | 337.24 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 280.81 ns | 15.964 ns | 0.875 ns | 280.28 ns | 281.82 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.35 ns |  5.714 ns | 0.313 ns | 128.15 ns | 128.71 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 134.86 ns |  5.594 ns | 0.307 ns | 134.64 ns | 135.21 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 357.70 ns | 27.440 ns | 1.504 ns | 356.02 ns | 358.91 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.28 ns |  5.976 ns | 0.328 ns |  74.08 ns |  74.66 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 350.98 ns | 59.265 ns | 3.249 ns | 348.49 ns | 354.66 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 326.82 ns | 27.890 ns | 1.529 ns | 325.90 ns | 328.58 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 247.47 ns | 48.095 ns | 2.636 ns | 245.27 ns | 250.40 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.56 ns |  7.226 ns | 0.396 ns | 123.21 ns | 123.99 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.81 ns |  4.567 ns | 0.250 ns | 115.63 ns | 116.09 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 337.29 ns | 16.066 ns | 0.881 ns | 336.58 ns | 338.27 ns | 0.0300 |     504 B |
