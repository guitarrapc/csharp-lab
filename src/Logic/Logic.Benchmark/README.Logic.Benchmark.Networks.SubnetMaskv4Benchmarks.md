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
| **FromPrefix**          | **1**      |  **17.76 ns** |   **1.341 ns** | **0.074 ns** |  **17.68 ns** |  **17.82 ns** | **0.0007** |      **56 B** |
| FromCidrAddress     | 1      | 121.79 ns |  49.270 ns | 2.701 ns | 120.20 ns | 124.91 ns | 0.0012 |     112 B |
| FromCidrAddress2    | 1      | 119.32 ns |   5.626 ns | 0.308 ns | 119.02 ns | 119.64 ns | 0.0012 |     112 B |
| FromIPAddressString | 1      |  90.50 ns |   6.696 ns | 0.367 ns |  90.21 ns |  90.91 ns | 0.0006 |      56 B |
| FromIPAddressType   | 1      |  45.20 ns |   1.363 ns | 0.075 ns |  45.12 ns |  45.25 ns | 0.0010 |      88 B |
| GetNetworkAddress   | 1      |  44.72 ns |   1.286 ns | 0.070 ns |  44.64 ns |  44.77 ns | 0.0007 |      56 B |
| GetAddressRange     | 1      | 119.31 ns |  13.471 ns | 0.738 ns | 118.75 ns | 120.14 ns | 0.0019 |     168 B |
| **FromPrefix**          | **3**      |  **56.40 ns** |   **1.666 ns** | **0.091 ns** |  **56.34 ns** |  **56.51 ns** | **0.0020** |     **168 B** |
| FromCidrAddress     | 3      | 375.77 ns |  13.938 ns | 0.764 ns | 375.24 ns | 376.64 ns | 0.0038 |     336 B |
| FromCidrAddress2    | 3      | 360.23 ns | 102.236 ns | 5.604 ns | 356.98 ns | 366.71 ns | 0.0038 |     336 B |
| FromIPAddressString | 3      | 289.11 ns |  90.563 ns | 4.964 ns | 286.06 ns | 294.84 ns | 0.0019 |     168 B |
| FromIPAddressType   | 3      | 136.27 ns |   6.122 ns | 0.336 ns | 136.01 ns | 136.65 ns | 0.0031 |     264 B |
| GetNetworkAddress   | 3      | 139.81 ns |  17.597 ns | 0.965 ns | 138.83 ns | 140.76 ns | 0.0019 |     168 B |
| GetAddressRange     | 3      | 375.46 ns | 163.965 ns | 8.987 ns | 365.10 ns | 381.16 ns | 0.0057 |     504 B |
