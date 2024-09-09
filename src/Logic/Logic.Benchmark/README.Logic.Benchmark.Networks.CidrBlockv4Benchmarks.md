```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error     | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **64.4763 ns** | **2.5193 ns** | **0.1381 ns** |  **64.3919 ns** |  **64.6357 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0198 ns | 0.0516 ns | 0.0028 ns |   0.0175 ns |   0.0229 ns |         - |
| TryParseCidrString | 1      |  72.3803 ns | 2.4490 ns | 0.1342 ns |  72.2746 ns |  72.5313 ns |         - |
| TryParseCidrBytes  | 1      |   2.7533 ns | 0.2444 ns | 0.0134 ns |   2.7450 ns |   2.7687 ns |         - |
| **NewFromCidrString**  | **3**      | **194.3401 ns** | **1.2632 ns** | **0.0692 ns** | **194.2915 ns** | **194.4194 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6520 ns | 0.3252 ns | 0.0178 ns |   0.6388 ns |   0.6723 ns |         - |
| TryParseCidrString | 3      | 208.6072 ns | 4.0176 ns | 0.2202 ns | 208.4383 ns | 208.8563 ns |         - |
| TryParseCidrBytes  | 3      |   9.4196 ns | 2.9143 ns | 0.1597 ns |   9.2795 ns |   9.5935 ns |         - |
