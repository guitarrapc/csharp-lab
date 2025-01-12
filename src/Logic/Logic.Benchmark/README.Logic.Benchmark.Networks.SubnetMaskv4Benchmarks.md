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
| **FromPrefix**          | **1**      |  **23.80 ns** |   **3.158 ns** | **0.173 ns** |  **23.62 ns** |  **23.97 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 107.12 ns |  12.197 ns | 0.669 ns | 106.72 ns | 107.90 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 102.35 ns |   6.607 ns | 0.362 ns | 101.94 ns | 102.64 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  74.72 ns |  12.601 ns | 0.691 ns |  74.27 ns |  75.52 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  38.18 ns |   5.402 ns | 0.296 ns |  37.89 ns |  38.48 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  36.22 ns |   3.377 ns | 0.185 ns |  36.03 ns |  36.40 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 107.61 ns |  33.030 ns | 1.810 ns | 106.07 ns | 109.60 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **69.08 ns** |   **4.121 ns** | **0.226 ns** |  **68.86 ns** |  **69.32 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 328.89 ns |  51.561 ns | 2.826 ns | 325.62 ns | 330.60 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 309.20 ns |  28.281 ns | 1.550 ns | 307.42 ns | 310.25 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 231.35 ns |  11.987 ns | 0.657 ns | 230.66 ns | 231.96 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 114.90 ns |   1.965 ns | 0.108 ns | 114.78 ns | 114.99 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 106.97 ns |   6.383 ns | 0.350 ns | 106.57 ns | 107.22 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 317.73 ns | 169.940 ns | 9.315 ns | 306.98 ns | 323.38 ns | 0.0300 |     504 B |
