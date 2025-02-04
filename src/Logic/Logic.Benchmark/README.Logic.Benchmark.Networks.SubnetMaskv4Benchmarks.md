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
| **FromPrefix**          | **1**      |  **26.88 ns** |  **4.380 ns** | **0.240 ns** |  **26.60 ns** |  **27.03 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 118.12 ns |  6.007 ns | 0.329 ns | 117.85 ns | 118.49 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 113.75 ns |  1.184 ns | 0.065 ns | 113.68 ns | 113.81 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.45 ns |  2.819 ns | 0.155 ns |  81.28 ns |  81.59 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.83 ns |  8.504 ns | 0.466 ns |  41.46 ns |  42.35 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.97 ns |  2.955 ns | 0.162 ns |  39.86 ns |  40.16 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 114.68 ns | 24.251 ns | 1.329 ns | 113.30 ns | 115.95 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **75.90 ns** | **11.033 ns** | **0.605 ns** |  **75.23 ns** |  **76.41 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 359.19 ns | 22.707 ns | 1.245 ns | 357.77 ns | 360.11 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 336.73 ns |  6.008 ns | 0.329 ns | 336.36 ns | 336.98 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 254.47 ns | 16.005 ns | 0.877 ns | 253.46 ns | 255.07 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 129.75 ns | 29.713 ns | 1.629 ns | 128.62 ns | 131.62 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 115.99 ns |  6.073 ns | 0.333 ns | 115.77 ns | 116.37 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 347.64 ns |  7.229 ns | 0.396 ns | 347.20 ns | 347.98 ns | 0.0300 |     504 B |
