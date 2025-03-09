```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.8294 ns** |  **2.3755 ns** | **0.1302 ns** |  **65.7429 ns** |  **65.9792 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0388 ns |  0.2444 ns | 0.0134 ns |   0.0266 ns |   0.0531 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.4399 ns |  1.4572 ns | 0.0799 ns |  72.3600 ns |  72.5198 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7689 ns |  0.3091 ns | 0.0169 ns |   2.7533 ns |   2.7869 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.3922 ns |  0.7074 ns | 0.0388 ns |  50.3522 ns |  50.4296 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6284 ns |  0.1485 ns | 0.0081 ns |   0.6218 ns |   0.6375 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  51.9120 ns |  2.4192 ns | 0.1326 ns |  51.7623 ns |  52.0146 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0944 ns |  0.1970 ns | 0.0108 ns |   3.0847 ns |   3.1061 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **198.8834 ns** | **61.2828 ns** | **3.3591 ns** | **195.0140 ns** | **201.0505 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6411 ns |  0.0254 ns | 0.0014 ns |   0.6400 ns |   0.6427 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 214.5259 ns |  8.4848 ns | 0.4651 ns | 214.0527 ns | 214.9824 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.5296 ns |  0.5741 ns | 0.0315 ns |   9.5018 ns |   9.5638 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.1300 ns | 15.8387 ns | 0.8682 ns | 148.4366 ns | 150.1037 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6197 ns |  0.0188 ns | 0.0010 ns |   0.6186 ns |   0.6207 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.7850 ns |  5.2518 ns | 0.2879 ns | 155.5804 ns | 156.1142 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3123 ns |  1.5433 ns | 0.0846 ns |   9.2438 ns |   9.4068 ns |         - |
