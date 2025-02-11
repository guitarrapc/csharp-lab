```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]            : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.12 (8.0.1224.60305), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **17.43 ns** |   **1.888 ns** |  **0.104 ns** |  **17.36 ns** |  **17.55 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 128.48 ns |  69.577 ns |  3.814 ns | 125.18 ns | 132.66 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 119.48 ns |   8.656 ns |  0.474 ns | 119.16 ns | 120.03 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  92.29 ns |  49.569 ns |  2.717 ns |  90.67 ns |  95.43 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  44.71 ns |   5.074 ns |  0.278 ns |  44.40 ns |  44.91 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  44.74 ns |   4.007 ns |  0.220 ns |  44.49 ns |  44.92 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 121.80 ns |  42.184 ns |  2.312 ns | 119.55 ns | 124.17 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  27.26 ns |   0.302 ns |  0.017 ns |  27.25 ns |  27.28 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 119.62 ns |   7.288 ns |  0.399 ns | 119.32 ns | 120.07 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 114.17 ns |   3.143 ns |  0.172 ns | 113.98 ns | 114.32 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  82.39 ns |   5.900 ns |  0.323 ns |  82.18 ns |  82.76 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  44.18 ns |   2.123 ns |  0.116 ns |  44.07 ns |  44.30 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  41.30 ns |   0.246 ns |  0.013 ns |  41.28 ns |  41.31 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 120.41 ns |  35.781 ns |  1.961 ns | 118.78 ns | 122.59 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **57.02 ns** |  **16.943 ns** |  **0.929 ns** |  **55.98 ns** |  **57.75 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 379.64 ns |  44.587 ns |  2.444 ns | 377.57 ns | 382.33 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 349.71 ns |  17.132 ns |  0.939 ns | 348.71 ns | 350.57 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 275.92 ns |   1.048 ns |  0.057 ns | 275.86 ns | 275.98 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 138.14 ns |  15.193 ns |  0.833 ns | 137.54 ns | 139.09 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 137.47 ns |   7.846 ns |  0.430 ns | 137.20 ns | 137.96 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 371.10 ns |  58.217 ns |  3.191 ns | 368.49 ns | 374.66 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  79.38 ns |  11.653 ns |  0.639 ns |  78.82 ns |  80.08 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 380.92 ns |  30.880 ns |  1.693 ns | 379.60 ns | 382.83 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 337.74 ns |  54.510 ns |  2.988 ns | 335.26 ns | 341.06 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.15 ns |   5.559 ns |  0.305 ns | 249.96 ns | 250.50 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.13 ns |  18.657 ns |  1.023 ns | 122.49 ns | 124.31 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.36 ns |   8.699 ns |  0.477 ns | 114.85 ns | 115.79 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 355.24 ns | 188.442 ns | 10.329 ns | 348.55 ns | 367.14 ns | 0.0300 |     504 B |
