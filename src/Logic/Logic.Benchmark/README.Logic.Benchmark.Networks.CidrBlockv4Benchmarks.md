```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Median      | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **67.3272 ns** | **3.3012 ns** | **0.1809 ns** |  **67.2295 ns** |  **67.2161 ns** |  **67.5360 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.1260 ns | 3.2020 ns | 0.1755 ns |   0.0282 ns |   0.0211 ns |   0.3286 ns |         - |
| TryParseCidrString | 1      |  73.0485 ns | 2.6891 ns | 0.1474 ns |  72.9743 ns |  72.9529 ns |  73.2182 ns |         - |
| TryParseCidrBytes  | 1      |   2.7498 ns | 0.1421 ns | 0.0078 ns |   2.7467 ns |   2.7440 ns |   2.7586 ns |         - |
| **NewFromCidrString**  | **3**      | **198.4640 ns** | **8.7781 ns** | **0.4812 ns** | **198.3797 ns** | **198.0305 ns** | **198.9817 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6430 ns | 0.0789 ns | 0.0043 ns |   0.6433 ns |   0.6385 ns |   0.6472 ns |         - |
| TryParseCidrString | 3      | 215.2789 ns | 0.8957 ns | 0.0491 ns | 215.3003 ns | 215.2228 ns | 215.3137 ns |         - |
| TryParseCidrBytes  | 3      |   9.4256 ns | 1.3043 ns | 0.0715 ns |   9.4496 ns |   9.3452 ns |   9.4820 ns |         - |
