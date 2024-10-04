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
| **FairMerge** | **(2374(...)30fc) [76]** | **46.8321 ns** | **3.2726 ns** | **0.1794 ns** | **46.6839 ns** | **47.0315 ns** | **0.0017** |     **144 B** |
| **FastMerge** | **(4723(...)b89c) [76]** |  **0.0000 ns** | **0.0000 ns** | **0.0000 ns** |  **0.0000 ns** |  **0.0000 ns** |      **-** |         **-** |
| **SlowMerge** | **(59e3(...)0374) [76]** | **34.3654 ns** | **1.8095 ns** | **0.0992 ns** | **34.2637 ns** | **34.4618 ns** | **0.0010** |      **80 B** |
