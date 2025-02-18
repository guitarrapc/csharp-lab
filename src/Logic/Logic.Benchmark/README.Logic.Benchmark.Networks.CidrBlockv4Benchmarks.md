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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **66.1860 ns** |  **2.2928 ns** | **0.1257 ns** |  **66.0813 ns** |  **66.3254 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0213 ns |  0.0509 ns | 0.0028 ns |   0.0195 ns |   0.0245 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.5309 ns |  3.6395 ns | 0.1995 ns |  73.4039 ns |  73.7608 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7646 ns |  0.2214 ns | 0.0121 ns |   2.7568 ns |   2.7786 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.2646 ns |  1.6661 ns | 0.0913 ns |  50.1961 ns |  50.3683 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6221 ns |  0.0367 ns | 0.0020 ns |   0.6206 ns |   0.6244 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  55.2492 ns |  3.5763 ns | 0.1960 ns |  55.1065 ns |  55.4727 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0970 ns |  0.0986 ns | 0.0054 ns |   3.0909 ns |   3.1013 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **200.2187 ns** | **12.4391 ns** | **0.6818 ns** | **199.4347 ns** | **200.6732 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6464 ns |  0.1107 ns | 0.0061 ns |   0.6403 ns |   0.6524 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 211.4727 ns |  2.0884 ns | 0.1145 ns | 211.4021 ns | 211.6047 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.5584 ns |  0.6487 ns | 0.0356 ns |   9.5241 ns |   9.5951 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.1971 ns |  4.6447 ns | 0.2546 ns | 148.0402 ns | 148.4909 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6311 ns |  0.0450 ns | 0.0025 ns |   0.6283 ns |   0.6330 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 157.4047 ns | 66.6022 ns | 3.6507 ns | 155.2282 ns | 161.6194 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.4918 ns |  0.3251 ns | 0.0178 ns |   9.4779 ns |   9.5119 ns |         - |
