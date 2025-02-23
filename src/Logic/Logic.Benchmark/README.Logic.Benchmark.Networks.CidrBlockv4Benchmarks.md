```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.6900 ns** | **1.6567 ns** | **0.0908 ns** |  **65.6193 ns** |  **65.7925 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0259 ns | 0.0490 ns | 0.0027 ns |   0.0231 ns |   0.0285 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.1578 ns | 1.5691 ns | 0.0860 ns |  73.0930 ns |  73.2554 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7686 ns | 0.2375 ns | 0.0130 ns |   2.7575 ns |   2.7830 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2391 ns | 2.5884 ns | 0.1419 ns |  50.1541 ns |  50.4028 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6244 ns | 0.1127 ns | 0.0062 ns |   0.6208 ns |   0.6315 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  53.0391 ns | 0.5743 ns | 0.0315 ns |  53.0182 ns |  53.0753 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0933 ns | 0.0847 ns | 0.0046 ns |   3.0905 ns |   3.0986 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **197.6359 ns** | **4.8283 ns** | **0.2647 ns** | **197.3363 ns** | **197.8377 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6438 ns | 0.0494 ns | 0.0027 ns |   0.6412 ns |   0.6466 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 210.0786 ns | 3.4664 ns | 0.1900 ns | 209.8593 ns | 210.1937 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3967 ns | 0.2930 ns | 0.0161 ns |   9.3841 ns |   9.4148 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.9355 ns | 3.5046 ns | 0.1921 ns | 148.7187 ns | 149.0845 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6226 ns | 0.0466 ns | 0.0026 ns |   0.6202 ns |   0.6253 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.2813 ns | 1.4574 ns | 0.0799 ns | 155.1903 ns | 155.3401 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3645 ns | 0.9968 ns | 0.0546 ns |   9.3016 ns |   9.3998 ns |         - |
