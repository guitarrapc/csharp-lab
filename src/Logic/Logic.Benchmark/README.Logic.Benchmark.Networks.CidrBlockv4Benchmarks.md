```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.200
  [Host]            : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.13 (8.0.1325.6609), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.2 (9.0.225.6610), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **65.2511 ns** |  **4.5909 ns** | **0.2516 ns** |  **65.0572 ns** |  **65.5355 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.3143 ns |  0.2271 ns | 0.0124 ns |   0.3033 ns |   0.3278 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.4681 ns | 17.8071 ns | 0.9761 ns |  72.6519 ns |  74.5493 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7580 ns |  0.0138 ns | 0.0008 ns |   2.7574 ns |   2.7588 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.3696 ns |  0.1196 ns | 0.0066 ns |  50.3633 ns |  50.3764 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6267 ns |  0.1629 ns | 0.0089 ns |   0.6210 ns |   0.6370 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.1819 ns |  1.5302 ns | 0.0839 ns |  52.0921 ns |  52.2582 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.1139 ns |  0.8230 ns | 0.0451 ns |   3.0858 ns |   3.1659 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **200.4940 ns** |  **6.0445 ns** | **0.3313 ns** | **200.1462 ns** | **200.8058 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6454 ns |  0.0947 ns | 0.0052 ns |   0.6415 ns |   0.6513 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.7179 ns | 16.7715 ns | 0.9193 ns | 211.1703 ns | 212.7792 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.1940 ns |  0.4868 ns | 0.0267 ns |   9.1673 ns |   9.2207 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 149.5495 ns |  5.1547 ns | 0.2825 ns | 149.3333 ns | 149.8692 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.3200 ns |  0.1036 ns | 0.0057 ns |   0.3148 ns |   0.3260 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 156.3219 ns | 14.1977 ns | 0.7782 ns | 155.4827 ns | 157.0197 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3955 ns |  1.0644 ns | 0.0583 ns |   9.3551 ns |   9.4624 ns |         - |
