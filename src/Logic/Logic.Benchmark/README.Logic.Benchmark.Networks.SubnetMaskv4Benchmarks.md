```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.32 ns** |   **3.406 ns** |  **0.187 ns** |  **16.16 ns** |  **16.53 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 122.41 ns |   8.137 ns |  0.446 ns | 121.95 ns | 122.83 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 114.66 ns |  11.482 ns |  0.629 ns | 114.15 ns | 115.36 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.02 ns |   5.006 ns |  0.274 ns |  90.80 ns |  91.32 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  44.25 ns |   5.467 ns |  0.300 ns |  44.02 ns |  44.59 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.03 ns |   5.470 ns |  0.300 ns |  41.85 ns |  42.38 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 123.79 ns |  42.198 ns |  2.313 ns | 121.33 ns | 125.92 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  26.23 ns |   1.690 ns |  0.093 ns |  26.13 ns |  26.32 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 118.91 ns |  13.378 ns |  0.733 ns | 118.36 ns | 119.74 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 113.46 ns |   9.143 ns |  0.501 ns | 112.88 ns | 113.76 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.58 ns |  17.326 ns |  0.950 ns |  79.99 ns |  81.67 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.30 ns |  10.450 ns |  0.573 ns |  41.83 ns |  42.94 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.30 ns |  12.282 ns |  0.673 ns |  38.79 ns |  40.07 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 119.29 ns |  36.900 ns |  2.023 ns | 117.95 ns | 121.62 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **53.48 ns** |  **29.582 ns** |  **1.621 ns** |  **51.70 ns** |  **54.86 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 363.05 ns |  13.114 ns |  0.719 ns | 362.56 ns | 363.88 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 362.86 ns | 247.214 ns | 13.551 ns | 354.82 ns | 378.51 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 276.97 ns |  67.317 ns |  3.690 ns | 273.61 ns | 280.92 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 138.18 ns |  15.483 ns |  0.849 ns | 137.68 ns | 139.16 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 135.82 ns |  15.757 ns |  0.864 ns | 135.32 ns | 136.82 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 375.94 ns |  75.756 ns |  4.152 ns | 371.15 ns | 378.50 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  77.80 ns |  10.155 ns |  0.557 ns |  77.35 ns |  78.43 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 386.28 ns | 189.647 ns | 10.395 ns | 380.06 ns | 398.28 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 338.43 ns |  17.501 ns |  0.959 ns | 337.40 ns | 339.29 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 253.23 ns |  27.679 ns |  1.517 ns | 251.56 ns | 254.52 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 133.17 ns |   6.746 ns |  0.370 ns | 132.84 ns | 133.57 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 122.50 ns |  24.856 ns |  1.362 ns | 121.46 ns | 124.05 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 353.25 ns | 107.388 ns |  5.886 ns | 348.83 ns | 359.93 ns | 0.0300 |     504 B |
