```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.300
  [Host]   : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.31 ns** |   **1.177 ns** | **0.064 ns** |  **17.23 ns** |  **17.35 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 122.66 ns |  17.262 ns | 0.946 ns | 121.89 ns | 123.72 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 115.91 ns |   2.088 ns | 0.114 ns | 115.81 ns | 116.03 ns | 0.0013 |     112 B |
| FromIPAddressString | 1      |  90.11 ns |   1.563 ns | 0.086 ns |  90.03 ns |  90.20 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.76 ns |   3.939 ns | 0.216 ns |  44.54 ns |  44.97 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.93 ns |  20.384 ns | 1.117 ns |  43.66 ns |  45.77 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 126.43 ns | 105.517 ns | 5.784 ns | 123.05 ns | 133.11 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.35 ns** |   **6.295 ns** | **0.345 ns** |  **53.95 ns** |  **54.57 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 366.46 ns |   2.078 ns | 0.114 ns | 366.34 ns | 366.57 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 346.35 ns |  17.743 ns | 0.973 ns | 345.71 ns | 347.47 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 274.99 ns |  10.676 ns | 0.585 ns | 274.61 ns | 275.67 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.00 ns |   5.222 ns | 0.286 ns | 135.70 ns | 136.26 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.27 ns |   3.611 ns | 0.198 ns | 139.08 ns | 139.47 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 366.97 ns |  57.590 ns | 3.157 ns | 363.99 ns | 370.28 ns | 0.0057 |     504 B |
