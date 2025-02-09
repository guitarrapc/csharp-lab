```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **26.35 ns** |   **0.988 ns** |  **0.054 ns** |  **26.29 ns** |  **26.40 ns** | **0.0033** |      **56 B** |
| FromCidrAddress     | 1      | 120.28 ns |  10.894 ns |  0.597 ns | 119.63 ns | 120.80 ns | 0.0067 |     112 B |
| FromCidrAddress2    | 1      | 111.03 ns |   4.602 ns |  0.252 ns | 110.76 ns | 111.27 ns | 0.0067 |     112 B |
| FromIPAddressString | 1      |  81.37 ns |   3.361 ns |  0.184 ns |  81.22 ns |  81.58 ns | 0.0033 |      56 B |
| FromIPAddressType   | 1      |  41.22 ns |   3.235 ns |  0.177 ns |  41.02 ns |  41.36 ns | 0.0052 |      88 B |
| GetNetworkAddress   | 1      |  39.20 ns |   4.057 ns |  0.222 ns |  39.07 ns |  39.45 ns | 0.0033 |      56 B |
| GetAddressRange     | 1      | 113.18 ns |  69.379 ns |  3.803 ns | 108.79 ns | 115.40 ns | 0.0100 |     168 B |
| **FromPrefix**          | **3**      |  **75.06 ns** |   **3.429 ns** |  **0.188 ns** |  **74.94 ns** |  **75.27 ns** | **0.0100** |     **168 B** |
| FromCidrAddress     | 3      | 356.68 ns |  32.827 ns |  1.799 ns | 355.33 ns | 358.72 ns | 0.0200 |     336 B |
| FromCidrAddress2    | 3      | 331.36 ns |  48.895 ns |  2.680 ns | 329.61 ns | 334.45 ns | 0.0200 |     336 B |
| FromIPAddressString | 3      | 250.64 ns |   4.180 ns |  0.229 ns | 250.38 ns | 250.83 ns | 0.0100 |     168 B |
| FromIPAddressType   | 3      | 122.72 ns |   8.173 ns |  0.448 ns | 122.21 ns | 122.99 ns | 0.0157 |     264 B |
| GetNetworkAddress   | 3      | 115.19 ns |   4.296 ns |  0.236 ns | 115.02 ns | 115.46 ns | 0.0100 |     168 B |
| GetAddressRange     | 3      | 351.51 ns | 195.957 ns | 10.741 ns | 342.37 ns | 363.34 ns | 0.0300 |     504 B |
