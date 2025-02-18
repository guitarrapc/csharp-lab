```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.29 ns** |  **0.978 ns** | **0.054 ns** |  **16.25 ns** |  **16.35 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 118.24 ns |  5.177 ns | 0.284 ns | 118.05 ns | 118.57 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.53 ns | 19.337 ns | 1.060 ns | 115.35 ns | 117.40 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.93 ns |  0.441 ns | 0.024 ns |  88.90 ns |  88.95 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.66 ns |  1.565 ns | 0.086 ns |  42.58 ns |  42.75 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  45.13 ns | 55.694 ns | 3.053 ns |  43.06 ns |  48.64 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 118.70 ns |  9.177 ns | 0.503 ns | 118.13 ns | 119.06 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.51 ns |  2.889 ns | 0.158 ns |  25.34 ns |  25.66 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.11 ns | 29.387 ns | 1.611 ns | 114.88 ns | 117.93 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 130.31 ns | 10.413 ns | 0.571 ns | 129.76 ns | 130.90 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.03 ns |  2.366 ns | 0.130 ns |  79.91 ns |  80.17 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.12 ns |  4.740 ns | 0.260 ns |  40.93 ns |  41.42 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.84 ns |  6.706 ns | 0.368 ns |  38.42 ns |  39.07 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 113.65 ns |  0.835 ns | 0.046 ns | 113.60 ns | 113.69 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.64 ns** |  **3.662 ns** | **0.201 ns** |  **51.46 ns** |  **51.86 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 360.36 ns | 12.123 ns | 0.664 ns | 359.77 ns | 361.08 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.75 ns | 22.892 ns | 1.255 ns | 349.32 ns | 351.67 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 270.58 ns | 12.002 ns | 0.658 ns | 269.86 ns | 271.16 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 130.32 ns |  6.108 ns | 0.335 ns | 129.98 ns | 130.65 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 134.74 ns | 28.612 ns | 1.568 ns | 132.95 ns | 135.85 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 363.94 ns | 51.230 ns | 2.808 ns | 361.43 ns | 366.97 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.34 ns |  8.457 ns | 0.464 ns |  73.91 ns |  74.83 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 364.91 ns | 47.084 ns | 2.581 ns | 362.81 ns | 367.79 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 328.61 ns | 28.511 ns | 1.563 ns | 326.83 ns | 329.75 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 251.45 ns | 44.572 ns | 2.443 ns | 249.66 ns | 254.23 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.07 ns | 12.376 ns | 0.678 ns | 122.46 ns | 123.80 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.60 ns |  1.706 ns | 0.094 ns | 115.49 ns | 115.65 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 345.58 ns | 46.236 ns | 2.534 ns | 343.98 ns | 348.50 ns | 0.0300 |     504 B |
