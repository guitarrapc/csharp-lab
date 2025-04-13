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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **64.8934 ns** | **16.8017 ns** | **0.9210 ns** |  **63.9627 ns** |  **65.8043 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.3407 ns |  0.0716 ns | 0.0039 ns |   0.3382 ns |   0.3452 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  72.6082 ns |  8.4325 ns | 0.4622 ns |  72.1956 ns |  73.1077 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7649 ns |  0.2357 ns | 0.0129 ns |   2.7574 ns |   2.7799 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.4937 ns |  1.3196 ns | 0.0723 ns |  50.4107 ns |  50.5436 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6223 ns |  0.0197 ns | 0.0011 ns |   0.6211 ns |   0.6232 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.1497 ns |  5.8865 ns | 0.3227 ns |  51.7814 ns |  52.3825 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0905 ns |  0.0834 ns | 0.0046 ns |   3.0871 ns |   3.0957 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **202.6699 ns** |  **6.0344 ns** | **0.3308 ns** | **202.4729 ns** | **203.0518 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6422 ns |  0.0387 ns | 0.0021 ns |   0.6409 ns |   0.6447 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 212.0162 ns |  1.8608 ns | 0.1020 ns | 211.9105 ns | 212.1141 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.3097 ns |  1.0084 ns | 0.0553 ns |   9.2622 ns |   9.3704 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.5618 ns |  1.5487 ns | 0.0849 ns | 148.4887 ns | 148.6549 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6520 ns |  0.9137 ns | 0.0501 ns |   0.6223 ns |   0.7098 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.2285 ns |  4.1861 ns | 0.2295 ns | 155.0350 ns | 155.4820 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3272 ns |  0.2992 ns | 0.0164 ns |   9.3157 ns |   9.3460 ns |         - |
