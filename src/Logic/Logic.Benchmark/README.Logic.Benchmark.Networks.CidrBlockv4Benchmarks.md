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
| **NewFromCidrString**  | **.NET 8.0** | **1**      |  **64.9330 ns** | **5.5210 ns** | **0.3026 ns** |  **64.7306 ns** |  **65.2809 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 1      |   0.0218 ns | 0.0590 ns | 0.0032 ns |   0.0183 ns |   0.0248 ns |         - |
| TryParseCidrString | .NET 8.0 | 1      |  73.8155 ns | 6.6935 ns | 0.3669 ns |  73.5246 ns |  74.2276 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 1      |   2.7704 ns | 0.3285 ns | 0.0180 ns |   2.7586 ns |   2.7911 ns |         - |
| NewFromCidrString  | .NET 9.0 | 1      |  50.0420 ns | 2.4561 ns | 0.1346 ns |  49.9556 ns |  50.1971 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 1      |   0.6441 ns | 0.1618 ns | 0.0089 ns |   0.6381 ns |   0.6543 ns |         - |
| TryParseCidrString | .NET 9.0 | 1      |  53.5612 ns | 0.2222 ns | 0.0122 ns |  53.5471 ns |  53.5684 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 1      |   3.0878 ns | 0.0140 ns | 0.0008 ns |   3.0869 ns |   3.0883 ns |         - |
| **NewFromCidrString**  | **.NET 8.0** | **3**      | **201.2799 ns** | **4.4388 ns** | **0.2433 ns** | **201.0819 ns** | **201.5515 ns** |         **-** |
| NewFromCirBytes    | .NET 8.0 | 3      |   0.6343 ns | 0.1266 ns | 0.0069 ns |   0.6263 ns |   0.6389 ns |         - |
| TryParseCidrString | .NET 8.0 | 3      | 216.0739 ns | 3.8836 ns | 0.2129 ns | 215.9462 ns | 216.3197 ns |         - |
| TryParseCidrBytes  | .NET 8.0 | 3      |   9.4602 ns | 1.2547 ns | 0.0688 ns |   9.3823 ns |   9.5126 ns |         - |
| NewFromCidrString  | .NET 9.0 | 3      | 148.6248 ns | 1.2538 ns | 0.0687 ns | 148.5835 ns | 148.7042 ns |         - |
| NewFromCirBytes    | .NET 9.0 | 3      |   0.6260 ns | 0.0993 ns | 0.0054 ns |   0.6211 ns |   0.6318 ns |         - |
| TryParseCidrString | .NET 9.0 | 3      | 155.5811 ns | 6.2713 ns | 0.3437 ns | 155.3342 ns | 155.9737 ns |         - |
| TryParseCidrBytes  | .NET 9.0 | 3      |   9.3558 ns | 1.1481 ns | 0.0629 ns |   9.3027 ns |   9.4253 ns |         - |
