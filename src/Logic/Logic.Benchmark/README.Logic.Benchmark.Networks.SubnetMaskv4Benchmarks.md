```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.201
  [Host]   : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error     | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.53 ns** |  **3.300 ns** | **0.181 ns** |  **17.34 ns** |  **17.71 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.28 ns | 40.507 ns | 2.220 ns | 121.51 ns | 125.77 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 120.06 ns |  5.162 ns | 0.283 ns | 119.79 ns | 120.36 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  92.60 ns |  3.812 ns | 0.209 ns |  92.39 ns |  92.81 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.49 ns |  4.654 ns | 0.255 ns |  45.29 ns |  45.78 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.90 ns |  9.216 ns | 0.505 ns |  45.33 ns |  46.29 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 125.04 ns | 47.157 ns | 2.585 ns | 123.32 ns | 128.01 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.05 ns** |  **2.194 ns** | **0.120 ns** |  **54.93 ns** |  **55.17 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 365.00 ns | 45.152 ns | 2.475 ns | 363.13 ns | 367.81 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.73 ns |  2.338 ns | 0.128 ns | 349.59 ns | 349.81 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 291.79 ns | 83.538 ns | 4.579 ns | 288.27 ns | 296.97 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 135.92 ns | 30.747 ns | 1.685 ns | 134.05 ns | 137.30 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 140.01 ns | 26.024 ns | 1.426 ns | 139.14 ns | 141.65 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.24 ns | 24.763 ns | 1.357 ns | 363.98 ns | 366.68 ns | 0.0057 |     504 B |
