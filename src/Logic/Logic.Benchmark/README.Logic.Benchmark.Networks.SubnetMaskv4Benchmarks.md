```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **26.27 ns** |   **8.754 ns** | **0.480 ns** |  **25.78 ns** |  **26.74 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 118.54 ns |   6.033 ns | 0.331 ns | 118.20 ns | 118.86 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 112.83 ns |  16.287 ns | 0.893 ns | 112.22 ns | 113.85 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.83 ns |   9.107 ns | 0.499 ns |  81.43 ns |  82.39 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  42.54 ns |  16.062 ns | 0.880 ns |  41.62 ns |  43.38 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.32 ns |   2.313 ns | 0.127 ns |  39.23 ns |  39.47 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 114.43 ns |  37.178 ns | 2.038 ns | 112.08 ns | 115.71 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **74.96 ns** |   **8.112 ns** | **0.445 ns** |  **74.46 ns** |  **75.31 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 355.87 ns |  98.214 ns | 5.383 ns | 352.49 ns | 362.08 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 338.40 ns |  30.190 ns | 1.655 ns | 337.42 ns | 340.31 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 257.76 ns |  18.527 ns | 1.016 ns | 256.60 ns | 258.49 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 125.25 ns |  22.050 ns | 1.209 ns | 123.85 ns | 126.04 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 117.93 ns |  25.373 ns | 1.391 ns | 117.02 ns | 119.53 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 360.49 ns | 100.974 ns | 5.535 ns | 354.97 ns | 366.04 ns | 0.0300 |     504 B |
