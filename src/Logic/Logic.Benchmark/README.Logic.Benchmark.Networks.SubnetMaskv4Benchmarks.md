```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.09 ns** |  **0.789 ns** | **0.043 ns** |  **16.06 ns** |  **16.14 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.08 ns | 10.397 ns | 0.570 ns | 119.64 ns | 120.73 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 114.99 ns | 15.226 ns | 0.835 ns | 114.21 ns | 115.87 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.22 ns |  8.303 ns | 0.455 ns |  90.76 ns |  91.67 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.43 ns |  4.415 ns | 0.242 ns |  42.21 ns |  42.69 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.01 ns |  6.073 ns | 0.333 ns |  41.80 ns |  42.39 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.41 ns | 36.008 ns | 1.974 ns | 115.21 ns | 118.69 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.46 ns |  1.520 ns | 0.083 ns |  25.41 ns |  25.56 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 121.12 ns | 16.339 ns | 0.896 ns | 120.15 ns | 121.92 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.05 ns |  3.479 ns | 0.191 ns | 110.92 ns | 111.27 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.27 ns |  2.512 ns | 0.138 ns |  80.12 ns |  80.36 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.09 ns |  4.369 ns | 0.239 ns |  40.86 ns |  41.34 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.44 ns |  3.638 ns | 0.199 ns |  38.23 ns |  38.63 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 114.14 ns |  9.319 ns | 0.511 ns | 113.70 ns | 114.70 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.32 ns** |  **7.459 ns** | **0.409 ns** |  **50.89 ns** |  **51.70 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 369.63 ns | 18.895 ns | 1.036 ns | 368.44 ns | 370.32 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 351.46 ns | 24.913 ns | 1.366 ns | 350.40 ns | 353.00 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 311.89 ns | 17.819 ns | 0.977 ns | 311.03 ns | 312.95 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 130.20 ns |  3.699 ns | 0.203 ns | 130.00 ns | 130.40 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 136.30 ns |  2.688 ns | 0.147 ns | 136.14 ns | 136.43 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 357.04 ns | 80.178 ns | 4.395 ns | 352.50 ns | 361.28 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  73.89 ns |  6.066 ns | 0.332 ns |  73.60 ns |  74.25 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 359.29 ns | 10.314 ns | 0.565 ns | 358.71 ns | 359.84 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 332.35 ns | 86.212 ns | 4.726 ns | 329.59 ns | 337.81 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 253.45 ns | 23.456 ns | 1.286 ns | 252.69 ns | 254.94 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.15 ns | 10.400 ns | 0.570 ns | 122.68 ns | 123.79 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.97 ns | 12.414 ns | 0.680 ns | 115.29 ns | 116.65 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 349.90 ns | 28.772 ns | 1.577 ns | 348.53 ns | 351.63 ns | 0.0300 |     504 B |
