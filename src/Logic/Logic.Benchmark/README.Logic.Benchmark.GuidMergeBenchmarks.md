```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error      | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|-----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **FastMerge** | **(2f60(...)ebcb) [76]** |  **0.0048 ns** |  **0.0761 ns** | **0.0042 ns** |  **0.0072 ns** |  **0.0000 ns** |  **0.0073 ns** |      **-** |         **-** |
| **SlowMerge** | **(675e(...)a9e9) [76]** | **35.5379 ns** | **11.5509 ns** | **0.6331 ns** | **35.3490 ns** | **35.0207 ns** | **36.2440 ns** | **0.0010** |      **80 B** |
| **FairMerge** | **(f165(...)cd7e) [76]** | **50.6914 ns** |  **1.2674 ns** | **0.0695 ns** | **50.6571 ns** | **50.6456 ns** | **50.7713 ns** | **0.0017** |     **144 B** |
