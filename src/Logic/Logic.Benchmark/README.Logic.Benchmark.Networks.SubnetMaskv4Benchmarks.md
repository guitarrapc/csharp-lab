```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **17.15 ns** |   **0.470 ns** | **0.026 ns** |  **17.12 ns** |  **17.17 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.60 ns |   5.972 ns | 0.327 ns | 120.29 ns | 120.94 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 120.17 ns |  19.817 ns | 1.086 ns | 119.43 ns | 121.41 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  92.40 ns |   5.260 ns | 0.288 ns |  92.22 ns |  92.73 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  44.75 ns |  12.315 ns | 0.675 ns |  44.22 ns |  45.51 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.88 ns |   6.787 ns | 0.372 ns |  43.47 ns |  44.19 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 122.62 ns |  14.387 ns | 0.789 ns | 122.01 ns | 123.51 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  26.57 ns |   1.172 ns | 0.064 ns |  26.49 ns |  26.61 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 122.66 ns |   8.998 ns | 0.493 ns | 122.09 ns | 122.97 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 112.64 ns |  17.535 ns | 0.961 ns | 111.66 ns | 113.58 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.77 ns |   5.933 ns | 0.325 ns |  81.51 ns |  82.14 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.89 ns |   1.038 ns | 0.057 ns |  42.83 ns |  42.95 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.85 ns |   6.219 ns | 0.341 ns |  39.49 ns |  40.16 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 118.82 ns |   4.387 ns | 0.240 ns | 118.62 ns | 119.09 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **53.70 ns** |   **4.551 ns** | **0.249 ns** |  **53.43 ns** |  **53.92 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 378.68 ns |  10.061 ns | 0.551 ns | 378.07 ns | 379.15 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 351.82 ns |  31.744 ns | 1.740 ns | 350.81 ns | 353.83 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 287.84 ns |  24.389 ns | 1.337 ns | 286.40 ns | 289.04 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 136.88 ns |  38.378 ns | 2.104 ns | 134.46 ns | 138.29 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 139.04 ns |  26.335 ns | 1.443 ns | 137.95 ns | 140.68 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 379.44 ns |  37.916 ns | 2.078 ns | 378.00 ns | 381.82 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  79.69 ns |  14.098 ns | 0.773 ns |  78.93 ns |  80.48 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 365.27 ns |  10.977 ns | 0.602 ns | 364.73 ns | 365.92 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 342.68 ns |  26.343 ns | 1.444 ns | 341.06 ns | 343.82 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 258.57 ns |  21.046 ns | 1.154 ns | 257.40 ns | 259.71 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 132.15 ns |  16.374 ns | 0.898 ns | 131.13 ns | 132.78 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 120.76 ns |  31.372 ns | 1.720 ns | 119.24 ns | 122.63 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 365.00 ns | 133.992 ns | 7.345 ns | 359.02 ns | 373.19 ns | 0.0300 |     504 B |
