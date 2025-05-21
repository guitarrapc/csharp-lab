```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **18.35 ns** |   **5.816 ns** |  **0.319 ns** |  **18.09 ns** |  **18.71 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 123.34 ns |  41.221 ns |  2.259 ns | 120.80 ns | 125.11 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 120.61 ns |   1.074 ns |  0.059 ns | 120.54 ns | 120.66 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  98.26 ns |   3.386 ns |  0.186 ns |  98.05 ns |  98.40 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  45.81 ns |   6.925 ns |  0.380 ns |  45.48 ns |  46.23 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.96 ns |  19.347 ns |  1.060 ns |  42.74 ns |  44.64 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 120.02 ns |   9.805 ns |  0.537 ns | 119.40 ns | 120.33 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  18.90 ns |   3.260 ns |  0.179 ns |  18.75 ns |  19.10 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 112.56 ns |  14.252 ns |  0.781 ns | 112.04 ns | 113.46 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 105.65 ns |  10.170 ns |  0.557 ns | 105.26 ns | 106.29 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  88.41 ns |   6.228 ns |  0.341 ns |  88.14 ns |  88.79 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  40.84 ns |   4.467 ns |  0.245 ns |  40.68 ns |  41.12 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.50 ns |   3.177 ns |  0.174 ns |  38.39 ns |  38.70 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 114.63 ns |  15.381 ns |  0.843 ns | 113.90 ns | 115.55 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **50.95 ns** |   **0.886 ns** |  **0.049 ns** |  **50.89 ns** |  **50.99 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 370.34 ns |   7.872 ns |  0.431 ns | 369.84 ns | 370.60 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 337.40 ns |   9.922 ns |  0.544 ns | 337.02 ns | 338.02 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 275.91 ns |   6.455 ns |  0.354 ns | 275.60 ns | 276.29 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 128.04 ns |  22.878 ns |  1.254 ns | 127.03 ns | 129.44 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 132.88 ns |  36.693 ns |  2.011 ns | 131.36 ns | 135.16 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 353.12 ns |  78.942 ns |  4.327 ns | 348.62 ns | 357.24 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  56.90 ns |   2.807 ns |  0.154 ns |  56.79 ns |  57.07 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 350.51 ns |  17.109 ns |  0.938 ns | 349.63 ns | 351.50 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 319.68 ns |  29.323 ns |  1.607 ns | 318.05 ns | 321.26 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 245.83 ns |  18.042 ns |  0.989 ns | 245.14 ns | 246.96 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 121.85 ns |   6.356 ns |  0.348 ns | 121.54 ns | 122.23 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 114.05 ns |   5.857 ns |  0.321 ns | 113.82 ns | 114.42 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 352.51 ns | 313.458 ns | 17.182 ns | 332.92 ns | 364.98 ns | 0.0300 |     504 B |
