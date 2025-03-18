```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.201
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.66 ns** |   **7.945 ns** | **0.435 ns** |  **16.33 ns** |  **17.16 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.88 ns |  13.147 ns | 0.721 ns | 120.24 ns | 121.66 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 118.35 ns |   9.239 ns | 0.506 ns | 117.79 ns | 118.77 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  97.56 ns |  10.720 ns | 0.588 ns |  97.20 ns |  98.24 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.93 ns |   0.629 ns | 0.034 ns |  42.91 ns |  42.97 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.40 ns |   1.394 ns | 0.076 ns |  43.32 ns |  43.47 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 117.22 ns |  38.745 ns | 2.124 ns | 114.88 ns | 119.03 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.38 ns |   2.822 ns | 0.155 ns |  25.20 ns |  25.49 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.65 ns |   9.401 ns | 0.515 ns | 115.27 ns | 116.24 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 112.21 ns |   4.091 ns | 0.224 ns | 112.07 ns | 112.47 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.70 ns |   0.964 ns | 0.053 ns |  80.65 ns |  80.75 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.02 ns |   5.966 ns | 0.327 ns |  41.71 ns |  42.36 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.11 ns |   2.047 ns | 0.112 ns |  39.00 ns |  39.22 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 115.80 ns |   6.467 ns | 0.354 ns | 115.51 ns | 116.20 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **53.08 ns** |  **17.117 ns** | **0.938 ns** |  **52.25 ns** |  **54.10 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 376.92 ns |  28.881 ns | 1.583 ns | 375.23 ns | 378.36 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 355.55 ns |  20.988 ns | 1.150 ns | 354.23 ns | 356.30 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 284.09 ns |  17.848 ns | 0.978 ns | 283.08 ns | 285.04 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 130.18 ns |   7.823 ns | 0.429 ns | 129.91 ns | 130.68 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 137.21 ns |  31.819 ns | 1.744 ns | 135.20 ns | 138.29 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 369.12 ns |  31.731 ns | 1.739 ns | 367.99 ns | 371.13 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.48 ns |  15.354 ns | 0.842 ns |  74.88 ns |  76.44 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 359.28 ns |  53.626 ns | 2.939 ns | 356.67 ns | 362.46 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 334.96 ns |  23.283 ns | 1.276 ns | 334.01 ns | 336.41 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 255.94 ns |  32.426 ns | 1.777 ns | 254.30 ns | 257.83 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 126.52 ns |  16.891 ns | 0.926 ns | 125.57 ns | 127.42 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 119.87 ns |  11.757 ns | 0.644 ns | 119.48 ns | 120.61 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 354.85 ns | 103.161 ns | 5.655 ns | 348.35 ns | 358.60 ns | 0.0300 |     504 B |
