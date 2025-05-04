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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.25 ns** |   **1.796 ns** | **0.098 ns** |  **16.17 ns** |  **16.36 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 124.19 ns |  13.734 ns | 0.753 ns | 123.33 ns | 124.72 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.18 ns |  15.784 ns | 0.865 ns | 115.44 ns | 117.14 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.73 ns |   8.402 ns | 0.461 ns |  88.31 ns |  89.22 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.46 ns |   4.106 ns | 0.225 ns |  42.20 ns |  42.59 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.01 ns |   3.753 ns | 0.206 ns |  41.87 ns |  42.25 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 117.34 ns |  60.658 ns | 3.325 ns | 113.57 ns | 119.84 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  26.07 ns |   4.320 ns | 0.237 ns |  25.87 ns |  26.33 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 118.13 ns |  26.023 ns | 1.426 ns | 116.78 ns | 119.62 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 112.01 ns |  59.399 ns | 3.256 ns | 110.08 ns | 115.77 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  79.77 ns |   6.957 ns | 0.381 ns |  79.53 ns |  80.21 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.73 ns |   7.229 ns | 0.396 ns |  42.32 ns |  43.11 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.14 ns |  12.907 ns | 0.707 ns |  38.58 ns |  39.93 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 114.21 ns |  11.886 ns | 0.652 ns | 113.75 ns | 114.96 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **53.27 ns** |  **29.967 ns** | **1.643 ns** |  **51.65 ns** |  **54.93 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 374.37 ns |   9.292 ns | 0.509 ns | 373.98 ns | 374.94 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 354.06 ns |  46.963 ns | 2.574 ns | 352.13 ns | 356.98 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 277.43 ns |  25.355 ns | 1.390 ns | 276.49 ns | 279.03 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 129.33 ns |  15.617 ns | 0.856 ns | 128.73 ns | 130.31 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 134.15 ns |  13.666 ns | 0.749 ns | 133.38 ns | 134.87 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 361.62 ns |  71.156 ns | 3.900 ns | 357.74 ns | 365.55 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.51 ns |  14.137 ns | 0.775 ns |  74.62 ns |  76.01 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 367.19 ns |  32.730 ns | 1.794 ns | 365.74 ns | 369.20 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 331.95 ns |  46.752 ns | 2.563 ns | 330.29 ns | 334.90 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 247.88 ns |  26.486 ns | 1.452 ns | 246.36 ns | 249.25 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 124.26 ns |  17.448 ns | 0.956 ns | 123.51 ns | 125.34 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 116.30 ns |  10.921 ns | 0.599 ns | 115.82 ns | 116.97 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 336.34 ns | 156.928 ns | 8.602 ns | 329.92 ns | 346.12 ns | 0.0300 |     504 B |
