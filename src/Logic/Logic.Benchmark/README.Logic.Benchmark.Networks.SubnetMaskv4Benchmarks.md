```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method              | Number | Mean      | Error      | StdDev   | Min       | Max       | Gen0   | Allocated |
|-------------------- |------- |----------:|-----------:|---------:|----------:|----------:|-------:|----------:|
| **FromPrefix**          | **1**      |  **17.63 ns** |   **1.114 ns** | **0.061 ns** |  **17.58 ns** |  **17.70 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 124.32 ns |   6.965 ns | 0.382 ns | 123.92 ns | 124.69 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 117.90 ns |   0.215 ns | 0.012 ns | 117.89 ns | 117.91 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  89.23 ns |  10.996 ns | 0.603 ns |  88.76 ns |  89.91 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  44.68 ns |   3.375 ns | 0.185 ns |  44.51 ns |  44.88 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.26 ns |   1.176 ns | 0.064 ns |  44.20 ns |  44.33 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 117.67 ns |  25.004 ns | 1.371 ns | 116.70 ns | 119.24 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **54.80 ns** |   **2.464 ns** | **0.135 ns** |  **54.67 ns** |  **54.94 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 370.96 ns | 117.214 ns | 6.425 ns | 366.24 ns | 378.27 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 349.59 ns |  11.573 ns | 0.634 ns | 348.93 ns | 350.19 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 272.27 ns |   2.868 ns | 0.157 ns | 272.09 ns | 272.39 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 134.40 ns |  10.037 ns | 0.550 ns | 133.79 ns | 134.86 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.35 ns |   6.056 ns | 0.332 ns | 138.98 ns | 139.60 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 371.84 ns |  83.498 ns | 4.577 ns | 368.72 ns | 377.09 ns | 0.0057 |     504 B |
