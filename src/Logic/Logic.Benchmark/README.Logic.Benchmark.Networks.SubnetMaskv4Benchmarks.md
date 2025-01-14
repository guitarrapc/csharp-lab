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
| **FromPrefix**          | **1**      |  **26.06 ns** |   **6.059 ns** |  **0.332 ns** |  **25.69 ns** |  **26.33 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 117.84 ns |  13.876 ns |  0.761 ns | 116.99 ns | 118.46 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 114.53 ns |   6.448 ns |  0.353 ns | 114.28 ns | 114.94 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.72 ns |  11.460 ns |  0.628 ns |  81.08 ns |  82.34 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  42.22 ns |  11.228 ns |  0.615 ns |  41.61 ns |  42.84 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.52 ns |   2.167 ns |  0.119 ns |  39.40 ns |  39.64 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 113.31 ns |  59.255 ns |  3.248 ns | 109.69 ns | 115.97 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **73.96 ns** |   **2.176 ns** |  **0.119 ns** |  **73.83 ns** |  **74.05 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 356.18 ns |  80.561 ns |  4.416 ns | 353.61 ns | 361.28 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 344.66 ns |  88.051 ns |  4.826 ns | 339.25 ns | 348.53 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 250.62 ns |   7.028 ns |  0.385 ns | 250.39 ns | 251.07 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 123.30 ns |   4.609 ns |  0.253 ns | 123.14 ns | 123.59 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 115.56 ns |   8.740 ns |  0.479 ns | 115.04 ns | 115.98 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 346.41 ns | 346.438 ns | 18.989 ns | 331.56 ns | 367.81 ns | 0.0300 |     504 B |
