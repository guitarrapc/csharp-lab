```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **18.57 ns** |  **33.803 ns** |  **1.853 ns** |  **16.43 ns** |  **19.70 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 118.65 ns |   6.270 ns |  0.344 ns | 118.31 ns | 119.00 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 113.33 ns |  15.019 ns |  0.823 ns | 112.59 ns | 114.22 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.18 ns |   6.891 ns |  0.378 ns |  87.91 ns |  88.61 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.68 ns |  10.453 ns |  0.573 ns |  42.29 ns |  43.33 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.82 ns |   2.470 ns |  0.135 ns |  42.66 ns |  42.90 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 112.00 ns |   8.165 ns |  0.448 ns | 111.58 ns | 112.47 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.07 ns |   7.272 ns |  0.399 ns |  24.61 ns |  25.32 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.45 ns |   7.231 ns |  0.396 ns | 116.16 ns | 116.90 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 109.24 ns |   1.898 ns |  0.104 ns | 109.16 ns | 109.36 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.71 ns |   6.174 ns |  0.338 ns |  80.33 ns |  80.98 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  40.80 ns |   3.824 ns |  0.210 ns |  40.63 ns |  41.03 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.51 ns |  12.293 ns |  0.674 ns |  37.97 ns |  39.26 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 116.44 ns |   4.694 ns |  0.257 ns | 116.22 ns | 116.72 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **50.68 ns** |   **3.815 ns** |  **0.209 ns** |  **50.44 ns** |  **50.83 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 359.29 ns |  26.868 ns |  1.473 ns | 358.42 ns | 360.99 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 367.83 ns | 110.198 ns |  6.040 ns | 360.87 ns | 371.79 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 277.85 ns |   4.276 ns |  0.234 ns | 277.61 ns | 278.07 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 127.17 ns |   3.095 ns |  0.170 ns | 126.98 ns | 127.28 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 143.97 ns |   5.657 ns |  0.310 ns | 143.67 ns | 144.28 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 361.01 ns |  43.287 ns |  2.373 ns | 359.23 ns | 363.70 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.24 ns |   7.666 ns |  0.420 ns |  73.96 ns |  74.73 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 365.55 ns |  20.104 ns |  1.102 ns | 364.37 ns | 366.54 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 330.86 ns |  13.418 ns |  0.735 ns | 330.14 ns | 331.61 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 248.02 ns |  17.530 ns |  0.961 ns | 247.21 ns | 249.08 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.31 ns |   9.385 ns |  0.514 ns | 122.86 ns | 123.87 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.31 ns |   5.194 ns |  0.285 ns | 115.10 ns | 115.64 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 343.77 ns | 216.645 ns | 11.875 ns | 330.06 ns | 350.98 ns | 0.0300 |     504 B |
