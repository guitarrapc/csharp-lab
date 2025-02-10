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
| **FromPrefix**          | **1**      |  **27.30 ns** |  **4.775 ns** | **0.262 ns** |  **27.00 ns** |  **27.48 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 122.16 ns |  6.698 ns | 0.367 ns | 121.89 ns | 122.57 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 114.61 ns |  5.169 ns | 0.283 ns | 114.37 ns | 114.92 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  85.81 ns |  3.990 ns | 0.219 ns |  85.59 ns |  86.03 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  44.92 ns |  1.799 ns | 0.099 ns |  44.86 ns |  45.03 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  41.13 ns |  8.582 ns | 0.470 ns |  40.65 ns |  41.59 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 122.01 ns | 36.124 ns | 1.980 ns | 120.37 ns | 124.21 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **81.77 ns** |  **7.894 ns** | **0.433 ns** |  **81.30 ns** |  **82.15 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 365.35 ns | 29.997 ns | 1.644 ns | 364.23 ns | 367.24 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 346.09 ns | 30.478 ns | 1.671 ns | 344.18 ns | 347.25 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 259.33 ns | 29.759 ns | 1.631 ns | 258.10 ns | 261.18 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 134.36 ns |  9.509 ns | 0.521 ns | 133.80 ns | 134.83 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 122.30 ns |  6.378 ns | 0.350 ns | 121.96 ns | 122.66 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 373.52 ns | 21.851 ns | 1.198 ns | 372.22 ns | 374.58 ns | 0.0300 |     504 B |
