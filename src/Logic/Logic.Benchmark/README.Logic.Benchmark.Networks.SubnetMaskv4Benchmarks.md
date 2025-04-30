```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method              | Runtime  | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |--------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **.NET 8.0** | **1**      |  **17.39 ns** |   **6.652 ns** | **0.365 ns** |  **17.00 ns** |  **17.72 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | .NET 8.0 | 1      | 124.02 ns |   9.806 ns | 0.537 ns | 123.40 ns | 124.35 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 8.0 | 1      | 119.59 ns |  18.661 ns | 1.023 ns | 118.68 ns | 120.70 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 8.0 | 1      |  92.60 ns |   3.081 ns | 0.169 ns |  92.42 ns |  92.76 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 8.0 | 1      |  46.34 ns |   3.679 ns | 0.202 ns |  46.16 ns |  46.56 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 8.0 | 1      |  44.60 ns |   4.387 ns | 0.240 ns |  44.44 ns |  44.88 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 8.0 | 1      | 118.06 ns |  16.409 ns | 0.899 ns | 117.05 ns | 118.76 ns | 0.0100 |     168 B |
| FromPrefix          | .NET 9.0 | 1      |  26.05 ns |   5.101 ns | 0.280 ns |  25.83 ns |  26.37 ns | 0.0033 |      56 B |
| FromCidrAddress     | .NET 9.0 | 1      | 121.54 ns |   8.961 ns | 0.491 ns | 121.07 ns | 122.05 ns | 0.0067 |     112 B |
| FromCidrAddress2    | .NET 9.0 | 1      | 114.53 ns |   7.661 ns | 0.420 ns | 114.15 ns | 114.98 ns | 0.0067 |     112 B |
| FromIPAddressString | .NET 9.0 | 1      |  83.12 ns |   5.290 ns | 0.290 ns |  82.84 ns |  83.42 ns | 0.0033 |      56 B |
| FromIPAddressType   | .NET 9.0 | 1      |  44.60 ns |   5.776 ns | 0.317 ns |  44.32 ns |  44.94 ns | 0.0052 |      88 B |
| GetNetworkAddress   | .NET 9.0 | 1      |  40.72 ns |   1.298 ns | 0.071 ns |  40.65 ns |  40.79 ns | 0.0033 |      56 B |
| GetAddressRange     | .NET 9.0 | 1      | 119.80 ns |  24.351 ns | 1.335 ns | 118.62 ns | 121.25 ns | 0.0100 |     168 B |
| **FromPrefix**          | **.NET 8.0** | **3**      |  **56.09 ns** |   **8.807 ns** | **0.483 ns** |  **55.61 ns** |  **56.58 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | .NET 8.0 | 3      | 385.66 ns |  11.455 ns | 0.628 ns | 385.14 ns | 386.35 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 8.0 | 3      | 359.78 ns |  61.178 ns | 3.353 ns | 357.33 ns | 363.61 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 8.0 | 3      | 277.64 ns |  10.094 ns | 0.553 ns | 277.23 ns | 278.27 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 8.0 | 3      | 140.14 ns |   2.763 ns | 0.151 ns | 139.99 ns | 140.29 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 8.0 | 3      | 142.02 ns |  47.884 ns | 2.625 ns | 139.14 ns | 144.27 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 8.0 | 3      | 381.71 ns | 110.479 ns | 6.056 ns | 374.77 ns | 385.90 ns | 0.0300 |     504 B |
| FromPrefix          | .NET 9.0 | 3      |  79.11 ns |  10.617 ns | 0.582 ns |  78.44 ns |  79.50 ns | 0.0100 |     168 B |
| FromCidrAddress     | .NET 9.0 | 3      | 362.92 ns |  15.167 ns | 0.831 ns | 362.20 ns | 363.83 ns | 0.0200 |     336 B |
| FromCidrAddress2    | .NET 9.0 | 3      | 336.01 ns |  44.973 ns | 2.465 ns | 334.47 ns | 338.86 ns | 0.0200 |     336 B |
| FromIPAddressString | .NET 9.0 | 3      | 254.13 ns |  14.693 ns | 0.805 ns | 253.21 ns | 254.65 ns | 0.0100 |     168 B |
| FromIPAddressType   | .NET 9.0 | 3      | 126.68 ns |  12.904 ns | 0.707 ns | 126.01 ns | 127.42 ns | 0.0157 |     264 B |
| GetNetworkAddress   | .NET 9.0 | 3      | 119.68 ns |  17.181 ns | 0.942 ns | 119.07 ns | 120.77 ns | 0.0100 |     168 B |
| GetAddressRange     | .NET 9.0 | 3      | 343.66 ns | 106.593 ns | 5.843 ns | 339.75 ns | 350.38 ns | 0.0300 |     504 B |
