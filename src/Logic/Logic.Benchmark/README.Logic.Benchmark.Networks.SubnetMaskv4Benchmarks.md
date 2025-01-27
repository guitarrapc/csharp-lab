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
| **FromPrefix**          | **1**      |  **26.89 ns** |  **6.849 ns** | **0.375 ns** |  **26.46 ns** |  **27.17 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 121.02 ns | 83.277 ns | 4.565 ns | 118.32 ns | 126.29 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 115.61 ns | 10.040 ns | 0.550 ns | 115.13 ns | 116.21 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  84.73 ns |  4.122 ns | 0.226 ns |  84.53 ns |  84.98 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  43.17 ns |  3.512 ns | 0.192 ns |  42.96 ns |  43.33 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  40.91 ns |  6.158 ns | 0.338 ns |  40.63 ns |  41.28 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 121.32 ns | 18.379 ns | 1.007 ns | 120.51 ns | 122.45 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **79.80 ns** | **20.628 ns** | **1.131 ns** |  **79.14 ns** |  **81.10 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 363.88 ns | 51.244 ns | 2.809 ns | 360.80 ns | 366.30 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 342.24 ns | 70.291 ns | 3.853 ns | 340.02 ns | 346.69 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 257.11 ns |  9.142 ns | 0.501 ns | 256.53 ns | 257.44 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 130.63 ns |  8.271 ns | 0.453 ns | 130.31 ns | 131.15 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 120.76 ns |  7.367 ns | 0.404 ns | 120.43 ns | 121.21 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 356.32 ns | 55.786 ns | 3.058 ns | 353.97 ns | 359.78 ns | 0.0300 |     504 B |
