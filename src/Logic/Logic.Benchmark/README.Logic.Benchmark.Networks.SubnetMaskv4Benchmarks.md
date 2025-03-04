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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **17.32 ns** |  **19.182 ns** | **1.051 ns** |  **16.47 ns** |  **18.50 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 127.35 ns |  32.861 ns | 1.801 ns | 126.10 ns | 129.42 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 121.34 ns |  15.180 ns | 0.832 ns | 120.65 ns | 122.26 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.65 ns |   3.945 ns | 0.216 ns |  90.46 ns |  90.88 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  46.63 ns |   0.682 ns | 0.037 ns |  46.61 ns |  46.67 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  45.68 ns |   1.450 ns | 0.079 ns |  45.59 ns |  45.75 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 122.18 ns |  33.185 ns | 1.819 ns | 120.62 ns | 124.18 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  27.37 ns |   2.830 ns | 0.155 ns |  27.21 ns |  27.51 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 123.26 ns |  32.970 ns | 1.807 ns | 122.10 ns | 125.34 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 115.42 ns |  14.669 ns | 0.804 ns | 114.84 ns | 116.34 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  86.35 ns |  14.219 ns | 0.779 ns |  85.70 ns |  87.21 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  44.72 ns |   3.983 ns | 0.218 ns |  44.49 ns |  44.93 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  41.17 ns |  11.343 ns | 0.622 ns |  40.68 ns |  41.87 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 120.78 ns |   9.545 ns | 0.523 ns | 120.33 ns | 121.36 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **58.07 ns** |  **15.209 ns** | **0.834 ns** |  **57.31 ns** |  **58.96 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 373.29 ns |   4.817 ns | 0.264 ns | 373.10 ns | 373.59 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 363.38 ns |   2.618 ns | 0.144 ns | 363.23 ns | 363.51 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 284.63 ns |  21.226 ns | 1.163 ns | 283.90 ns | 285.97 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 139.61 ns |   9.115 ns | 0.500 ns | 139.12 ns | 140.12 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 137.15 ns |  54.896 ns | 3.009 ns | 133.67 ns | 138.92 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 375.38 ns |  21.435 ns | 1.175 ns | 374.19 ns | 376.54 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  81.48 ns |  10.512 ns | 0.576 ns |  81.06 ns |  82.14 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 378.64 ns |  14.187 ns | 0.778 ns | 377.78 ns | 379.30 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 342.78 ns |  16.202 ns | 0.888 ns | 342.26 ns | 343.81 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 257.17 ns |  18.326 ns | 1.005 ns | 256.11 ns | 258.11 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 134.58 ns |  14.748 ns | 0.808 ns | 134.00 ns | 135.50 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 122.09 ns |  78.688 ns | 4.313 ns | 117.72 ns | 126.34 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 365.13 ns | 168.168 ns | 9.218 ns | 354.49 ns | 370.68 ns | 0.0300 |     504 B |
