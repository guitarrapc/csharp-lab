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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.16 ns** |  **0.371 ns** | **0.020 ns** |  **16.14 ns** |  **16.18 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 115.37 ns |  3.319 ns | 0.182 ns | 115.16 ns | 115.49 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 115.15 ns | 14.463 ns | 0.793 ns | 114.63 ns | 116.06 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.99 ns |  6.325 ns | 0.347 ns |  90.73 ns |  91.38 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.04 ns |  1.447 ns | 0.079 ns |  41.96 ns |  42.12 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.71 ns |  3.557 ns | 0.195 ns |  42.49 ns |  42.88 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 112.48 ns |  2.880 ns | 0.158 ns | 112.34 ns | 112.65 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.15 ns |  2.303 ns | 0.126 ns |  25.06 ns |  25.29 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 119.21 ns |  8.314 ns | 0.456 ns | 118.84 ns | 119.72 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 109.63 ns |  3.503 ns | 0.192 ns | 109.48 ns | 109.85 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  79.13 ns |  6.498 ns | 0.356 ns |  78.92 ns |  79.54 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  40.25 ns |  0.387 ns | 0.021 ns |  40.22 ns |  40.26 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.99 ns |  4.917 ns | 0.270 ns |  38.83 ns |  39.30 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 113.46 ns | 10.731 ns | 0.588 ns | 113.03 ns | 114.13 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **50.73 ns** | **12.277 ns** | **0.673 ns** |  **50.29 ns** |  **51.50 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 361.28 ns | 41.211 ns | 2.259 ns | 359.84 ns | 363.88 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 339.27 ns | 56.588 ns | 3.102 ns | 336.77 ns | 342.74 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 277.09 ns | 17.566 ns | 0.963 ns | 275.98 ns | 277.73 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 126.91 ns |  4.761 ns | 0.261 ns | 126.63 ns | 127.15 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 133.96 ns | 28.605 ns | 1.568 ns | 132.15 ns | 134.93 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 353.68 ns | 54.149 ns | 2.968 ns | 351.82 ns | 357.10 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  73.89 ns |  9.083 ns | 0.498 ns |  73.32 ns |  74.25 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 352.53 ns |  9.128 ns | 0.500 ns | 351.96 ns | 352.91 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 327.00 ns | 54.331 ns | 2.978 ns | 324.57 ns | 330.32 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.00 ns |  9.212 ns | 0.505 ns | 249.49 ns | 250.50 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 122.69 ns | 16.592 ns | 0.909 ns | 122.14 ns | 123.74 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 114.88 ns | 16.999 ns | 0.932 ns | 113.99 ns | 115.85 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 333.35 ns | 59.301 ns | 3.250 ns | 330.30 ns | 336.77 ns | 0.0300 |     504 B |
