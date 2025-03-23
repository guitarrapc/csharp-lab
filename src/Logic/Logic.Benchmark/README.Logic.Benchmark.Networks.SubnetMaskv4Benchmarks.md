```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.202
  [Host]            : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.14 (8.0.1425.11118), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.3 (9.0.325.11113), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.70 ns** |  **2.647 ns** | **0.145 ns** |  **16.58 ns** |  **16.86 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 124.08 ns |  5.429 ns | 0.298 ns | 123.81 ns | 124.40 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.63 ns |  2.133 ns | 0.117 ns | 116.50 ns | 116.73 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  89.81 ns |  6.962 ns | 0.382 ns |  89.57 ns |  90.25 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  43.62 ns |  4.072 ns | 0.223 ns |  43.42 ns |  43.86 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.85 ns | 13.727 ns | 0.752 ns |  43.35 ns |  44.71 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 117.71 ns | 47.944 ns | 2.628 ns | 115.50 ns | 120.62 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.78 ns |  1.859 ns | 0.102 ns |  25.66 ns |  25.85 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 118.42 ns | 20.500 ns | 1.124 ns | 117.12 ns | 119.09 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 110.30 ns |  1.636 ns | 0.090 ns | 110.21 ns | 110.39 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.09 ns |  8.039 ns | 0.441 ns |  80.76 ns |  81.59 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.50 ns |  3.149 ns | 0.173 ns |  41.34 ns |  41.68 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  38.57 ns |  3.812 ns | 0.209 ns |  38.36 ns |  38.77 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 118.04 ns | 14.214 ns | 0.779 ns | 117.15 ns | 118.59 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.72 ns** |  **1.504 ns** | **0.082 ns** |  **51.63 ns** |  **51.80 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 374.65 ns | 14.402 ns | 0.789 ns | 373.81 ns | 375.38 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 353.08 ns | 22.231 ns | 1.219 ns | 352.34 ns | 354.49 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 281.23 ns |  6.908 ns | 0.379 ns | 280.91 ns | 281.65 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 129.45 ns | 17.854 ns | 0.979 ns | 128.72 ns | 130.56 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 136.92 ns | 12.625 ns | 0.692 ns | 136.13 ns | 137.36 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 364.65 ns | 36.783 ns | 2.016 ns | 362.32 ns | 365.93 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.78 ns |  5.867 ns | 0.322 ns |  74.46 ns |  75.11 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 362.84 ns | 12.710 ns | 0.697 ns | 362.41 ns | 363.65 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 340.27 ns | 34.191 ns | 1.874 ns | 338.11 ns | 341.42 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 250.40 ns | 38.554 ns | 2.113 ns | 249.16 ns | 252.84 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 126.24 ns | 29.547 ns | 1.620 ns | 124.59 ns | 127.82 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 115.74 ns |  3.613 ns | 0.198 ns | 115.56 ns | 115.95 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 350.57 ns | 46.645 ns | 2.557 ns | 348.18 ns | 353.27 ns | 0.0300 |     504 B |
