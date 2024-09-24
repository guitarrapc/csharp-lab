```

BenchmarkDotNet v0.14.0, Ubuntu 22.04.5 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.401
  [Host]   : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.8 (8.0.824.36612), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method    | data                 | Mean       | Error     | StdDev    | Median     | Min        | Max        | Gen0   | Allocated |
|---------- |--------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|-------:|----------:|
| **SlowMerge** | **(22b7(...)0eed) [76]** | **35.5269 ns** | **2.8780 ns** | **0.1578 ns** | **35.4745 ns** | **35.4020 ns** | **35.7042 ns** | **0.0010** |      **80 B** |
| **FastMerge** | **(2a2f(...)8b10) [76]** |  **0.0031 ns** | **0.0496 ns** | **0.0027 ns** |  **0.0046 ns** |  **0.0000 ns** |  **0.0048 ns** |      **-** |         **-** |
| **FairMerge** | **(ed68(...)da67) [76]** | **46.5224 ns** | **4.8785 ns** | **0.2674 ns** | **46.5263 ns** | **46.2530 ns** | **46.7878 ns** | **0.0017** |     **144 B** |
