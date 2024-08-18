```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method             | Number | Mean        | Error      | StdDev    | Min         | Max         | Allocated |
|------------------- |------- |------------:|-----------:|----------:|------------:|------------:|----------:|
| **NewFromCidrString**  | **1**      |  **65.4343 ns** | **11.4635 ns** | **0.6284 ns** |  **65.0709 ns** |  **66.1598 ns** |         **-** |
| NewFromCirBytes    | 1      |   0.0187 ns |  0.0119 ns | 0.0007 ns |   0.0180 ns |   0.0193 ns |         - |
| TryParseCidrString | 1      |  73.2070 ns |  6.6375 ns | 0.3638 ns |  72.9794 ns |  73.6266 ns |         - |
| TryParseCidrBytes  | 1      |   2.7712 ns |  0.4815 ns | 0.0264 ns |   2.7446 ns |   2.7974 ns |         - |
| **NewFromCidrString**  | **3**      | **194.7651 ns** |  **7.8261 ns** | **0.4290 ns** | **194.3577 ns** | **195.2128 ns** |         **-** |
| NewFromCirBytes    | 3      |   0.6405 ns |  0.0108 ns | 0.0006 ns |   0.6399 ns |   0.6410 ns |         - |
| TryParseCidrString | 3      | 210.7280 ns |  3.3435 ns | 0.1833 ns | 210.5733 ns | 210.9304 ns |         - |
| TryParseCidrBytes  | 3      |   9.2336 ns |  1.4198 ns | 0.0778 ns |   9.1453 ns |   9.2922 ns |         - |
