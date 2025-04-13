```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.14 ns** |  **2.547 ns** | **0.140 ns** |  **16.04 ns** |  **16.30 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 119.11 ns |  9.241 ns | 0.507 ns | 118.54 ns | 119.51 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 111.08 ns |  7.076 ns | 0.388 ns | 110.65 ns | 111.39 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  87.05 ns | 10.404 ns | 0.570 ns |  86.49 ns |  87.63 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.01 ns |  5.440 ns | 0.298 ns |  41.66 ns |  42.21 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.68 ns |  3.928 ns | 0.215 ns |  42.44 ns |  42.86 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 113.66 ns | 41.565 ns | 2.278 ns | 111.61 ns | 116.11 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  26.77 ns |  3.003 ns | 0.165 ns |  26.60 ns |  26.93 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 118.86 ns | 18.767 ns | 1.029 ns | 118.23 ns | 120.04 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 108.49 ns | 14.873 ns | 0.815 ns | 107.67 ns | 109.30 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.25 ns |  2.785 ns | 0.153 ns |  81.08 ns |  81.38 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.59 ns |  2.828 ns | 0.155 ns |  41.42 ns |  41.71 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.39 ns |  5.862 ns | 0.321 ns |  38.14 ns |  38.76 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 112.71 ns | 38.757 ns | 2.124 ns | 110.42 ns | 114.62 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **50.28 ns** |  **9.611 ns** | **0.527 ns** |  **49.67 ns** |  **50.62 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 362.25 ns | 78.053 ns | 4.278 ns | 357.60 ns | 366.01 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 332.02 ns | 27.126 ns | 1.487 ns | 330.45 ns | 333.41 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 267.82 ns | 24.654 ns | 1.351 ns | 266.95 ns | 269.37 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 125.28 ns | 25.624 ns | 1.405 ns | 123.67 ns | 126.24 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 131.88 ns | 18.502 ns | 1.014 ns | 130.79 ns | 132.80 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 362.17 ns | 87.785 ns | 4.812 ns | 356.66 ns | 365.59 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  72.51 ns | 14.502 ns | 0.795 ns |  71.60 ns |  73.01 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 356.24 ns | 44.402 ns | 2.434 ns | 353.43 ns | 357.70 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 322.88 ns | 29.168 ns | 1.599 ns | 321.69 ns | 324.70 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 247.11 ns | 54.628 ns | 2.994 ns | 244.43 ns | 250.34 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 120.87 ns | 14.313 ns | 0.785 ns | 120.08 ns | 121.65 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 114.01 ns | 17.529 ns | 0.961 ns | 112.90 ns | 114.65 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 330.04 ns | 31.165 ns | 1.708 ns | 328.22 ns | 331.61 ns | 0.0300 |     504 B |
