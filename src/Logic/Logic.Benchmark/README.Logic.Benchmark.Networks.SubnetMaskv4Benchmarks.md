```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **25.77 ns** |  **5.348 ns** | **0.293 ns** |  **25.50 ns** |  **26.08 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 118.27 ns | 40.561 ns | 2.223 ns | 116.06 ns | 120.51 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 112.47 ns | 11.346 ns | 0.622 ns | 111.82 ns | 113.06 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  84.70 ns |  1.412 ns | 0.077 ns |  84.64 ns |  84.79 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  42.03 ns |  4.885 ns | 0.268 ns |  41.75 ns |  42.28 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.64 ns |  7.541 ns | 0.413 ns |  39.31 ns |  40.11 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 119.81 ns | 13.407 ns | 0.735 ns | 119.16 ns | 120.60 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **78.80 ns** | **20.521 ns** | **1.125 ns** |  **77.58 ns** |  **79.79 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 384.07 ns | 17.499 ns | 0.959 ns | 382.97 ns | 384.76 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 338.30 ns | 51.650 ns | 2.831 ns | 335.37 ns | 341.02 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 258.39 ns | 17.702 ns | 0.970 ns | 257.59 ns | 259.47 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 125.88 ns | 28.789 ns | 1.578 ns | 124.91 ns | 127.70 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 117.27 ns | 13.366 ns | 0.733 ns | 116.55 ns | 118.01 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 371.47 ns | 17.404 ns | 0.954 ns | 370.61 ns | 372.49 ns | 0.0300 |     504 B |
