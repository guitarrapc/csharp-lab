```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error       | StdDev     | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|------------:|-----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **69.9170 ns** |   **3.9714 ns** |  **0.2177 ns** |  **69.6946 ns** |  **70.1296 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0262 ns |   0.0680 ns |  0.0037 ns |   0.0222 ns |   0.0297 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.9966 ns |   3.2105 ns |  0.1760 ns |  73.8012 ns |  74.1426 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7575 ns |   0.0283 ns |  0.0015 ns |   2.7564 ns |   2.7592 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2536 ns |   3.4347 ns |  0.1883 ns |  50.1104 ns |  50.4668 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6274 ns |   0.1923 ns |  0.0105 ns |   0.6213 ns |   0.6396 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.4666 ns |   1.3778 ns |  0.0755 ns |  52.3897 ns |  52.5407 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.1168 ns |   0.9320 ns |  0.0511 ns |   3.0872 ns |   3.1758 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **276.3675 ns** | **184.3539 ns** | **10.1051 ns** | **264.6998 ns** | **282.3063 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6491 ns |   0.2583 ns |  0.0142 ns |   0.6409 ns |   0.6654 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.6632 ns |   5.8514 ns |  0.3207 ns | 211.3337 ns | 211.9743 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3322 ns |   0.6005 ns |  0.0329 ns |   9.3084 ns |   9.3698 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.1244 ns |  20.7281 ns |  1.1362 ns | 148.3041 ns | 150.4213 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6220 ns |   0.0173 ns |  0.0010 ns |   0.6209 ns |   0.6226 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.6235 ns |   6.6562 ns |  0.3648 ns | 155.2058 ns | 155.8797 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.4367 ns |   2.8202 ns |  0.1546 ns |   9.3379 ns |   9.6148 ns |         - |
