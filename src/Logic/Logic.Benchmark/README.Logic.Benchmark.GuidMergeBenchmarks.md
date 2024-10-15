```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.403
  [Host]   : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-------:|----------:|
| **FairMerge** | **(233d(...)0e3b) [76]** | **46.5175 ns** | **1.7830 ns** | **0.0977 ns** | **46.4398 ns** | **46.6272 ns** | **0.0017** |     **144 B** |
| **SlowMerge** | **(558e(...)8c82) [76]** | **33.6391 ns** | **0.3153 ns** | **0.0173 ns** | **33.6194 ns** | **33.6520 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(9005(...)5f16) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
