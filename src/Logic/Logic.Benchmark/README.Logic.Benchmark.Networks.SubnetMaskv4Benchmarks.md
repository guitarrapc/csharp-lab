```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.40 ns** |  **2.171 ns** | **0.119 ns** |  **16.31 ns** |  **16.53 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 117.97 ns |  5.323 ns | 0.292 ns | 117.69 ns | 118.27 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 115.56 ns |  7.527 ns | 0.413 ns | 115.28 ns | 116.04 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.38 ns |  3.708 ns | 0.203 ns |  88.25 ns |  88.62 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.86 ns |  4.728 ns | 0.259 ns |  42.59 ns |  43.10 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.31 ns |  1.847 ns | 0.101 ns |  43.19 ns |  43.37 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 113.95 ns | 11.927 ns | 0.654 ns | 113.29 ns | 114.60 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  18.88 ns |  1.091 ns | 0.060 ns |  18.84 ns |  18.95 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 111.43 ns |  7.167 ns | 0.393 ns | 111.09 ns | 111.86 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 106.95 ns | 11.408 ns | 0.625 ns | 106.45 ns | 107.65 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.42 ns |  5.877 ns | 0.322 ns |  80.17 ns |  80.78 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.17 ns |  1.469 ns | 0.081 ns |  41.08 ns |  41.23 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.30 ns |  5.188 ns | 0.284 ns |  39.00 ns |  39.57 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 113.62 ns | 49.288 ns | 2.702 ns | 110.50 ns | 115.21 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **52.36 ns** | **16.751 ns** | **0.918 ns** |  **51.37 ns** |  **53.19 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 374.25 ns | 47.715 ns | 2.615 ns | 372.56 ns | 377.26 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 351.48 ns |  5.100 ns | 0.280 ns | 351.29 ns | 351.80 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 272.45 ns | 10.887 ns | 0.597 ns | 271.77 ns | 272.90 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.24 ns |  2.138 ns | 0.117 ns | 128.12 ns | 128.35 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 135.49 ns | 29.698 ns | 1.628 ns | 133.72 ns | 136.92 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 355.86 ns | 24.544 ns | 1.345 ns | 354.32 ns | 356.85 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  55.17 ns | 10.817 ns | 0.593 ns |  54.59 ns |  55.77 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 372.30 ns | 11.072 ns | 0.607 ns | 371.79 ns | 372.97 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 321.93 ns | 29.511 ns | 1.618 ns | 320.97 ns | 323.80 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 249.98 ns | 40.766 ns | 2.235 ns | 247.77 ns | 252.24 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.29 ns | 13.114 ns | 0.719 ns | 122.67 ns | 124.08 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.15 ns | 10.071 ns | 0.552 ns | 114.64 ns | 115.74 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 338.27 ns | 59.854 ns | 3.281 ns | 334.86 ns | 341.41 ns | 0.0300 |     504 B |
