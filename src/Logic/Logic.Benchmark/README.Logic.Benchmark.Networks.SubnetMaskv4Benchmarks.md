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
| **FromPrefix**          | **1**      |  **25.73 ns** |  **3.417 ns** | **0.187 ns** |  **25.52 ns** |  **25.89 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 118.12 ns |  5.554 ns | 0.304 ns | 117.77 ns | 118.33 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 112.32 ns |  6.434 ns | 0.353 ns | 112.01 ns | 112.71 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.50 ns |  7.567 ns | 0.415 ns |  81.02 ns |  81.77 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.12 ns |  1.020 ns | 0.056 ns |  41.06 ns |  41.17 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  38.75 ns |  6.298 ns | 0.345 ns |  38.52 ns |  39.14 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 116.09 ns |  8.948 ns | 0.490 ns | 115.55 ns | 116.51 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **74.66 ns** |  **3.377 ns** | **0.185 ns** |  **74.45 ns** |  **74.79 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 357.74 ns | 24.942 ns | 1.367 ns | 356.81 ns | 359.31 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 330.45 ns | 19.177 ns | 1.051 ns | 329.31 ns | 331.39 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 253.76 ns | 27.043 ns | 1.482 ns | 252.40 ns | 255.34 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 122.26 ns |  6.422 ns | 0.352 ns | 121.85 ns | 122.48 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 117.62 ns | 19.345 ns | 1.060 ns | 116.40 ns | 118.31 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 349.49 ns | 36.995 ns | 2.028 ns | 347.15 ns | 350.79 ns | 0.0300 |     504 B |
