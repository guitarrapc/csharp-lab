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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.14 ns** |  **1.562 ns** | **0.086 ns** |  **16.09 ns** |  **16.24 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 118.88 ns | 11.153 ns | 0.611 ns | 118.45 ns | 119.58 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.82 ns |  5.395 ns | 0.296 ns | 116.56 ns | 117.14 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  89.45 ns |  2.724 ns | 0.149 ns |  89.29 ns |  89.58 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  42.72 ns |  3.895 ns | 0.213 ns |  42.48 ns |  42.89 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.30 ns |  3.093 ns | 0.170 ns |  43.13 ns |  43.47 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 119.21 ns | 19.836 ns | 1.087 ns | 118.57 ns | 120.47 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.75 ns |  4.944 ns | 0.271 ns |  25.44 ns |  25.92 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 119.30 ns |  6.612 ns | 0.362 ns | 118.94 ns | 119.66 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.45 ns |  3.543 ns | 0.194 ns | 111.33 ns | 111.67 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.61 ns |  9.093 ns | 0.498 ns |  81.16 ns |  82.14 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  41.99 ns |  3.227 ns | 0.177 ns |  41.79 ns |  42.11 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  39.95 ns |  2.114 ns | 0.116 ns |  39.84 ns |  40.07 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 118.48 ns | 57.614 ns | 3.158 ns | 115.48 ns | 121.78 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **52.61 ns** | **11.050 ns** | **0.606 ns** |  **52.00 ns** |  **53.22 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 376.26 ns | 23.246 ns | 1.274 ns | 374.98 ns | 377.53 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 352.37 ns | 14.914 ns | 0.817 ns | 351.43 ns | 352.94 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 281.61 ns |  6.960 ns | 0.382 ns | 281.22 ns | 281.98 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 131.35 ns | 19.557 ns | 1.072 ns | 130.30 ns | 132.44 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 136.52 ns | 26.707 ns | 1.464 ns | 135.07 ns | 138.00 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 364.13 ns | 27.757 ns | 1.521 ns | 362.38 ns | 365.07 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  75.89 ns | 12.481 ns | 0.684 ns |  75.19 ns |  76.56 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 363.29 ns | 13.795 ns | 0.756 ns | 362.59 ns | 364.09 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 336.00 ns | 18.160 ns | 0.995 ns | 334.92 ns | 336.88 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 270.99 ns | 21.664 ns | 1.187 ns | 270.05 ns | 272.32 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 124.97 ns |  7.797 ns | 0.427 ns | 124.62 ns | 125.45 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 116.16 ns | 14.715 ns | 0.807 ns | 115.37 ns | 116.98 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 355.83 ns | 64.016 ns | 3.509 ns | 352.50 ns | 359.50 ns | 0.0300 |     504 B |
