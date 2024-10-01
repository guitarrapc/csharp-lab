```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(5ecb(...)2712) [76]** | **46.5698 ns** | **2.3402 ns** | **0.1283 ns** | **46.4229 ns** | **46.6597 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(8233(...)c6fc) [76]** | **34.3215 ns** | **1.3349 ns** | **0.0732 ns** | **34.2693 ns** | **34.4052 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(a152(...)1c38) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
