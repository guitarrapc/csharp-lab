```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.90 ns** |   **2.017 ns** | **0.111 ns** |  **17.78 ns** |  **17.98 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 123.38 ns |  38.656 ns | 2.119 ns | 121.47 ns | 125.66 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 118.88 ns |  41.766 ns | 2.289 ns | 117.25 ns | 121.50 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  93.10 ns |   2.534 ns | 0.139 ns |  92.98 ns |  93.25 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.90 ns |   3.313 ns | 0.182 ns |  45.77 ns |  46.10 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  45.47 ns |  19.158 ns | 1.050 ns |  44.66 ns |  46.66 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 122.38 ns |  29.678 ns | 1.627 ns | 121.21 ns | 124.24 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **55.99 ns** |  **16.499 ns** | **0.904 ns** |  **55.13 ns** |  **56.93 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 378.70 ns |   9.759 ns | 0.535 ns | 378.36 ns | 379.32 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 352.78 ns |  30.644 ns | 1.680 ns | 350.87 ns | 354.03 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 288.67 ns |  73.645 ns | 4.037 ns | 285.87 ns | 293.30 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.78 ns |   1.165 ns | 0.064 ns | 134.71 ns | 134.83 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 141.33 ns |  55.460 ns | 3.040 ns | 139.47 ns | 144.84 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.09 ns | 104.485 ns | 5.727 ns | 362.26 ns | 372.67 ns | 0.0057 |     504 B |
