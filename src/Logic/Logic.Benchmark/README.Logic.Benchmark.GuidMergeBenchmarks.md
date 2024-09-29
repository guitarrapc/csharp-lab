```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.402
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(175e(...)fc94) [76]** | **34.4435 ns** | **1.3433 ns** | **0.0736 ns** | **34.4417 ns** | **34.3708 ns** | **34.5181 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(47b8(...)f993) [76]** |  **0.0000 ns** | **0.0010 ns** | **0.0001 ns** |  **0.0000 ns** |  **0.0000 ns** |  **0.0001 ns** |      **-** |         **-** |
| **FairMerge** | **(9cd6(...)c0a7) [76]** | **46.6028 ns** | **5.6513 ns** | **0.3098 ns** | **46.5506 ns** | **46.3224 ns** | **46.9353 ns** | **0.0017** |     **144 B** |
