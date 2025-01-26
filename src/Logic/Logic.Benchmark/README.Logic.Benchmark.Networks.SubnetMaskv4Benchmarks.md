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
| **FromPrefix**          | **1**      |  **25.63 ns** |  **3.902 ns** | **0.214 ns** |  **25.44 ns** |  **25.86 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 114.69 ns | 11.673 ns | 0.640 ns | 114.16 ns | 115.40 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 112.08 ns |  6.926 ns | 0.380 ns | 111.76 ns | 112.50 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.52 ns |  1.327 ns | 0.073 ns |  81.44 ns |  81.59 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  42.50 ns |  6.155 ns | 0.337 ns |  42.22 ns |  42.87 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  40.27 ns |  5.086 ns | 0.279 ns |  39.95 ns |  40.43 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 117.71 ns | 15.784 ns | 0.865 ns | 117.10 ns | 118.70 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **75.74 ns** |  **4.620 ns** | **0.253 ns** |  **75.44 ns** |  **75.89 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 354.97 ns | 25.408 ns | 1.393 ns | 353.63 ns | 356.41 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 333.08 ns | 41.323 ns | 2.265 ns | 331.23 ns | 335.60 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 253.10 ns | 19.543 ns | 1.071 ns | 251.87 ns | 253.77 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 125.16 ns | 18.179 ns | 0.996 ns | 124.24 ns | 126.22 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 118.22 ns | 19.712 ns | 1.080 ns | 117.06 ns | 119.19 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 335.08 ns |  4.722 ns | 0.259 ns | 334.81 ns | 335.33 ns | 0.0300 |     504 B |
