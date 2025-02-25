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
| **FromPrefix**          | **.NET 8.0** | **1**      |  **16.58 ns** |  **5.813 ns** | **0.319 ns** |  **16.24 ns** |  **16.88 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 123.96 ns |  8.009 ns | 0.439 ns | 123.61 ns | 124.45 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 116.09 ns |  0.350 ns | 0.019 ns | 116.08 ns | 116.11 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  88.97 ns |  7.351 ns | 0.403 ns |  88.65 ns |  89.42 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  43.36 ns |  3.754 ns | 0.206 ns |  43.21 ns |  43.60 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  42.30 ns |  3.893 ns | 0.213 ns |  42.10 ns |  42.52 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 115.06 ns | 19.431 ns | 1.065 ns | 114.06 ns | 116.18 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  25.55 ns |  3.148 ns | 0.173 ns |  25.43 ns |  25.75 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 116.24 ns |  2.573 ns | 0.141 ns | 116.09 ns | 116.36 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 111.12 ns |  6.431 ns | 0.352 ns | 110.84 ns | 111.51 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  80.72 ns |  7.966 ns | 0.437 ns |  80.33 ns |  81.19 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  43.61 ns |  1.015 ns | 0.056 ns |  43.57 ns |  43.67 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  40.52 ns |  0.762 ns | 0.042 ns |  40.48 ns |  40.56 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 117.29 ns |  7.332 ns | 0.402 ns | 116.83 ns | 117.56 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **54.42 ns** | **10.742 ns** | **0.589 ns** |  **53.77 ns** |  **54.91 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 384.06 ns | 14.077 ns | 0.772 ns | 383.31 ns | 384.85 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 352.30 ns | 18.542 ns | 1.016 ns | 351.18 ns | 353.16 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 275.62 ns | 14.620 ns | 0.801 ns | 274.82 ns | 276.42 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 134.27 ns | 17.271 ns | 0.947 ns | 133.23 ns | 135.08 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 147.98 ns | 22.286 ns | 1.222 ns | 147.10 ns | 149.38 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 370.87 ns | 43.103 ns | 2.363 ns | 369.37 ns | 373.59 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  79.53 ns | 15.417 ns | 0.845 ns |  78.91 ns |  80.50 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 366.80 ns | 14.567 ns | 0.798 ns | 365.89 ns | 367.40 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 339.08 ns | 36.835 ns | 2.019 ns | 336.76 ns | 340.47 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 248.45 ns | 36.024 ns | 1.975 ns | 247.00 ns | 250.70 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 123.78 ns |  6.335 ns | 0.347 ns | 123.46 ns | 124.15 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 117.09 ns |  6.751 ns | 0.370 ns | 116.71 ns | 117.45 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 353.92 ns | 23.233 ns | 1.273 ns | 352.47 ns | 354.87 ns | 0.0300 |     504 B |
