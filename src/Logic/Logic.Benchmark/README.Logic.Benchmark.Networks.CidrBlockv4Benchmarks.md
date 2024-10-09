```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **66.5746 ns** | **3.1567 ns** | **0.1730 ns** |  **66.4462 ns** |  **66.7714 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0234 ns | 0.0642 ns | 0.0035 ns |   0.0195 ns |   0.0263 ns |         - |
| TryParseCidrString | 1      |  72.7001 ns | 3.9932 ns | 0.2189 ns |  72.5222 ns |  72.9446 ns |         - |
| TryParseCidrBytes  | 1      |   2.7558 ns | 0.3048 ns | 0.0167 ns |   2.7446 ns |   2.7750 ns |         - |
| **NewFromCidrString**  | **3**      | **194.2616 ns** | **0.9240 ns** | **0.0506 ns** | **194.2239 ns** | **194.3192 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6402 ns | 0.0939 ns | 0.0051 ns |   0.6364 ns |   0.6460 ns |         - |
| TryParseCidrString | 3      | 209.6366 ns | 1.5390 ns | 0.0844 ns | 209.5420 ns | 209.7040 ns |         - |
| TryParseCidrBytes  | 3      |   9.3090 ns | 1.9285 ns | 0.1057 ns |   9.2230 ns |   9.4270 ns |         - |
