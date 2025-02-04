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
| **FromPrefix**          | **1**      |  **25.46 ns** |  **2.386 ns** | **0.131 ns** |  **25.37 ns** |  **25.61 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 114.16 ns | 11.212 ns | 0.615 ns | 113.71 ns | 114.86 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 112.25 ns | 20.029 ns | 1.098 ns | 111.22 ns | 113.41 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.89 ns |  6.693 ns | 0.367 ns |  81.65 ns |  82.31 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.27 ns |  1.749 ns | 0.096 ns |  41.20 ns |  41.38 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  38.79 ns |  7.394 ns | 0.405 ns |  38.54 ns |  39.26 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 116.78 ns | 15.762 ns | 0.864 ns | 115.82 ns | 117.50 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **75.06 ns** |  **1.097 ns** | **0.060 ns** |  **74.99 ns** |  **75.09 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 353.22 ns | 66.446 ns | 3.642 ns | 350.52 ns | 357.36 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 329.83 ns | 16.958 ns | 0.930 ns | 328.98 ns | 330.83 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 253.03 ns | 14.682 ns | 0.805 ns | 252.42 ns | 253.95 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 123.29 ns |  7.946 ns | 0.436 ns | 122.92 ns | 123.77 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 115.86 ns |  3.504 ns | 0.192 ns | 115.67 ns | 116.05 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 335.28 ns | 68.030 ns | 3.729 ns | 331.13 ns | 338.36 ns | 0.0300 |     504 B |
