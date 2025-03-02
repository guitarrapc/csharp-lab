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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.26 ns** |  **1.280 ns** | **0.070 ns** |  **16.21 ns** |  **16.34 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 117.99 ns |  3.627 ns | 0.199 ns | 117.76 ns | 118.13 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 113.37 ns |  5.283 ns | 0.290 ns | 113.07 ns | 113.65 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  93.21 ns | 12.096 ns | 0.663 ns |  92.65 ns |  93.94 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.63 ns |  6.686 ns | 0.366 ns |  42.38 ns |  43.05 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  41.89 ns |  2.199 ns | 0.121 ns |  41.77 ns |  42.01 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 115.86 ns | 60.678 ns | 3.326 ns | 113.50 ns | 119.67 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.48 ns |  2.982 ns | 0.163 ns |  25.38 ns |  25.67 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 114.93 ns |  7.639 ns | 0.419 ns | 114.63 ns | 115.41 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.20 ns |  4.388 ns | 0.241 ns | 110.92 ns | 111.37 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.04 ns | 10.199 ns | 0.559 ns |  79.52 ns |  80.63 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.22 ns |  3.538 ns | 0.194 ns |  41.02 ns |  41.41 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.91 ns |  5.800 ns | 0.318 ns |  38.66 ns |  39.27 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 114.01 ns |  4.111 ns | 0.225 ns | 113.75 ns | 114.14 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **50.93 ns** |  **3.745 ns** | **0.205 ns** |  **50.70 ns** |  **51.10 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 370.13 ns | 33.296 ns | 1.825 ns | 369.00 ns | 372.23 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.43 ns | 46.593 ns | 2.554 ns | 347.60 ns | 352.55 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 272.69 ns |  7.888 ns | 0.432 ns | 272.21 ns | 273.04 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.28 ns |  3.123 ns | 0.171 ns | 128.14 ns | 128.47 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 132.72 ns | 19.148 ns | 1.050 ns | 131.72 ns | 133.81 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 360.00 ns | 34.942 ns | 1.915 ns | 358.47 ns | 362.15 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.97 ns | 14.197 ns | 0.778 ns |  75.52 ns |  76.87 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 367.77 ns | 18.002 ns | 0.987 ns | 366.70 ns | 368.64 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 328.33 ns | 14.623 ns | 0.802 ns | 327.74 ns | 329.24 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 246.92 ns | 24.906 ns | 1.365 ns | 245.45 ns | 248.14 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 124.62 ns |  8.847 ns | 0.485 ns | 124.26 ns | 125.17 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.87 ns | 24.707 ns | 1.354 ns | 114.89 ns | 117.41 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 332.97 ns | 26.075 ns | 1.429 ns | 331.32 ns | 333.86 ns | 0.0300 |     504 B |
