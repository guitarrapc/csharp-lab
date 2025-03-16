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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.30 ns** |   **1.887 ns** | **0.103 ns** |  **16.18 ns** |  **16.37 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.58 ns |   8.965 ns | 0.491 ns | 120.09 ns | 121.08 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.20 ns |   6.548 ns | 0.359 ns | 115.79 ns | 116.47 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.02 ns |   2.454 ns | 0.134 ns |  90.87 ns |  91.13 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.87 ns |   5.040 ns | 0.276 ns |  42.55 ns |  43.04 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.09 ns |   4.088 ns | 0.224 ns |  42.89 ns |  43.33 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.30 ns |  45.982 ns | 2.520 ns | 113.65 ns | 118.67 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.31 ns |   0.983 ns | 0.054 ns |  25.26 ns |  25.37 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 115.43 ns |   3.365 ns | 0.184 ns | 115.22 ns | 115.57 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 109.67 ns |   0.522 ns | 0.029 ns | 109.64 ns | 109.70 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.17 ns |  12.776 ns | 0.700 ns |  80.55 ns |  81.93 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.03 ns |   1.661 ns | 0.091 ns |  40.93 ns |  41.12 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.93 ns |   8.000 ns | 0.439 ns |  38.55 ns |  39.41 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 114.11 ns | 105.154 ns | 5.764 ns | 108.01 ns | 119.47 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.17 ns** |   **8.188 ns** | **0.449 ns** |  **50.75 ns** |  **51.64 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 363.79 ns |  15.192 ns | 0.833 ns | 363.28 ns | 364.75 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.25 ns |   4.815 ns | 0.264 ns | 350.06 ns | 350.55 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 287.05 ns |   7.806 ns | 0.428 ns | 286.60 ns | 287.45 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.61 ns |  11.993 ns | 0.657 ns | 128.10 ns | 129.35 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 135.81 ns |  15.821 ns | 0.867 ns | 135.20 ns | 136.80 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 357.08 ns |  58.789 ns | 3.222 ns | 353.65 ns | 360.05 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  73.97 ns |   3.399 ns | 0.186 ns |  73.82 ns |  74.18 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 354.30 ns |  15.899 ns | 0.871 ns | 353.38 ns | 355.12 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 333.58 ns |  92.434 ns | 5.067 ns | 329.44 ns | 339.23 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 248.52 ns |   0.278 ns | 0.015 ns | 248.51 ns | 248.54 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.75 ns |  11.980 ns | 0.657 ns | 122.99 ns | 124.14 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.77 ns |   4.426 ns | 0.243 ns | 115.50 ns | 115.98 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 339.86 ns | 161.416 ns | 8.848 ns | 329.68 ns | 345.70 ns | 0.0300 |     504 B |
