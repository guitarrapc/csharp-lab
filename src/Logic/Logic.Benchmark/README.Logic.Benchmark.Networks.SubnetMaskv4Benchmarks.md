```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.09 ns** |   **0.544 ns** | **0.030 ns** |  **16.06 ns** |  **16.12 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 119.37 ns |   3.966 ns | 0.217 ns | 119.21 ns | 119.62 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 117.53 ns |  11.727 ns | 0.643 ns | 116.87 ns | 118.15 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.92 ns |   9.383 ns | 0.514 ns |  90.42 ns |  91.44 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.69 ns |   1.366 ns | 0.075 ns |  42.60 ns |  42.75 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  41.77 ns |   1.557 ns | 0.085 ns |  41.68 ns |  41.84 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 113.64 ns |  23.675 ns | 1.298 ns | 112.31 ns | 114.90 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.29 ns |   0.799 ns | 0.044 ns |  25.24 ns |  25.32 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.57 ns |  17.086 ns | 0.937 ns | 114.77 ns | 116.60 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 110.11 ns |   3.785 ns | 0.207 ns | 109.90 ns | 110.32 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.72 ns |   8.289 ns | 0.454 ns |  81.30 ns |  82.21 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.74 ns |  28.369 ns | 1.555 ns |  41.06 ns |  44.12 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.89 ns |  14.249 ns | 0.781 ns |  38.34 ns |  39.78 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 113.74 ns |   9.410 ns | 0.516 ns | 113.26 ns | 114.29 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.07 ns** |   **2.407 ns** | **0.132 ns** |  **50.95 ns** |  **51.21 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 358.49 ns |  10.839 ns | 0.594 ns | 358.13 ns | 359.17 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 346.23 ns |   9.717 ns | 0.533 ns | 345.69 ns | 346.75 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 275.55 ns |  41.719 ns | 2.287 ns | 273.15 ns | 277.70 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 131.15 ns |   8.305 ns | 0.455 ns | 130.75 ns | 131.64 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 131.49 ns |  18.193 ns | 0.997 ns | 130.81 ns | 132.64 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 366.48 ns | 127.401 ns | 6.983 ns | 362.02 ns | 374.53 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.02 ns |  28.007 ns | 1.535 ns |  74.08 ns |  76.79 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 353.00 ns |  29.287 ns | 1.605 ns | 351.42 ns | 354.63 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 341.54 ns |  12.195 ns | 0.668 ns | 340.89 ns | 342.23 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 255.58 ns |  46.512 ns | 2.549 ns | 252.71 ns | 257.59 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.40 ns |  12.478 ns | 0.684 ns | 122.87 ns | 124.17 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 114.91 ns |   6.623 ns | 0.363 ns | 114.53 ns | 115.25 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 334.15 ns |  41.534 ns | 2.277 ns | 331.71 ns | 336.21 ns | 0.0300 |     504 B |
