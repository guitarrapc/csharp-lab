```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **66.9156 ns** |  **5.1321 ns** | **0.2813 ns** |  **66.7527 ns** |  **67.2404 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0395 ns |  0.3785 ns | 0.0207 ns |   0.0214 ns |   0.0621 ns |         - |
| TryParseCidrString | 1      |  73.9287 ns |  4.0696 ns | 0.2231 ns |  73.7926 ns |  74.1861 ns |         - |
| TryParseCidrBytes  | 1      |   2.7732 ns |  0.2926 ns | 0.0160 ns |   2.7590 ns |   2.7906 ns |         - |
| **NewFromCidrString**  | **3**      | **202.9169 ns** |  **9.8025 ns** | **0.5373 ns** | **202.2987 ns** | **203.2718 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.5433 ns |  0.0552 ns | 0.0030 ns |   0.5403 ns |   0.5463 ns |         - |
| TryParseCidrString | 3      | 211.8864 ns | 12.3163 ns | 0.6751 ns | 211.3156 ns | 212.6316 ns |         - |
| TryParseCidrBytes  | 3      |   9.4026 ns |  0.9855 ns | 0.0540 ns |   9.3556 ns |   9.4616 ns |         - |
