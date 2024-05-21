```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.56 ns** |  **0.824 ns** | **0.045 ns** |  **17.51 ns** |  **17.59 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.37 ns |  6.662 ns | 0.365 ns | 121.11 ns | 121.79 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 116.73 ns |  3.671 ns | 0.201 ns | 116.50 ns | 116.87 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.80 ns |  3.260 ns | 0.179 ns |  89.69 ns |  90.01 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.70 ns |  3.111 ns | 0.171 ns |  45.52 ns |  45.86 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.55 ns | 26.402 ns | 1.447 ns |  43.95 ns |  46.75 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.70 ns | 17.508 ns | 0.960 ns | 121.64 ns | 123.52 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.61 ns** |  **2.176 ns** | **0.119 ns** |  **55.49 ns** |  **55.73 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 378.77 ns |  3.651 ns | 0.200 ns | 378.65 ns | 379.00 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.07 ns | 36.531 ns | 2.002 ns | 346.92 ns | 350.89 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 282.72 ns | 11.793 ns | 0.646 ns | 282.33 ns | 283.46 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.38 ns | 12.143 ns | 0.666 ns | 133.77 ns | 135.09 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 137.13 ns |  0.761 ns | 0.042 ns | 137.09 ns | 137.17 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 367.00 ns | 39.347 ns | 2.157 ns | 365.06 ns | 369.32 ns | 0.0057 |     504 B |
