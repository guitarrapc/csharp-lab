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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.32 ns** |   **4.498 ns** |  **0.247 ns** |  **16.04 ns** |  **16.49 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 123.47 ns |  10.917 ns |  0.598 ns | 122.83 ns | 124.01 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 117.33 ns |   9.025 ns |  0.495 ns | 116.77 ns | 117.73 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  91.10 ns |   1.946 ns |  0.107 ns |  91.03 ns |  91.22 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.79 ns |   2.228 ns |  0.122 ns |  42.72 ns |  42.93 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  44.21 ns |  13.336 ns |  0.731 ns |  43.59 ns |  45.01 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 116.12 ns |  39.988 ns |  2.192 ns | 114.81 ns | 118.65 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  26.13 ns |   2.250 ns |  0.123 ns |  26.02 ns |  26.26 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.65 ns |  13.911 ns |  0.763 ns | 116.11 ns | 117.53 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 112.01 ns |   3.136 ns |  0.172 ns | 111.81 ns | 112.12 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  84.64 ns |   6.580 ns |  0.361 ns |  84.42 ns |  85.06 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.19 ns |   6.972 ns |  0.382 ns |  41.86 ns |  42.61 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.20 ns |   7.517 ns |  0.412 ns |  38.89 ns |  39.67 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 112.67 ns |  75.028 ns |  4.113 ns | 108.96 ns | 117.09 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.69 ns** |   **9.137 ns** |  **0.501 ns** |  **51.16 ns** |  **52.16 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 368.77 ns |  21.075 ns |  1.155 ns | 367.44 ns | 369.47 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 348.13 ns | 199.092 ns | 10.913 ns | 339.82 ns | 360.49 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 279.71 ns |  13.800 ns |  0.756 ns | 278.84 ns | 280.23 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 129.64 ns |  17.980 ns |  0.986 ns | 128.73 ns | 130.68 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 137.55 ns |  84.944 ns |  4.656 ns | 133.98 ns | 142.82 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 368.58 ns |  23.769 ns |  1.303 ns | 367.72 ns | 370.08 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.60 ns |   1.496 ns |  0.082 ns |  75.51 ns |  75.67 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 365.57 ns |  19.538 ns |  1.071 ns | 364.93 ns | 366.81 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 335.38 ns |   6.275 ns |  0.344 ns | 335.10 ns | 335.76 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 252.94 ns |   5.816 ns |  0.319 ns | 252.64 ns | 253.28 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 125.88 ns |   6.455 ns |  0.354 ns | 125.50 ns | 126.20 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 119.29 ns |  48.813 ns |  2.676 ns | 117.59 ns | 122.38 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 342.16 ns | 148.024 ns |  8.114 ns | 337.12 ns | 351.52 ns | 0.0300 |     504 B |
