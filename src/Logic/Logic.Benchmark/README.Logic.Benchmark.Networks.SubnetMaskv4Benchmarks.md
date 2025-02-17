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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.67 ns** |   **1.812 ns** | **0.099 ns** |  **16.56 ns** |  **16.76 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 119.13 ns |  14.087 ns | 0.772 ns | 118.34 ns | 119.89 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 115.92 ns |   4.834 ns | 0.265 ns | 115.72 ns | 116.22 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  92.65 ns |   7.222 ns | 0.396 ns |  92.33 ns |  93.10 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  43.69 ns |   6.442 ns | 0.353 ns |  43.32 ns |  44.02 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  43.37 ns |   4.282 ns | 0.235 ns |  43.11 ns |  43.55 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 119.84 ns |  19.938 ns | 1.093 ns | 118.80 ns | 120.98 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.64 ns |   4.244 ns | 0.233 ns |  25.46 ns |  25.90 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 121.17 ns |  27.224 ns | 1.492 ns | 120.09 ns | 122.87 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 112.74 ns |  13.840 ns | 0.759 ns | 111.95 ns | 113.46 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  79.26 ns |   8.019 ns | 0.440 ns |  78.89 ns |  79.74 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  42.03 ns |   0.836 ns | 0.046 ns |  41.98 ns |  42.06 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  41.44 ns |   2.469 ns | 0.135 ns |  41.30 ns |  41.56 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 115.58 ns |  31.202 ns | 1.710 ns | 114.33 ns | 117.53 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **51.65 ns** |  **10.465 ns** | **0.574 ns** |  **50.99 ns** |  **52.01 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 372.69 ns |  40.191 ns | 2.203 ns | 370.31 ns | 374.65 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 350.60 ns |  50.011 ns | 2.741 ns | 347.86 ns | 353.35 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 310.79 ns |  12.915 ns | 0.708 ns | 309.99 ns | 311.35 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 130.22 ns |  15.302 ns | 0.839 ns | 129.28 ns | 130.89 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 138.64 ns |  41.898 ns | 2.297 ns | 136.13 ns | 140.63 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 356.09 ns |  45.831 ns | 2.512 ns | 354.59 ns | 358.99 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  74.68 ns |  14.653 ns | 0.803 ns |  74.01 ns |  75.57 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 359.21 ns |   3.525 ns | 0.193 ns | 358.98 ns | 359.34 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 330.47 ns |  18.421 ns | 1.010 ns | 329.39 ns | 331.39 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 253.52 ns |  45.619 ns | 2.501 ns | 251.47 ns | 256.30 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 122.64 ns |   6.415 ns | 0.352 ns | 122.31 ns | 123.01 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 119.35 ns | 106.589 ns | 5.843 ns | 115.76 ns | 126.09 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 344.09 ns | 177.137 ns | 9.709 ns | 333.08 ns | 351.42 ns | 0.0300 |     504 B |
