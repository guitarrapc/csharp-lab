```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev    | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|----------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **18.43 ns** |   **4.104 ns** |  **0.225 ns** |  **18.30 ns** |  **18.69 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.94 ns |  13.946 ns |  0.764 ns | 121.45 ns | 122.82 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 120.71 ns |  42.460 ns |  2.327 ns | 119.32 ns | 123.39 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.08 ns |   3.837 ns |  0.210 ns |  89.84 ns |  90.24 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.83 ns |   1.933 ns |  0.106 ns |  44.73 ns |  44.94 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.52 ns |  15.311 ns |  0.839 ns |  43.87 ns |  45.47 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 123.31 ns |  40.423 ns |  2.216 ns | 121.08 ns | 125.51 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.23 ns** |   **2.435 ns** |  **0.133 ns** |  **55.12 ns** |  **55.38 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 378.50 ns |   6.481 ns |  0.355 ns | 378.11 ns | 378.79 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 348.16 ns |   2.359 ns |  0.129 ns | 348.07 ns | 348.30 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 294.23 ns | 213.940 ns | 11.727 ns | 285.91 ns | 307.64 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.31 ns |  11.049 ns |  0.606 ns | 133.79 ns | 134.97 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 138.06 ns |   9.239 ns |  0.506 ns | 137.54 ns | 138.56 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 365.01 ns |   1.017 ns |  0.056 ns | 364.95 ns | 365.06 ns | 0.0057 |     504 B |
