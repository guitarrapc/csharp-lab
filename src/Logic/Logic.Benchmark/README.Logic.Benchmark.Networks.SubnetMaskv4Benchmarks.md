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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.27 ns** |   **2.903 ns** |  **0.159 ns** |  **16.17 ns** |  **16.45 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 125.26 ns |  61.657 ns |  3.380 ns | 123.23 ns | 129.16 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 117.30 ns |  22.106 ns |  1.212 ns | 116.40 ns | 118.68 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.42 ns |   5.811 ns |  0.319 ns |  90.17 ns |  90.77 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.64 ns |   4.915 ns |  0.269 ns |  42.46 ns |  42.95 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  44.41 ns |  10.276 ns |  0.563 ns |  44.07 ns |  45.06 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.44 ns |  11.335 ns |  0.621 ns | 115.72 ns | 116.81 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.23 ns |   4.537 ns |  0.249 ns |  25.01 ns |  25.50 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 119.46 ns |   9.897 ns |  0.542 ns | 118.85 ns | 119.90 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 112.48 ns |  11.397 ns |  0.625 ns | 111.87 ns | 113.12 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  82.20 ns |   7.827 ns |  0.429 ns |  81.74 ns |  82.59 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.82 ns |   5.563 ns |  0.305 ns |  41.48 ns |  42.07 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  42.19 ns |   5.223 ns |  0.286 ns |  41.87 ns |  42.42 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 115.96 ns |   9.224 ns |  0.506 ns | 115.41 ns | 116.40 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **52.59 ns** |  **17.811 ns** |  **0.976 ns** |  **51.77 ns** |  **53.67 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 372.30 ns |  56.358 ns |  3.089 ns | 368.93 ns | 374.99 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.86 ns |  41.489 ns |  2.274 ns | 348.25 ns | 352.41 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 279.57 ns |  26.809 ns |  1.469 ns | 278.66 ns | 281.27 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.58 ns |   3.942 ns |  0.216 ns | 128.44 ns | 128.83 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 133.93 ns |  16.842 ns |  0.923 ns | 132.97 ns | 134.81 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 363.08 ns |  10.122 ns |  0.555 ns | 362.55 ns | 363.66 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.86 ns |   2.403 ns |  0.132 ns |  74.72 ns |  74.99 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 366.15 ns |  36.892 ns |  2.022 ns | 364.63 ns | 368.45 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 328.85 ns |   2.842 ns |  0.156 ns | 328.71 ns | 329.02 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 252.69 ns |  68.279 ns |  3.743 ns | 250.47 ns | 257.01 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 129.21 ns |  10.444 ns |  0.572 ns | 128.58 ns | 129.69 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 129.24 ns |  12.870 ns |  0.705 ns | 128.73 ns | 130.05 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 340.38 ns | 203.275 ns | 11.142 ns | 329.67 ns | 351.91 ns | 0.0300 |     504 B |
