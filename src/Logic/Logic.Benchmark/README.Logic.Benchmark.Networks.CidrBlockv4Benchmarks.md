```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.303
  [Host]   : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.7 (8.0.724.31311), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.2460 ns** |  **1.0309 ns** | **0.0565 ns** |  **67.1839 ns** |  **67.2945 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0000 ns |  0.0000 ns | 0.0000 ns |   0.0000 ns |   0.0000 ns |         - |
| TryParseCidrString | 1      |  74.1180 ns |  2.1268 ns | 0.1166 ns |  74.0462 ns |  74.2525 ns |         - |
| TryParseCidrBytes  | 1      |   3.0510 ns |  0.2287 ns | 0.0125 ns |   3.0365 ns |   3.0583 ns |         - |
| **NewFromCidrString**  | **3**      | **199.1724 ns** | **67.3262 ns** | **3.6904 ns** | **196.8582 ns** | **203.4282 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5991 ns |  0.0025 ns | 0.0001 ns |   0.5989 ns |   0.5992 ns |         - |
| TryParseCidrString | 3      | 214.3321 ns | 10.1944 ns | 0.5588 ns | 213.6916 ns | 214.7200 ns |         - |
| TryParseCidrBytes  | 3      |   9.0569 ns |  0.6645 ns | 0.0364 ns |   9.0237 ns |   9.0959 ns |         - |
