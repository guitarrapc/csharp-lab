```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **26.34 ns** |   **2.042 ns** | **0.112 ns** |  **26.21 ns** |  **26.41 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 117.44 ns |  10.944 ns | 0.600 ns | 117.07 ns | 118.13 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 114.46 ns |  12.770 ns | 0.700 ns | 113.88 ns | 115.23 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  83.30 ns |   5.981 ns | 0.328 ns |  82.93 ns |  83.56 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  44.20 ns |   6.189 ns | 0.339 ns |  43.81 ns |  44.41 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  40.26 ns |  11.666 ns | 0.639 ns |  39.52 ns |  40.65 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 116.18 ns |  20.812 ns | 1.141 ns | 115.19 ns | 117.43 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **77.11 ns** |   **7.388 ns** | **0.405 ns** |  **76.68 ns** |  **77.48 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 360.19 ns |  35.033 ns | 1.920 ns | 358.61 ns | 362.33 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 336.65 ns |  22.819 ns | 1.251 ns | 335.67 ns | 338.06 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 256.17 ns |  21.273 ns | 1.166 ns | 255.46 ns | 257.52 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 127.51 ns |  27.838 ns | 1.526 ns | 125.75 ns | 128.45 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 119.34 ns |   6.786 ns | 0.372 ns | 118.91 ns | 119.58 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 349.59 ns | 164.549 ns | 9.019 ns | 343.05 ns | 359.88 ns | 0.0300 |     504 B |
