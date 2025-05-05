```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **17.06 ns** |  **17.487 ns** |  **0.959 ns** |  **16.47 ns** |  **18.17 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.70 ns |  27.698 ns |  1.518 ns | 119.68 ns | 122.44 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 115.56 ns |  67.379 ns |  3.693 ns | 113.38 ns | 119.82 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.36 ns |   5.575 ns |  0.306 ns |  91.05 ns |  91.66 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  43.61 ns |   7.756 ns |  0.425 ns |  43.17 ns |  44.01 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  44.96 ns |   5.727 ns |  0.314 ns |  44.72 ns |  45.31 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.08 ns |  33.082 ns |  1.813 ns | 114.78 ns | 118.15 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.61 ns |   3.434 ns |  0.188 ns |  25.40 ns |  25.75 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.85 ns |  16.668 ns |  0.914 ns | 116.03 ns | 117.83 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 114.01 ns |  53.373 ns |  2.926 ns | 111.73 ns | 117.31 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  82.43 ns |   3.723 ns |  0.204 ns |  82.22 ns |  82.63 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.42 ns |   1.533 ns |  0.084 ns |  41.33 ns |  41.47 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.36 ns |   1.175 ns |  0.064 ns |  39.29 ns |  39.41 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 119.69 ns |  20.000 ns |  1.096 ns | 118.64 ns | 120.83 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **53.86 ns** |   **7.916 ns** |  **0.434 ns** |  **53.40 ns** |  **54.26 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 374.46 ns |  10.696 ns |  0.586 ns | 373.94 ns | 375.09 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 349.09 ns |  26.164 ns |  1.434 ns | 348.26 ns | 350.74 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 277.34 ns |   5.523 ns |  0.303 ns | 277.12 ns | 277.69 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 138.44 ns |  26.496 ns |  1.452 ns | 136.77 ns | 139.35 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 140.31 ns |  22.194 ns |  1.217 ns | 139.21 ns | 141.62 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 389.02 ns | 310.718 ns | 17.032 ns | 378.79 ns | 408.68 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  80.94 ns |  16.015 ns |  0.878 ns |  80.36 ns |  81.95 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 367.50 ns |  51.832 ns |  2.841 ns | 365.83 ns | 370.78 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 341.59 ns |  19.031 ns |  1.043 ns | 340.95 ns | 342.79 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 254.64 ns |   5.435 ns |  0.298 ns | 254.40 ns | 254.98 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 134.03 ns |   6.314 ns |  0.346 ns | 133.74 ns | 134.42 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 121.25 ns |   1.151 ns |  0.063 ns | 121.18 ns | 121.31 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 348.04 ns | 146.434 ns |  8.027 ns | 338.78 ns | 353.04 ns | 0.0300 |     504 B |
