```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.203
  [Host]            : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.15 (8.0.1525.16413), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.4 (9.0.425.16305), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.7824 ns** | **11.9569 ns** | **0.6554 ns** |  **65.3633 ns** |  **66.5377 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.5964 ns |  4.6101 ns | 0.2527 ns |  73.4419 ns |  73.8880 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7565 ns |  0.0217 ns | 0.0012 ns |   2.7552 ns |   2.7576 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.1310 ns |  5.4423 ns | 0.2983 ns |  49.9495 ns |  50.4753 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6206 ns |  0.0035 ns | 0.0002 ns |   0.6204 ns |   0.6208 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.8807 ns |  1.1947 ns | 0.0655 ns |  52.8292 ns |  52.9544 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0640 ns |  0.9685 ns | 0.0531 ns |   3.0327 ns |   3.1253 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.2683 ns** |  **9.2754 ns** | **0.5084 ns** | **196.9688 ns** | **197.8553 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6456 ns |  0.1579 ns | 0.0087 ns |   0.6405 ns |   0.6556 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.6899 ns |  5.2304 ns | 0.2867 ns | 211.4819 ns | 212.0170 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3910 ns |  0.2567 ns | 0.0141 ns |   9.3786 ns |   9.4063 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 151.4983 ns | 18.6448 ns | 1.0220 ns | 150.4384 ns | 152.4776 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6530 ns |  0.7619 ns | 0.0418 ns |   0.6273 ns |   0.7012 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.3430 ns | 22.5334 ns | 1.2351 ns | 154.3551 ns | 156.7278 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.1459 ns |  4.8147 ns | 0.2639 ns |   8.9807 ns |   9.4503 ns |         - |
