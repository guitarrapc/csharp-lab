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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **64.1213 ns** |  **1.1531 ns** | **0.0632 ns** |  **64.0509 ns** |  **64.1732 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0344 ns |  0.1387 ns | 0.0076 ns |   0.0262 ns |   0.0412 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  74.8434 ns |  1.6020 ns | 0.0878 ns |  74.7882 ns |  74.9447 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7615 ns |  0.0477 ns | 0.0026 ns |   2.7589 ns |   2.7641 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2358 ns |  3.8738 ns | 0.2123 ns |  50.0894 ns |  50.4793 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.7244 ns |  2.5868 ns | 0.1418 ns |   0.6222 ns |   0.8862 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5543 ns |  0.6297 ns | 0.0345 ns |  52.5145 ns |  52.5751 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0969 ns |  0.2082 ns | 0.0114 ns |   3.0850 ns |   3.1077 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **201.1112 ns** | **17.1637 ns** | **0.9408 ns** | **200.2712 ns** | **202.1278 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6470 ns |  0.1412 ns | 0.0077 ns |   0.6419 ns |   0.6559 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.3971 ns | 48.9021 ns | 2.6805 ns | 210.6377 ns | 215.4821 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.1583 ns |  0.9827 ns | 0.0539 ns |   9.0975 ns |   9.2000 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.5012 ns |  5.9145 ns | 0.3242 ns | 148.1469 ns | 148.7830 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6252 ns |  0.0750 ns | 0.0041 ns |   0.6226 ns |   0.6299 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 154.9166 ns |  1.4017 ns | 0.0768 ns | 154.8279 ns | 154.9636 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.2989 ns |  1.4140 ns | 0.0775 ns |   9.2102 ns |   9.3535 ns |         - |
