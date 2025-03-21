```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.84 ns** |   **2.401 ns** | **0.132 ns** |  **16.75 ns** |  **16.99 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 120.52 ns |   5.200 ns | 0.285 ns | 120.24 ns | 120.81 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 119.71 ns |  84.125 ns | 4.611 ns | 116.92 ns | 125.04 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  90.43 ns |   5.324 ns | 0.292 ns |  90.16 ns |  90.74 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  43.51 ns |   2.853 ns | 0.156 ns |  43.40 ns |  43.69 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.21 ns |   3.194 ns | 0.175 ns |  43.09 ns |  43.41 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 120.24 ns |  36.526 ns | 2.002 ns | 117.93 ns | 121.54 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  26.01 ns |   4.712 ns | 0.258 ns |  25.82 ns |  26.31 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 121.08 ns |  12.370 ns | 0.678 ns | 120.35 ns | 121.69 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 112.51 ns |   7.650 ns | 0.419 ns | 112.18 ns | 112.98 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  83.42 ns |   4.728 ns | 0.259 ns |  83.25 ns |  83.71 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.45 ns |   9.791 ns | 0.537 ns |  41.95 ns |  43.02 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.90 ns |   7.999 ns | 0.438 ns |  39.51 ns |  40.37 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 121.30 ns |  25.418 ns | 1.393 ns | 119.71 ns | 122.33 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **53.03 ns** |  **11.073 ns** | **0.607 ns** |  **52.58 ns** |  **53.72 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 369.37 ns |  31.161 ns | 1.708 ns | 367.52 ns | 370.89 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 363.45 ns | 103.665 ns | 5.682 ns | 357.11 ns | 368.06 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 275.39 ns |  12.682 ns | 0.695 ns | 274.67 ns | 276.05 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 132.84 ns |   8.046 ns | 0.441 ns | 132.38 ns | 133.26 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 140.24 ns |  17.494 ns | 0.959 ns | 139.32 ns | 141.23 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 367.40 ns |  64.506 ns | 3.536 ns | 364.94 ns | 371.46 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  77.20 ns |  11.132 ns | 0.610 ns |  76.55 ns |  77.77 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 366.60 ns |  32.535 ns | 1.783 ns | 365.38 ns | 368.65 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 338.82 ns |  10.201 ns | 0.559 ns | 338.30 ns | 339.41 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 257.71 ns |  13.079 ns | 0.717 ns | 256.88 ns | 258.21 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 127.10 ns |  18.218 ns | 0.999 ns | 126.04 ns | 128.02 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 119.13 ns |   2.339 ns | 0.128 ns | 119.02 ns | 119.27 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 340.91 ns |  82.324 ns | 4.512 ns | 336.27 ns | 345.28 ns | 0.0300 |     504 B |
