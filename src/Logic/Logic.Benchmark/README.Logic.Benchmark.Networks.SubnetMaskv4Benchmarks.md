```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.93 ns** |  **3.555 ns** | **0.195 ns** |  **16.70 ns** |  **17.04 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 122.72 ns |  4.865 ns | 0.267 ns | 122.52 ns | 123.03 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.30 ns |  4.712 ns | 0.258 ns | 116.01 ns | 116.51 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  92.07 ns |  5.571 ns | 0.305 ns |  91.83 ns |  92.41 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  43.77 ns |  6.098 ns | 0.334 ns |  43.41 ns |  44.06 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  44.35 ns |  2.822 ns | 0.155 ns |  44.21 ns |  44.52 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 119.09 ns | 24.752 ns | 1.357 ns | 117.97 ns | 120.60 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.99 ns |  6.103 ns | 0.335 ns |  25.66 ns |  26.33 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 122.43 ns |  5.593 ns | 0.307 ns | 122.07 ns | 122.62 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 113.68 ns |  3.203 ns | 0.176 ns | 113.48 ns | 113.80 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  81.41 ns |  1.808 ns | 0.099 ns |  81.35 ns |  81.52 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.74 ns |  0.553 ns | 0.030 ns |  42.71 ns |  42.77 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  40.06 ns |  3.890 ns | 0.213 ns |  39.83 ns |  40.25 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 118.43 ns | 28.227 ns | 1.547 ns | 116.78 ns | 119.85 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **53.38 ns** | **10.200 ns** | **0.559 ns** |  **52.77 ns** |  **53.86 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 377.62 ns | 17.561 ns | 0.963 ns | 376.54 ns | 378.40 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 356.53 ns |  6.093 ns | 0.334 ns | 356.26 ns | 356.90 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 282.28 ns |  7.629 ns | 0.418 ns | 281.81 ns | 282.60 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 135.28 ns | 23.089 ns | 1.266 ns | 134.38 ns | 136.73 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 139.31 ns | 36.323 ns | 1.991 ns | 137.02 ns | 140.62 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 374.04 ns | 18.598 ns | 1.019 ns | 372.94 ns | 374.94 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  76.70 ns | 17.339 ns | 0.950 ns |  75.81 ns |  77.70 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 378.66 ns | 19.203 ns | 1.053 ns | 377.69 ns | 379.78 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 338.28 ns |  6.011 ns | 0.329 ns | 338.08 ns | 338.66 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 257.30 ns |  9.029 ns | 0.495 ns | 256.81 ns | 257.80 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 128.16 ns | 10.629 ns | 0.583 ns | 127.57 ns | 128.74 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 118.35 ns |  6.640 ns | 0.364 ns | 117.95 ns | 118.65 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 353.75 ns | 89.539 ns | 4.908 ns | 348.20 ns | 357.51 ns | 0.0300 |     504 B |
