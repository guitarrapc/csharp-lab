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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.66 ns** |  **6.760 ns** | **0.371 ns** |  **16.26 ns** |  **16.99 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 121.02 ns |  9.001 ns | 0.493 ns | 120.70 ns | 121.59 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 119.96 ns |  4.167 ns | 0.228 ns | 119.70 ns | 120.12 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.72 ns |  6.243 ns | 0.342 ns |  90.32 ns |  90.94 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.12 ns |  3.321 ns | 0.182 ns |  41.91 ns |  42.25 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.10 ns |  4.424 ns | 0.242 ns |  41.84 ns |  42.32 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 114.10 ns | 20.279 ns | 1.112 ns | 113.23 ns | 115.35 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.66 ns |  4.722 ns | 0.259 ns |  25.48 ns |  25.96 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.20 ns |  2.724 ns | 0.149 ns | 115.10 ns | 115.37 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 110.34 ns |  9.464 ns | 0.519 ns | 109.91 ns | 110.92 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.25 ns |  8.531 ns | 0.468 ns |  79.87 ns |  80.77 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  40.96 ns |  1.650 ns | 0.090 ns |  40.86 ns |  41.04 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.06 ns |  4.728 ns | 0.259 ns |  38.84 ns |  39.34 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 112.24 ns | 28.453 ns | 1.560 ns | 110.48 ns | 113.46 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **52.82 ns** | **10.761 ns** | **0.590 ns** |  **52.18 ns** |  **53.35 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 364.22 ns | 45.387 ns | 2.488 ns | 361.46 ns | 366.28 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 344.03 ns | 25.606 ns | 1.404 ns | 342.65 ns | 345.46 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 272.21 ns | 15.204 ns | 0.833 ns | 271.25 ns | 272.75 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.64 ns | 36.990 ns | 2.028 ns | 127.16 ns | 130.95 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 134.38 ns | 10.071 ns | 0.552 ns | 133.85 ns | 134.95 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 356.14 ns | 91.999 ns | 5.043 ns | 350.55 ns | 360.35 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.19 ns |  9.048 ns | 0.496 ns |  74.83 ns |  75.76 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 368.73 ns | 49.361 ns | 2.706 ns | 365.88 ns | 371.27 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 329.95 ns | 65.077 ns | 3.567 ns | 327.73 ns | 334.07 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.41 ns | 13.857 ns | 0.760 ns | 249.90 ns | 251.28 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 125.01 ns |  4.444 ns | 0.244 ns | 124.74 ns | 125.20 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.76 ns | 13.229 ns | 0.725 ns | 115.08 ns | 116.52 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 336.33 ns | 91.798 ns | 5.032 ns | 331.75 ns | 341.72 ns | 0.0300 |     504 B |
