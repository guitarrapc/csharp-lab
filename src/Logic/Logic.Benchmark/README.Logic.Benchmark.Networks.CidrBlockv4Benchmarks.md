```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.2 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.300
  [Host]            : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2
  ShortRun-.NET 8.0 : .NET 8.0.16 (8.0.1625.21506), X64 RyuJIT AVX2
  ShortRun-.NET 9.0 : .NET 9.0.5 (9.0.525.21509), X64 RyuJIT AVX2

IterationCount=3  LaunchCount=1  WarmupCount=3  

```
| Method             | Runtime  | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |--------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **68.0618 ns** |  **1.8891 ns** | **0.1036 ns** |  **67.9890 ns** |  **68.1803 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0217 ns |  0.0256 ns | 0.0014 ns |   0.0202 ns |   0.0228 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.9895 ns |  2.3120 ns | 0.1267 ns |  73.8473 ns |  74.0906 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7596 ns |  0.0312 ns | 0.0017 ns |   2.7579 ns |   2.7613 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  49.9479 ns |  0.5994 ns | 0.0329 ns |  49.9242 ns |  49.9854 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6229 ns |  0.0307 ns | 0.0017 ns |   0.6215 ns |   0.6248 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  52.5941 ns |  0.5869 ns | 0.0322 ns |  52.5678 ns |  52.6300 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0904 ns |  0.0338 ns | 0.0019 ns |   3.0883 ns |   3.0917 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **199.8724 ns** |  **3.7678 ns** | **0.2065 ns** | **199.6720 ns** | **200.0846 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6425 ns |  0.0333 ns | 0.0018 ns |   0.6413 ns |   0.6446 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 210.7585 ns | 12.6979 ns | 0.6960 ns | 210.1191 ns | 211.4999 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4255 ns |  0.5898 ns | 0.0323 ns |   9.3886 ns |   9.4486 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.3809 ns | 32.6485 ns | 1.7896 ns | 147.3385 ns | 150.4473 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6240 ns |  0.0281 ns | 0.0015 ns |   0.6226 ns |   0.6257 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.2855 ns |  1.1670 ns | 0.0640 ns | 155.2414 ns | 155.3589 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3584 ns |  0.7167 ns | 0.0393 ns |   9.3329 ns |   9.4036 ns |         - |
