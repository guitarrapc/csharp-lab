```

BenchmarkDotNet v0.14.0, Ubuntu 24.04.1 LTS (Noble Numbat)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 9.0.102
  [Host]   : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2
  ShortRun : .NET 9.0.1 (9.0.124.61010), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **50.3917 ns** |  **1.3794 ns** | **0.0756 ns** |  **50.3240 ns** |  **50.4733 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.6466 ns |  0.7512 ns | 0.0412 ns |   0.6217 ns |   0.6941 ns |         - |
| TryParseCidrString | 1      |  52.9391 ns |  3.6887 ns | 0.2022 ns |  52.7243 ns |  53.1257 ns |         - |
| TryParseCidrBytes  | 1      |   3.1033 ns |  0.3051 ns | 0.0167 ns |   3.0856 ns |   3.1188 ns |         - |
| **NewFromCidrString**  | **3**      | **148.9238 ns** |  **2.8371 ns** | **0.1555 ns** | **148.8179 ns** | **149.1023 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6472 ns |  0.8355 ns | 0.0458 ns |   0.6197 ns |   0.7001 ns |         - |
| TryParseCidrString | 3      | 155.6054 ns | 10.6711 ns | 0.5849 ns | 155.1614 ns | 156.2682 ns |         - |
| TryParseCidrBytes  | 3      |   9.3134 ns |  1.1558 ns | 0.0634 ns |   9.2439 ns |   9.3680 ns |         - |
