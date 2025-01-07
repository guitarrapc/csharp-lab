```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.101
  [Host]   : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **24.92 ns** |  **13.424 ns** |  **0.736 ns** |  **24.07 ns** |  **25.39 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 116.41 ns |  23.460 ns |  1.286 ns | 115.58 ns | 117.90 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 111.31 ns |  11.841 ns |  0.649 ns | 110.83 ns | 112.05 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  80.75 ns |   7.712 ns |  0.423 ns |  80.30 ns |  81.13 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.85 ns |   4.129 ns |  0.226 ns |  41.68 ns |  42.10 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.40 ns |   2.711 ns |  0.149 ns |  39.23 ns |  39.51 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 113.80 ns |   4.415 ns |  0.242 ns | 113.60 ns | 114.07 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **74.65 ns** |   **8.284 ns** |  **0.454 ns** |  **74.21 ns** |  **75.12 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 369.20 ns |  14.665 ns |  0.804 ns | 368.61 ns | 370.11 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 330.57 ns |  30.447 ns |  1.669 ns | 329.22 ns | 332.44 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 251.47 ns |   7.234 ns |  0.397 ns | 251.17 ns | 251.92 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 129.91 ns |   9.390 ns |  0.515 ns | 129.53 ns | 130.49 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 116.72 ns |   7.774 ns |  0.426 ns | 116.24 ns | 117.06 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 340.32 ns | 185.063 ns | 10.144 ns | 331.24 ns | 351.26 ns | 0.0300 |     504 B |
