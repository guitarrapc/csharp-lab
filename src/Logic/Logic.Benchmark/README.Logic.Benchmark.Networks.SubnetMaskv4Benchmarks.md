```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **18.27 ns** |  **3.878 ns** | **0.213 ns** |  **18.03 ns** |  **18.42 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 126.93 ns |  1.447 ns | 0.079 ns | 126.86 ns | 127.01 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 118.33 ns |  3.095 ns | 0.170 ns | 118.14 ns | 118.45 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.74 ns |  8.057 ns | 0.442 ns |  91.26 ns |  92.13 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  45.31 ns |  6.657 ns | 0.365 ns |  44.91 ns |  45.62 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  45.20 ns |  9.153 ns | 0.502 ns |  44.89 ns |  45.78 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 121.53 ns | 24.281 ns | 1.331 ns | 120.41 ns | 123.00 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  27.22 ns |  2.237 ns | 0.123 ns |  27.15 ns |  27.37 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 119.95 ns |  5.819 ns | 0.319 ns | 119.58 ns | 120.16 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 114.52 ns | 12.019 ns | 0.659 ns | 113.88 ns | 115.20 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  82.22 ns | 10.334 ns | 0.566 ns |  81.66 ns |  82.80 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  44.99 ns |  2.375 ns | 0.130 ns |  44.84 ns |  45.08 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  41.13 ns |  2.968 ns | 0.163 ns |  40.95 ns |  41.27 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 123.25 ns | 38.975 ns | 2.136 ns | 121.32 ns | 125.55 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **57.16 ns** |  **4.780 ns** | **0.262 ns** |  **56.87 ns** |  **57.38 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 383.75 ns | 23.037 ns | 1.263 ns | 382.46 ns | 384.98 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 365.43 ns | 44.579 ns | 2.444 ns | 363.26 ns | 368.07 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 283.16 ns | 13.068 ns | 0.716 ns | 282.35 ns | 283.73 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 139.77 ns | 16.456 ns | 0.902 ns | 139.18 ns | 140.81 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 142.62 ns | 47.468 ns | 2.602 ns | 139.78 ns | 144.89 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 372.67 ns | 40.049 ns | 2.195 ns | 370.75 ns | 375.06 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  80.41 ns |  7.812 ns | 0.428 ns |  79.93 ns |  80.76 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 365.86 ns | 12.893 ns | 0.707 ns | 365.05 ns | 366.34 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 344.36 ns | 27.439 ns | 1.504 ns | 342.70 ns | 345.64 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 255.37 ns | 24.685 ns | 1.353 ns | 254.34 ns | 256.90 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 134.92 ns | 28.966 ns | 1.588 ns | 133.09 ns | 135.87 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 122.09 ns |  2.448 ns | 0.134 ns | 122.01 ns | 122.25 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 366.51 ns | 37.681 ns | 2.065 ns | 364.24 ns | 368.28 ns | 0.0300 |     504 B |
