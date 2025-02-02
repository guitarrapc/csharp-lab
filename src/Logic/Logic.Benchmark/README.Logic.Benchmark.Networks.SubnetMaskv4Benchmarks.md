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
| **FromPrefix**          | **1**      |  **26.37 ns** |  **3.511 ns** | **0.192 ns** |  **26.15 ns** |  **26.50 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 117.94 ns | 36.605 ns | 2.006 ns | 116.18 ns | 120.12 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 113.23 ns | 21.076 ns | 1.155 ns | 112.02 ns | 114.32 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  82.36 ns | 11.805 ns | 0.647 ns |  81.67 ns |  82.96 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  42.29 ns |  5.611 ns | 0.308 ns |  42.08 ns |  42.64 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  40.21 ns |  5.781 ns | 0.317 ns |  39.86 ns |  40.46 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 117.76 ns | 29.243 ns | 1.603 ns | 115.93 ns | 118.92 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **76.65 ns** | **12.212 ns** | **0.669 ns** |  **76.15 ns** |  **77.41 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 372.66 ns | 60.372 ns | 3.309 ns | 368.97 ns | 375.35 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 338.50 ns | 68.040 ns | 3.730 ns | 335.64 ns | 342.72 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 253.92 ns |  2.962 ns | 0.162 ns | 253.75 ns | 254.07 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 128.30 ns | 48.351 ns | 2.650 ns | 125.84 ns | 131.11 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 120.15 ns | 26.793 ns | 1.469 ns | 118.87 ns | 121.75 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 365.25 ns | 60.642 ns | 3.324 ns | 361.72 ns | 368.32 ns | 0.0300 |     504 B |
