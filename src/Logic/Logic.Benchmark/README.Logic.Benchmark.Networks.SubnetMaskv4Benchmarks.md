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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.24 ns** |   **2.576 ns** | **0.141 ns** |  **16.11 ns** |  **16.39 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 125.32 ns |   3.464 ns | 0.190 ns | 125.18 ns | 125.53 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 112.59 ns |   2.573 ns | 0.141 ns | 112.50 ns | 112.75 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  96.41 ns |   3.003 ns | 0.165 ns |  96.22 ns |  96.54 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  41.82 ns |   4.399 ns | 0.241 ns |  41.55 ns |  42.00 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  41.83 ns |   1.390 ns | 0.076 ns |  41.75 ns |  41.90 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.15 ns |  44.734 ns | 2.452 ns | 113.38 ns | 118.03 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.44 ns |   1.849 ns | 0.101 ns |  25.36 ns |  25.55 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 118.73 ns |   7.915 ns | 0.434 ns | 118.23 ns | 119.02 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.28 ns |  28.012 ns | 1.535 ns | 110.07 ns | 113.01 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.15 ns |   7.668 ns | 0.420 ns |  79.67 ns |  80.42 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.42 ns |  14.587 ns | 0.800 ns |  41.50 ns |  42.89 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.61 ns |   1.893 ns | 0.104 ns |  38.49 ns |  38.67 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 110.74 ns |  32.470 ns | 1.780 ns | 109.38 ns | 112.75 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.14 ns** |  **10.999 ns** | **0.603 ns** |  **50.69 ns** |  **51.83 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 359.67 ns |  24.690 ns | 1.353 ns | 358.11 ns | 360.52 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 353.55 ns | 158.833 ns | 8.706 ns | 348.18 ns | 363.60 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 273.22 ns |   6.713 ns | 0.368 ns | 272.94 ns | 273.64 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.90 ns |  35.768 ns | 1.961 ns | 127.68 ns | 131.16 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 135.11 ns |  22.104 ns | 1.212 ns | 133.82 ns | 136.23 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 366.31 ns | 115.200 ns | 6.314 ns | 359.26 ns | 371.47 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.24 ns |   3.031 ns | 0.166 ns |  74.08 ns |  74.41 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 357.81 ns |  13.674 ns | 0.750 ns | 357.15 ns | 358.62 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 330.47 ns |  30.031 ns | 1.646 ns | 328.81 ns | 332.10 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 253.60 ns |  14.536 ns | 0.797 ns | 252.78 ns | 254.37 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 126.00 ns |  41.013 ns | 2.248 ns | 124.17 ns | 128.51 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 117.72 ns |  16.486 ns | 0.904 ns | 116.68 ns | 118.29 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 343.03 ns |  56.884 ns | 3.118 ns | 339.45 ns | 345.14 ns | 0.0300 |     504 B |
