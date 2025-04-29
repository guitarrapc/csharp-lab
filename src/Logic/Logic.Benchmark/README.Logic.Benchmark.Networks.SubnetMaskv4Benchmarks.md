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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **17.10 ns** |  **0.913 ns** | **0.050 ns** |  **17.05 ns** |  **17.15 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 122.95 ns |  8.067 ns | 0.442 ns | 122.64 ns | 123.46 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 119.38 ns |  3.882 ns | 0.213 ns | 119.17 ns | 119.60 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  92.23 ns |  4.199 ns | 0.230 ns |  92.01 ns |  92.47 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  44.59 ns |  4.773 ns | 0.262 ns |  44.28 ns |  44.76 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  45.42 ns |  3.201 ns | 0.175 ns |  45.23 ns |  45.57 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 117.67 ns | 22.439 ns | 1.230 ns | 116.91 ns | 119.09 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.92 ns |  3.083 ns | 0.169 ns |  25.73 ns |  26.06 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 117.42 ns |  5.987 ns | 0.328 ns | 117.10 ns | 117.76 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 113.82 ns |  1.834 ns | 0.101 ns | 113.70 ns | 113.89 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  83.23 ns |  5.783 ns | 0.317 ns |  82.86 ns |  83.42 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  43.15 ns |  5.044 ns | 0.276 ns |  42.83 ns |  43.31 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  40.32 ns |  7.148 ns | 0.392 ns |  39.96 ns |  40.74 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 116.89 ns | 17.560 ns | 0.962 ns | 116.16 ns | 117.98 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **54.55 ns** | **14.602 ns** | **0.800 ns** |  **53.77 ns** |  **55.37 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 378.65 ns | 13.655 ns | 0.748 ns | 377.83 ns | 379.30 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 360.01 ns | 23.308 ns | 1.278 ns | 359.24 ns | 361.48 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 283.34 ns |  7.009 ns | 0.384 ns | 283.04 ns | 283.77 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 134.31 ns | 15.986 ns | 0.876 ns | 133.74 ns | 135.32 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 139.37 ns | 24.577 ns | 1.347 ns | 137.84 ns | 140.39 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 382.98 ns | 33.426 ns | 1.832 ns | 380.86 ns | 384.12 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  78.26 ns |  8.031 ns | 0.440 ns |  77.82 ns |  78.70 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 373.80 ns | 13.014 ns | 0.713 ns | 373.24 ns | 374.60 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 342.65 ns | 15.220 ns | 0.834 ns | 341.71 ns | 343.30 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 254.61 ns | 12.157 ns | 0.666 ns | 253.96 ns | 255.29 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 128.83 ns |  7.422 ns | 0.407 ns | 128.49 ns | 129.28 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 120.10 ns | 22.675 ns | 1.243 ns | 118.81 ns | 121.29 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 364.13 ns |  5.251 ns | 0.288 ns | 363.80 ns | 364.33 ns | 0.0300 |     504 B |
